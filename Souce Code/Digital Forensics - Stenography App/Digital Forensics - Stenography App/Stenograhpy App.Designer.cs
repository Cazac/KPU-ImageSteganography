namespace Digital_Forensics___Stenography_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FilePathB = new System.Windows.Forms.Button();
            this.ReadTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadFileB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WriteTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WriteFileB = new System.Windows.Forms.Button();
            this.ImagePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilePathTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePathB
            // 
            this.FilePathB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FilePathB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilePathB.Location = new System.Drawing.Point(112, 14);
            this.FilePathB.Name = "FilePathB";
            this.FilePathB.Size = new System.Drawing.Size(144, 23);
            this.FilePathB.TabIndex = 1;
            this.FilePathB.Text = "Select File Path";
            this.FilePathB.UseVisualStyleBackColor = false;
            this.FilePathB.Click += new System.EventHandler(this.FilePathB_Click);
            // 
            // ReadTB
            // 
            this.ReadTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ReadTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReadTB.Location = new System.Drawing.Point(16, 60);
            this.ReadTB.Multiline = true;
            this.ReadTB.Name = "ReadTB";
            this.ReadTB.ReadOnly = true;
            this.ReadTB.Size = new System.Drawing.Size(322, 134);
            this.ReadTB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message";
            // 
            // ReadFileB
            // 
            this.ReadFileB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ReadFileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadFileB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReadFileB.Location = new System.Drawing.Point(13, 216);
            this.ReadFileB.Name = "ReadFileB";
            this.ReadFileB.Size = new System.Drawing.Size(322, 23);
            this.ReadFileB.TabIndex = 0;
            this.ReadFileB.Text = "Read From File";
            this.ReadFileB.UseVisualStyleBackColor = false;
            this.ReadFileB.Click += new System.EventHandler(this.ReadFileB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Steganography - Reader / Writer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Write";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Read";
            // 
            // WriteTB
            // 
            this.WriteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.WriteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriteTB.Location = new System.Drawing.Point(13, 60);
            this.WriteTB.Multiline = true;
            this.WriteTB.Name = "WriteTB";
            this.WriteTB.Size = new System.Drawing.Size(322, 134);
            this.WriteTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // WriteFileB
            // 
            this.WriteFileB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.WriteFileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteFileB.Location = new System.Drawing.Point(13, 216);
            this.WriteFileB.Name = "WriteFileB";
            this.WriteFileB.Size = new System.Drawing.Size(322, 23);
            this.WriteFileB.TabIndex = 1;
            this.WriteFileB.Text = "Write To File";
            this.WriteFileB.UseVisualStyleBackColor = false;
            this.WriteFileB.Click += new System.EventHandler(this.WriteFileB_Click);
            // 
            // ImagePicture
            // 
            this.ImagePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePicture.Location = new System.Drawing.Point(13, 46);
            this.ImagePicture.Name = "ImagePicture";
            this.ImagePicture.Size = new System.Drawing.Size(700, 189);
            this.ImagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePicture.TabIndex = 11;
            this.ImagePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WriteTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WriteFileB);
            this.panel1.Location = new System.Drawing.Point(20, 365);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(350, 250);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ReadFileB);
            this.panel3.Controls.Add(this.ReadTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(397, 365);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(350, 250);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FilePathTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.FilePathB);
            this.panel2.Controls.Add(this.ImagePicture);
            this.panel2.Location = new System.Drawing.Point(20, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(728, 250);
            this.panel2.TabIndex = 14;
            // 
            // FilePathTB
            // 
            this.FilePathTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.FilePathTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePathTB.Location = new System.Drawing.Point(262, 15);
            this.FilePathTB.Name = "FilePathTB";
            this.FilePathTB.Size = new System.Drawing.Size(451, 20);
            this.FilePathTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Image";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(769, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeftLayout = true;
            this.Text = "Steganography Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FilePathB;
        private System.Windows.Forms.Button ReadFileB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReadTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WriteTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button WriteFileB;
        private System.Windows.Forms.PictureBox ImagePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FilePathTB;
    }
}

