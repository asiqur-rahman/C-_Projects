using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using Finally.Services;

namespace Finally
{
    public partial class Index : Form
    {
        TheServices services = new TheServices();
        String Import_FileName;
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void IndexPanel_MouseClick(object sender, MouseEventArgs e)
        {
            indexlabel.Hide();
            indexPanel.Hide();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if(Checking())
                dataGridView.DataSource = services.ShowDetails();
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Import_FileName = openFileDialog.FileName;
                pathTextBox.Text = Import_FileName;
            }
        }

        private void AttendanceBbutton_Click(object sender, EventArgs e)
        {
            if (Checking())
            {
                Attendance attendance = new Attendance(Import_FileName);
                attendance.Show();
            }
        }

        private Boolean Checking()
        {
            if (pathTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please Select Excel File First");
                return false;
            }
            else
            {
              if(services.ConnectionBuild(Import_FileName))
                {
                    return true;
                }
              else
                {
                    MessageBox.Show("Please Select Excel File First");
                    return false;
                }
            }
        }
    }
}
