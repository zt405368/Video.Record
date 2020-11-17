namespace Video.Record.Test
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInit = new System.Windows.Forms.Button();
            this.cboDevs = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStartRecorder = new System.Windows.Forms.Button();
            this.btnStopRecorder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboFrameRate = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(313, 8);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cboDevs
            // 
            this.cboDevs.FormattingEnabled = true;
            this.cboDevs.Location = new System.Drawing.Point(12, 10);
            this.cboDevs.Name = "cboDevs";
            this.cboDevs.Size = new System.Drawing.Size(121, 20);
            this.cboDevs.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(394, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStartRecorder
            // 
            this.btnStartRecorder.Location = new System.Drawing.Point(475, 8);
            this.btnStartRecorder.Name = "btnStartRecorder";
            this.btnStartRecorder.Size = new System.Drawing.Size(75, 23);
            this.btnStartRecorder.TabIndex = 0;
            this.btnStartRecorder.Text = "开始录像";
            this.btnStartRecorder.UseVisualStyleBackColor = true;
            this.btnStartRecorder.Click += new System.EventHandler(this.btnStartRecorder_Click);
            // 
            // btnStopRecorder
            // 
            this.btnStopRecorder.Location = new System.Drawing.Point(556, 8);
            this.btnStopRecorder.Name = "btnStopRecorder";
            this.btnStopRecorder.Size = new System.Drawing.Size(75, 23);
            this.btnStopRecorder.TabIndex = 0;
            this.btnStopRecorder.Text = "结束录像";
            this.btnStopRecorder.UseVisualStyleBackColor = true;
            this.btnStopRecorder.Click += new System.EventHandler(this.btnStopRecorder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(637, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picVideo
            // 
            this.picVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVideo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picVideo.Location = new System.Drawing.Point(12, 38);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(881, 446);
            this.picVideo.TabIndex = 2;
            this.picVideo.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(730, 13);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(53, 12);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00:00:00";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(142, 10);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(112, 20);
            this.cboSize.TabIndex = 1;
            // 
            // cboFrameRate
            // 
            this.cboFrameRate.FormattingEnabled = true;
            this.cboFrameRate.Location = new System.Drawing.Point(260, 10);
            this.cboFrameRate.Name = "cboFrameRate";
            this.cboFrameRate.Size = new System.Drawing.Size(47, 20);
            this.cboFrameRate.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(818, 7);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 486);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.cboFrameRate);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.cboDevs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStopRecorder);
            this.Controls.Add(this.btnStartRecorder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnInit);
            this.Name = "FrmMain";
            this.Text = "录像测试";
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.ComboBox cboDevs;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnStartRecorder;
        private System.Windows.Forms.Button btnStopRecorder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picVideo;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboFrameRate;
        private System.Windows.Forms.Button btnTest;
    }
}

