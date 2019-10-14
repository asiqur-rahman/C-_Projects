namespace Finally
{
    partial class Attendance
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
            this.scanButton = new System.Windows.Forms.Button();
            this.detectButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.BackColor = System.Drawing.Color.Silver;
            this.scanButton.Location = new System.Drawing.Point(394, 363);
            this.scanButton.Margin = new System.Windows.Forms.Padding(4);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(105, 49);
            this.scanButton.TabIndex = 21;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = false;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // detectButton
            // 
            this.detectButton.BackColor = System.Drawing.Color.Silver;
            this.detectButton.Location = new System.Drawing.Point(253, 363);
            this.detectButton.Margin = new System.Windows.Forms.Padding(4);
            this.detectButton.Name = "detectButton";
            this.detectButton.Size = new System.Drawing.Size(104, 50);
            this.detectButton.TabIndex = 20;
            this.detectButton.Text = "Detect";
            this.detectButton.UseVisualStyleBackColor = false;
            this.detectButton.Click += new System.EventHandler(this.DetectButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(34, 61);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(465, 267);
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.BackColor = System.Drawing.Color.Snow;
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(164, 14);
            this.cameraComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(335, 24);
            this.cameraComboBox.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(-70, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 10);
            this.panel1.TabIndex = 24;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox.Location = new System.Drawing.Point(549, 14);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(230, 393);
            this.richTextBox.TabIndex = 23;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Open Camera";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(124, 379);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(47, 22);
            this.dayTextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Today is Day";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.detectButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cameraComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Attendance_FormClosing);
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button detectButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label label2;
    }
}