namespace Video.Record.Test
{
    partial class FrmCameraTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRecorder = new System.Windows.Forms.Button();
            this.btnStopRecorder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.picVideo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(33, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRecorder
            // 
            this.btnRecorder.Location = new System.Drawing.Point(114, 12);
            this.btnRecorder.Name = "btnRecorder";
            this.btnRecorder.Size = new System.Drawing.Size(75, 23);
            this.btnRecorder.TabIndex = 0;
            this.btnRecorder.Text = "开始录像";
            this.btnRecorder.UseVisualStyleBackColor = true;
            this.btnRecorder.Click += new System.EventHandler(this.btnRecorder_Click);
            // 
            // btnStopRecorder
            // 
            this.btnStopRecorder.Location = new System.Drawing.Point(195, 12);
            this.btnStopRecorder.Name = "btnStopRecorder";
            this.btnStopRecorder.Size = new System.Drawing.Size(75, 23);
            this.btnStopRecorder.TabIndex = 0;
            this.btnStopRecorder.Text = "结束录像";
            this.btnStopRecorder.UseVisualStyleBackColor = true;
            this.btnStopRecorder.Click += new System.EventHandler(this.btnStopRecorder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(372, 17);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(53, 12);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00:00";
            // 
            // picVideo
            // 
            this.picVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVideo.Location = new System.Drawing.Point(12, 41);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(595, 398);
            this.picVideo.TabIndex = 5;
            this.picVideo.TabStop = false;
            // 
            // FrmCameraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 438);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStopRecorder);
            this.Controls.Add(this.btnRecorder);
            this.Controls.Add(this.btnOpen);
            this.Name = "FrmCameraTest";
            this.Text = "FrmCameraTest";
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRecorder;
        private System.Windows.Forms.Button btnStopRecorder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picVideo;
    }
}