namespace Face_Recognition_Nerf_Turret
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxCamera = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnPauseCam = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.BackColor = Color.White;
            pictureBoxCamera.Location = new Point(3, 3);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(640, 480);
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPauseCam);
            panel1.Controls.Add(pictureBoxCamera);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 550);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(350, 411);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnPauseCam
            // 
            btnPauseCam.BackColor = Color.LightSteelBlue;
            btnPauseCam.Font = new Font("Wild Words", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPauseCam.ForeColor = Color.Crimson;
            btnPauseCam.Location = new Point(12, 493);
            btnPauseCam.Name = "btnPauseCam";
            btnPauseCam.Size = new Size(123, 46);
            btnPauseCam.TabIndex = 2;
            btnPauseCam.Text = "Pause Feed";
            btnPauseCam.UseVisualStyleBackColor = false;
            btnPauseCam.Click += btnPauseCam_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(672, 576);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCamera;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnPauseCam;
    }
}