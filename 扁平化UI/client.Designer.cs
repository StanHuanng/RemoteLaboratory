namespace 扁平化UI
{
    partial class client
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.download_file_select = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.upload_file_select = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 48F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(988, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 110);
            this.label2.TabIndex = 2;
            this.label2.Text = "!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("华文中宋", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.time.Location = new System.Drawing.Point(217, 265);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(57, 59);
            this.time.TabIndex = 4;
            this.time.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(660, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 97);
            this.label3.TabIndex = 3;
            this.label3.Text = "1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "请选择上传的文件";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(351, 460);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 50);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(351, 575);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 50);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "上传报告";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 50);
            this.label5.TabIndex = 12;
            this.label5.Text = "下载报告";
            // 
            // download_file_select
            // 
            this.download_file_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_file_select.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.download_file_select.ForeColor = System.Drawing.Color.White;
            this.download_file_select.Location = new System.Drawing.Point(751, 568);
            this.download_file_select.Name = "download_file_select";
            this.download_file_select.Size = new System.Drawing.Size(153, 57);
            this.download_file_select.TabIndex = 13;
            this.download_file_select.Text = "选择文件";
            this.download_file_select.UseVisualStyleBackColor = true;
            this.download_file_select.Click += new System.EventHandler(this.download_file_select_Click);
            // 
            // download_btn
            // 
            this.download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_btn.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.download_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.download_btn.Location = new System.Drawing.Point(946, 568);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(153, 57);
            this.download_btn.TabIndex = 14;
            this.download_btn.Text = "下载";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // upload_btn
            // 
            this.upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_btn.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upload_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.upload_btn.Location = new System.Drawing.Point(946, 460);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(153, 57);
            this.upload_btn.TabIndex = 15;
            this.upload_btn.Text = "上传";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // upload_file_select
            // 
            this.upload_file_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_file_select.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.upload_file_select.ForeColor = System.Drawing.Color.White;
            this.upload_file_select.Location = new System.Drawing.Point(751, 460);
            this.upload_file_select.Name = "upload_file_select";
            this.upload_file_select.Size = new System.Drawing.Size(153, 57);
            this.upload_file_select.TabIndex = 16;
            this.upload_file_select.Text = "选择文件";
            this.upload_file_select.UseVisualStyleBackColor = true;
            this.upload_file_select.Click += new System.EventHandler(this.upload_file_select_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Title = "请选择要覆盖的文件";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1205, 786);
            this.Controls.Add(this.upload_file_select);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.download_file_select);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "client";
            this.Text = "client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button download_file_select;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Button upload_file_select;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}