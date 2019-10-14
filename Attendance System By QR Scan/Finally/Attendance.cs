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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

//Install-Package Barcode
//Install-Package AForge
//Install-Package AForge.Video
//Install-Package AForge.Video.DirectShow
//Install-Package ZXing.Net -Version 0.16.5
//Install-Package BarCode -Version 4.0.2.2

//https://foxlearn.com/windows-forms/qr-code-scanner-using-camera-in-csharp-380.html

namespace Finally
{
    public partial class Attendance : Form
    {
        TheServices services = new TheServices();
        
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        String Import_FileName;
        long count = 1;
        int wait = 0;
        String previous = "";

        public Attendance(String Import_FileName)
        {
            this.Import_FileName = Import_FileName;
            services.ConnectionBuild(Import_FileName);
            InitializeComponent();
        }
        private void Attendance_Load(object sender, EventArgs e)
        {
            pictureBox.Hide();
            scanButton.Hide();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
            {
                cameraComboBox.Items.Add(Device.Name);
            }
            cameraComboBox.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void FinalFrame_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            //try
            //{
                pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
            //}
            //catch
            //{
            //    MessageBox.Show("Problem");
            //    timer1.Stop();
            //    videoCaptureDevice.Stop();
            //    videoCaptureDevice = new VideoCaptureDevice();
            //    videoCaptureDevice.Start();
            //    timer1.Start();
            //}
        }

        private void DetectButton_Click(object sender, EventArgs e)
        {
            if (services.Check(dayTextBox.Text))
            {
                pictureBox.Show();
                scanButton.Show();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraComboBox.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            }
            else
            {
                scanButton.Hide();
                MessageBox.Show("Day" + dayTextBox.Text + " not found !");
            }

        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (scanButton.Text.Equals("Scan"))
            {
                videoCaptureDevice.Start();
                scanButton.Text = "Stop Scan";
                timer1.Start();
                pictureBox.Show();
            }
            else
            {
                pictureBox.Hide();
                videoCaptureDevice.Stop();
                timer1.Stop();
                scanButton.Text = "Scan";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox.Image);
            
                string decoded = result.ToString();
                if (decoded != previous)
                {
                    previous = decoded;
                    Console.Beep();
                    services.UpdateDetails(dayTextBox.Text, decoded, Import_FileName);
                    richTextBox.Text += count + ": " + services.ShowName(decoded) + "  " + decoded + "  " + DateTime.Now.ToString("HH:mm:ss") + "\n";
                    //richTextBox.Text += count + ": " + decoded + "  " + " Not Found !" + "\n";
                    count++;
                    found = true;
                    wait = 0;
                }
                else
                {
                    if (wait == 8 && found)
                    {
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        found = false;
                    }
                    wait++;
                }
            }

            catch (Exception ex)
            {
                timer1.Start();
            }
        }

        private void Attendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }
    }
}
