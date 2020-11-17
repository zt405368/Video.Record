using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using System.Drawing;
using System.Timers;

namespace Video.Record
{
    public class CameraRecorder
    {

        private VideoFileWriter VideoWriter;

        /// <summary>
        /// 操作摄像头
        /// </summary>
        private VideoCaptureDevice Camera = null;

        /// <summary>
        /// 是否已开始录像
        /// </summary>
        private bool IsRecorder = false;

        private int TotalFrame = 0;

        private int recordTimer = 0;

        private Timer timer;

        /// <summary>
        /// 摄像头 照片回调
        /// </summary>
        public Action<Bitmap> NewFrame;
        /// <summary>
        /// 录像后 时长回调
        /// </summary>
        public Action<int, string> RecorderTimer;
        public CameraRecorder()
        {
            this.VideoWriter = new VideoFileWriter();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        /// <summary>
        /// 实始化摄像头集合
        /// </summary>
        /// <returns></returns>
        public List<string> Init()
        {
            var devs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return devs.Cast<FilterInfo>().Select(a => a.Name).ToList();
        }

        public void SelectDevice(int index, Action<List<string>> action)
        {
            //获取摄像头列表
            var devs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (devs.Count == 0)
                throw new Exception("未检测到摄像头信息");
            if (index > devs.Count)
                throw new Exception("超出摄像头最大索引");

            var device = new VideoCaptureDevice(devs[index].MonikerString);

            var sizes = device.VideoCapabilities.Select(a =>
              {
                  return string.Format("{0}*{1}", a.FrameSize.Width, a.FrameSize.Height);
              }).ToList();
            action?.Invoke(sizes);
        }

        /// <summary>
        /// 启动摄像头
        /// </summary>
        /// <param name="SizeIndex">摄像头分辨率索引(默认为0)</param>
        public void Open(int cameraIndex, int SizeIndex = 0)
        {
            //获取摄像头列表
            var devs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (devs.Count == 0)
                throw new Exception("未检测到摄像头信息");
            if (cameraIndex < 0 || cameraIndex > devs.Count)
                throw new Exception("超出摄像头最大索引");

            if (Camera != null)
            {
                CloseCamera();
            }
            Camera = new VideoCaptureDevice(devs[cameraIndex].MonikerString);

            if (SizeIndex > Camera.VideoCapabilities.Length || SizeIndex < 0)
                SizeIndex = 0;

            //配置录像参数(宽,高,帧率,比特率等参数)VideoCapabilities这个属性会返回摄像头支持哪些配置,从这里面选一个赋值接即可,我选了第1个
            Camera.VideoResolution = Camera.VideoCapabilities[SizeIndex];
            //设置回调,aforge会不断从这个回调推出图像数据
            Camera.NewFrame += Camera_NewFrame;
            //打开摄像头
            Camera.Start();
        }
        private object locker = new object();
        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            lock (locker)
            {
                var bmp = (Bitmap)eventArgs.Frame.Clone();
                // bit.RotateFlip(RotateFlipType.Rotate180FlipY);
                NewFrame?.Invoke(bmp);

                if (this.VideoWriter.IsOpen)
                {
                    if (!IsRecorder)
                    {
                        Console.WriteLine("Camera_NewFrame:" + TotalFrame);
                        return;
                    }

                    this.VideoWriter.WriteVideoFrame((Bitmap)eventArgs.Frame.Clone());
                }
            }

            //每100帧回收一次虚拟内存
            if ((TotalFrame++) % 100 == 0)
            {
                WindowsApi.ClearMemory();
            }
        }

        /// <summary>
        /// 关闭摄像头
        /// </summary>
        public void CloseCamera()
        {
            StopRecorder();
            if (this.Camera != null)
            {
                this.Camera.NewFrame -= Camera_NewFrame;
                this.Camera.Stop();
            }
        }

        /// <summary>
        /// 启动录像
        /// </summary>
        /// <param name="filePath"></param>
        public void StartRecorder(string filePath, int frameRate = 25)
        {
            lock (locker)
            {
                if (IsRecorder) return;

                VideoCodec videoCodec = VideoCodec.MPEG4;
                var vc = Camera.VideoResolution;
                this.VideoWriter.Open(filePath, vc.FrameSize.Width, vc.FrameSize.Height, frameRate, videoCodec);
                timer.Start();

                IsRecorder = true;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            recordTimer++;
            RecorderTimer?.Invoke(recordTimer, SecondToHour(recordTimer));
        }

        /// <summary>
        /// 结束录像
        /// </summary>
        public void StopRecorder()
        {
            lock (locker)
            {
                if (this.VideoWriter != null)
                {
                    this.IsRecorder = false;
                    timer.Stop();
                    recordTimer = 0;
                    this.VideoWriter.Close();
                }
            }
        }

        /// <summary>
        /// 秒转换小时
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private string SecondToHour(double time)
        {
            int hour = 0;
            int minute = 0;
            int second = 0;
            second = Convert.ToInt32(time);

            if (second > 60)
            {
                minute = second / 60;
                second = second % 60;
            }
            if (minute > 60)
            {
                hour = minute / 60;
                minute = minute % 60;
            }
            return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }
    }
}
