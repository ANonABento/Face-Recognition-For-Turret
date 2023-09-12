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
            pictureBoxCamera = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Location = new Point(12, 12);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(770, 426);
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(pictureBoxCamera);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCamera;
    }
}