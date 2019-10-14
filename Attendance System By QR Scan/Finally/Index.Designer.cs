namespace Finally
{
    partial class Index
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
            this.indexPanel = new System.Windows.Forms.Panel();
            this.indexlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.readButton = new System.Windows.Forms.Button();
            this.attendanceBbutton = new System.Windows.Forms.Button();
            this.pathButton = new System.Windows.Forms.Button();
            this.indexPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // indexPanel
            // 
            this.indexPanel.Controls.Add(this.indexlabel);
            this.indexPanel.Location = new System.Drawing.Point(0, 1);
            this.indexPanel.Name = "indexPanel";
            this.indexPanel.Size = new System.Drawing.Size(801, 449);
            this.indexPanel.TabIndex = 0;
            this.indexPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IndexPanel_MouseClick);
            // 
            // indexlabel
            // 
            this.indexlabel.AutoSize = true;
            this.indexlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.indexlabel.Location = new System.Drawing.Point(241, 184);
            this.indexlabel.Name = "indexlabel";
            this.indexlabel.Size = new System.Drawing.Size(308, 58);
            this.indexlabel.TabIndex = 0;
            this.indexlabel.Text = "Welcome Sir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse File ";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(243, 31);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(332, 22);
            this.pathTextBox.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 196);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 254);
            this.dataGridView.TabIndex = 3;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(243, 102);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(101, 33);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // attendanceBbutton
            // 
            this.attendanceBbutton.Location = new System.Drawing.Point(441, 102);
            this.attendanceBbutton.Name = "attendanceBbutton";
            this.attendanceBbutton.Size = new System.Drawing.Size(134, 33);
            this.attendanceBbutton.TabIndex = 4;
            this.attendanceBbutton.Text = "Take Attendance";
            this.attendanceBbutton.UseVisualStyleBackColor = true;
            this.attendanceBbutton.Click += new System.EventHandler(this.AttendanceBbutton_Click);
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(581, 31);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(29, 23);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indexPanel);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.attendanceBbutton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.indexPanel.ResumeLayout(false);
            this.indexPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel indexPanel;
        private System.Windows.Forms.Label indexlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button attendanceBbutton;
        private System.Windows.Forms.Button pathButton;
    }
}

