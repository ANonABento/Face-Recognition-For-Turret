using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Dnn;
using Emgu.CV.Face;
using Emgu.CV.Structure;

namespace Face_Recognition_Nerf_Turret
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Load the Haar Cascade Classifier for face detection
        CascadeClassifier faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");

        //variables for camera
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

            // Define the desired center of the camera view (adjust as needed)
            int cameraCenterX = frame.Width / 2; // X-coordinate of the center
            int cameraCenterY = frame.Height / 2; // Y-coordinate of the center


            if (frame != null)
            {
                // Convert the OpenCV Mat to a .NET Bitmap for display
                Bitmap bitmap = new Bitmap(frame.Width, frame.Height, frame.Step, System.Drawing.Imaging.PixelFormat.Format24bppRgb, frame.DataPointer);

                // Detect faces in the frame
                var grayFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);
                Rectangle[] faces = faceCascade.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty);

                // Perform face recognition on detected faces
                foreach (var faceRect in faces)
                {
                    // Extract the region of interest (ROI) containing the face
                    var faceROI = new Mat(frame, faceRect);

                    // Implement face recognition logic here
                    // You can use OpenCV's face recognition module or other libraries

                    // For example, you can draw a rectangle around detected faces
                    CvInvoke.Rectangle(frame, faceRect, new MCvScalar(0, 0, 255), 2);

                    // Calculate the center of the detected face
                    int faceX = faceRect.X + faceRect.Width / 2;  // X-coordinate of the face center
                    int faceY = faceRect.Y + faceRect.Height / 2; // Y-coordinate of the face center

                    // Calculate the differences between the face center and camera center
                    int horizontalDifference = cameraCenterX - faceX; // Positive if the face is to the right, negative if to the left
                    int verticalDifference = cameraCenterY - faceY;   // Positive if the face is below, negative if above

                    // Log the differences for debugging
                    Debug.WriteLine($"Horizontal Difference: {horizontalDifference}, Vertical Difference: {verticalDifference}");

                    // Implement camera adjustment logic here
                    // You should move or adjust the camera position based on the differences
                    // For example, you can send commands to move a motorized camera mount or adjust servo angles
                }

                // Display the frame in the PictureBox
                pictureBoxCamera.Image = bitmap;
            }
        }

        //end and kill camera once user closes form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_camera != null && _camera.IsOpened)
            {
                _camera.Stop();
                _camera.Dispose();
            }
        }

        //boolean for pause state
        bool isPaused = false;
        private void btnPauseCam_Click(object sender, EventArgs e)
        {
            if (isPaused) //start camera if button is pressed when paused and set bool to not paused
            {
                _camera.Start();
                isPaused = false;
            }
            else //pause camera if button is pressed when not paused and set bool to paused
            {
                _camera.Stop();
                isPaused = true;
            }
        }
    }
}