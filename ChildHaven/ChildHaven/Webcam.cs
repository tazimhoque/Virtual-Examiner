using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ChildHaven
{
    public partial class Webcam : Form
    {
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

        public Webcam()
        {
            InitializeComponent();
        }

        private void Webcam_Load(object sender, EventArgs e)
        {

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);


            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBoxPic.Items.Add(VideoCaptureDevice.Name);
            }
            comboBoxPic.SelectedIndex = 0;

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBoxPic.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFram);
            cam.Start();
        }

        private void cam_NewFram(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxPic.Image = bit;


            //throw new NotImplementedException();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            saveFileDialogPic.InitialDirectory = @"UserImage";

            if (saveFileDialogPic.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPic.Image.Save(saveFileDialogPic.FileName);

            }
        }

    
    
    }
}
