namespace 扁平化UI
{
    partial class labstart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labstart));
            this.remotescreen = new AxMSTSCLib.AxMsRdpClient11();
            ((System.ComponentModel.ISupportInitialize)(this.remotescreen)).BeginInit();
            this.SuspendLayout();
            // 
            // remotescreen
            // 
            this.remotescreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remotescreen.Enabled = true;
            this.remotescreen.Location = new System.Drawing.Point(0, 0);
            this.remotescreen.Name = "remotescreen";
            this.remotescreen.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("remotescreen.OcxState")));
            this.remotescreen.Size = new System.Drawing.Size(1205, 786);
            this.remotescreen.TabIndex = 0;
            this.remotescreen.OnConnecting += new System.EventHandler(this.remotescreen_OnConnecting);
            // 
            // labstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1205, 786);
            this.Controls.Add(this.remotescreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "labstart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "labstart";
            this.Load += new System.EventHandler(this.labstart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remotescreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient11 remotescreen;
    }
}