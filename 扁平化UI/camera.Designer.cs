namespace 扁平化UI
{
    partial class camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(camera));
            this.camera_headline = new System.Windows.Forms.Label();
            this.btn_cameraconnect = new System.Windows.Forms.Button();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // camera_headline
            // 
            this.camera_headline.AutoSize = true;
            this.camera_headline.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.camera_headline.ForeColor = System.Drawing.Color.White;
            this.camera_headline.Location = new System.Drawing.Point(475, 205);
            this.camera_headline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.camera_headline.Name = "camera_headline";
            this.camera_headline.Size = new System.Drawing.Size(232, 34);
            this.camera_headline.TabIndex = 11;
            this.camera_headline.Text = "实验摄像头连接";
            // 
            // btn_cameraconnect
            // 
            this.btn_cameraconnect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cameraconnect.ForeColor = System.Drawing.Color.Black;
            this.btn_cameraconnect.Location = new System.Drawing.Point(375, 444);
            this.btn_cameraconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cameraconnect.Name = "btn_cameraconnect";
            this.btn_cameraconnect.Size = new System.Drawing.Size(382, 46);
            this.btn_cameraconnect.TabIndex = 10;
            this.btn_cameraconnect.Text = "连接";
            this.btn_cameraconnect.UseVisualStyleBackColor = false;
            this.btn_cameraconnect.Click += new System.EventHandler(this.btn_cameraconnect_Click);
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(375, 333);
            this.ip_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(382, 28);
            this.ip_textbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP 地址";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1205, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.camera_headline);
            this.Controls.Add(this.btn_cameraconnect);
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "camera";
            this.Load += new System.EventHandler(this.camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label camera_headline;
        private System.Windows.Forms.Button btn_cameraconnect;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}