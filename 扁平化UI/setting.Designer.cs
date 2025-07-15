namespace 扁平化UI
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.label1 = new System.Windows.Forms.Label();
            this.spbtn2 = new remotelab.spbtn();
            this.spbtn1 = new remotelab.spbtn();
            ((System.ComponentModel.ISupportInitialize)(this.spbtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbtn1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(940, 733);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "高电位队";
            // 
            // spbtn2
            // 
            this.spbtn2.Image = ((System.Drawing.Image)(resources.GetObject("spbtn2.Image")));
            this.spbtn2.imagehover = ((System.Drawing.Image)(resources.GetObject("spbtn2.imagehover")));
            this.spbtn2.imagenormal = ((System.Drawing.Image)(resources.GetObject("spbtn2.imagenormal")));
            this.spbtn2.Location = new System.Drawing.Point(1093, 684);
            this.spbtn2.Name = "spbtn2";
            this.spbtn2.Size = new System.Drawing.Size(90, 90);
            this.spbtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spbtn2.TabIndex = 3;
            this.spbtn2.TabStop = false;
            this.spbtn2.Click += new System.EventHandler(this.spbtn2_Click);
            // 
            // spbtn1
            // 
            this.spbtn1.Image = ((System.Drawing.Image)(resources.GetObject("spbtn1.Image")));
            this.spbtn1.imagehover = ((System.Drawing.Image)(resources.GetObject("spbtn1.imagehover")));
            this.spbtn1.imagenormal = ((System.Drawing.Image)(resources.GetObject("spbtn1.imagenormal")));
            this.spbtn1.Location = new System.Drawing.Point(569, 184);
            this.spbtn1.Name = "spbtn1";
            this.spbtn1.Size = new System.Drawing.Size(100, 100);
            this.spbtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spbtn1.TabIndex = 1;
            this.spbtn1.TabStop = false;
            this.spbtn1.Click += new System.EventHandler(this.spbtn1_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1205, 786);
            this.Controls.Add(this.spbtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spbtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "setting";
            ((System.ComponentModel.ISupportInitialize)(this.spbtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbtn1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private remotelab.spbtn spbtn1;
        private System.Windows.Forms.Label label1;
        private remotelab.spbtn spbtn2;
    }
}