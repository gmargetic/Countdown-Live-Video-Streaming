namespace Countdown
{
    partial class remote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(remote));
            this.lblCount = new System.Windows.Forms.Label();
            this.pbRemote = new System.Windows.Forms.ProgressBar();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.pictureSmpte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSmpte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 350.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Lime;
            this.lblCount.Location = new System.Drawing.Point(-358, 63);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(2042, 529);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "00:00:00";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRemote
            // 
            this.pbRemote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRemote.Location = new System.Drawing.Point(12, 3);
            this.pbRemote.Name = "pbRemote";
            this.pbRemote.Size = new System.Drawing.Size(1253, 57);
            this.pbRemote.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.CausesValidation = false;
            this.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(184, 154);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(917, 495);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Message";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            this.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.LightGray;
            this.lblClock.Location = new System.Drawing.Point(527, 649);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(145, 55);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "23:12";
            // 
            // pictureSmpte
            // 
            this.pictureSmpte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSmpte.BackgroundImage")));
            this.pictureSmpte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSmpte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureSmpte.Location = new System.Drawing.Point(0, 0);
            this.pictureSmpte.Name = "pictureSmpte";
            this.pictureSmpte.Size = new System.Drawing.Size(1277, 713);
            this.pictureSmpte.TabIndex = 4;
            this.pictureSmpte.TabStop = false;
            this.pictureSmpte.Visible = false;
            // 
            // remote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1277, 713);
            this.ControlBox = false;
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pbRemote);
            this.Controls.Add(this.pictureSmpte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "remote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "remote";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureSmpte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.ProgressBar pbRemote;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.PictureBox pictureSmpte;
    }
}