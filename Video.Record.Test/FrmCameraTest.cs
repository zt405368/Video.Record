using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video.Record.Test
{
    public partial class FrmCameraTest : Form
    {
        CameraRecorder recorder = null;
        public FrmCameraTest()
        {
            InitializeComponent();
            this.FormClosing += FrmCameraTest_FormClosing;

            InitCamera();
        }

        private void FrmCameraTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCamera();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OperCamera();
        }

        private void btnRecorder_Click(object sender, EventArgs e)
        {
            StartRecorder();
        }

        private void btnStopRecorder_Click(object sender, EventArgs e)
        {
            StopRecorder();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseCamera();
        }

        private void InitCamera()
        {
            recorder = new CameraRecorder();
            recorder.NewFrame = frame =>
            {
                this.picVideo.Image = (Bitmap)frame.Clone();
            };

            recorder.RecorderTimer = (seconds, timerString) =>
            {
                //10分钟自动保存一次
                if (seconds > (60 * 60))
                {
                    StopRecorder();
                    StartRecorder();
                }

                this.lblTimer.Invoke(new Action(() =>
                {
                    this.lblTimer.Text = timerString;
                }));
            };
        }

        private void StartRecorder()
        {
            string filePath = Path.Combine(getFilePath(),
                DateTime.Now.ToString("MMddHHmmss") + ".avi");
            recorder.StartRecorder(filePath, 17);
        }

        private void OperCamera()
        {
            int cameraIndex = 0;
            recorder.SelectDevice(cameraIndex, devs =>
            {
                int sizeIndex = devs.IndexOf("1280*720");
                recorder.Open(cameraIndex, sizeIndex);
            });
        }

        private void StopRecorder()
        {
            recorder.StopRecorder();
        }

        private void CloseCamera()
        {
            recorder.CloseCamera();
        }


        private string getFilePath()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "videoPath");
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
            return filePath;
        }

    }
}
