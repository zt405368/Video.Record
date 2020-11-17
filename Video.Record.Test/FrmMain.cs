using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Video.Record.Test
{
    public partial class FrmMain : Form
    {
        CameraRecorder recorder = null;
        public FrmMain()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                this.cboFrameRate.Items.Add(i);
            }
            this.cboFrameRate.Text = "15";
            this.FormClosing += FrmMain_FormClosing;
            this.cboDevs.SelectedIndexChanged += CboDevs_SelectedIndexChanged;
            recorder = new CameraRecorder();
            recorder.NewFrame = frame =>
            {
                this.picVideo.Image = (Bitmap)frame.Clone();
            };

            recorder.RecorderTimer = (seconds, timerString) =>
            {
                    this.lblTimer.Invoke(new Action(() =>
                    {
                        this.lblTimer.Text = timerString;
                    }));
            };
        }

        private void CboDevs_SelectedIndexChanged(object sender, EventArgs e)
        {
            recorder.SelectDevice(this.cboDevs.SelectedIndex, sizes =>
            {
                this.cboSize.Items.Clear();
                if (sizes.Any())
                {
                    this.cboSize.Items.AddRange(sizes.ToArray());
                    this.cboSize.SelectedItem = sizes[0];
                }
            });
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCamera();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            var devs = recorder.Init();
            this.cboDevs.Items.Clear();
            if (devs.Any())
            {
                this.cboDevs.Items.AddRange(devs.ToArray());
                this.cboDevs.SelectedItem = devs[0];
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            recorder.Open(this.cboDevs.SelectedIndex, this.cboSize.SelectedIndex);
        }

        private void btnStartRecorder_Click(object sender, EventArgs e)
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

        private void StartRecorder()
        {
            string filePath = Path.Combine(getFilePath(),
                DateTime.Now.ToString("MMddHHmmss") + ".avi");
            recorder.StartRecorder(filePath, int.Parse(this.cboFrameRate.Text));
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            FrmCameraTest frm = new Test.FrmCameraTest();
            frm.ShowDialog();
        }
    }
}
