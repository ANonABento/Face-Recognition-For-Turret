using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Face_Recognition_Nerf_Turret
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private VideoCapture _camera;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialize the camera
                _camera = new VideoCapture(0);

                // Set camera properties (frame width and height)
                _camera.Set(Emgu.CV.CvEnum.CapProp.FrameWidth, 640);
                _camera.Set(Emgu.CV.CvEnum.CapProp.FrameHeight, 480);

                // Start capturing frames
                _camera.ImageGrabbed += ProcessFrame;
                _camera.Start();
            }
            catch (Exception ex)
            {
                // Handle and log any exceptions
                MessageBox.Show("Error initializing the camera: " + ex.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            _camera.Retrieve(frame);

            if (frame != null)
            {
                // Convert the OpenCV Mat to a .NET Bitmap for display
                Bitmap bitmap = new Bitmap(frame.Width, frame.Height, frame.Step, System.Drawing.Imaging.PixelFormat.Format24bppRgb, frame.DataPointer);

                // Display the frame in the PictureBox
                pictureBoxCamera.Image = bitmap;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_camera != null && _camera.IsOpened)
            {
                _camera.Stop();
                _camera.Dispose();
            }
        }
    }
}