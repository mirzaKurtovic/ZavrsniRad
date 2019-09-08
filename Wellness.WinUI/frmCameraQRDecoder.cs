using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace Wellness.WinUI
{
    public partial class frmCameraQRDecoder: Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        QRCodeHelper QRCodeHelper;
        private int _ticks=0;
        private int _falseResult=0;
        private int _trueResult=0;

        public frmCameraQRDecoder()
        {
            InitializeComponent();
        }

        private void FrmCameraQRDecoder_Load(object sender, EventArgs e)
        {
            QRCodeHelper = new QRCodeHelper();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
           var text = QRCodeHelper.DecodeQRCode(pictureBox1.Image);
            if(String.IsNullOrEmpty(text))
            {
                _falseResult++;
                txtNegative.Text = _falseResult.ToString();
            }
           else
            {
                _trueResult++;
                txtPositive.Text = _trueResult.ToString();
            }

            txtTotal.Text = _ticks.ToString();
        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender,NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnTraziQR_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

        }

        private void FrmCameraQRDecoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning==true)
            {
                FinalFrame.Stop();
            }
        }




    }
}
