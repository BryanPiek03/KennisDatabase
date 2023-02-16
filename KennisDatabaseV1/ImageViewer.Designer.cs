namespace KennisDatabaseV1
{
    partial class ImageViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClsBtn = new System.Windows.Forms.Button();
            this.btnImgRight = new System.Windows.Forms.Button();
            this.btnImgLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(46, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 427);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Viewer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // ClsBtn
            // 
            this.ClsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.ClsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClsBtn.BackgroundImage")));
            this.ClsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClsBtn.FlatAppearance.BorderSize = 0;
            this.ClsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClsBtn.Location = new System.Drawing.Point(777, 0);
            this.ClsBtn.Name = "ClsBtn";
            this.ClsBtn.Size = new System.Drawing.Size(23, 23);
            this.ClsBtn.TabIndex = 8;
            this.ClsBtn.UseVisualStyleBackColor = false;
            this.ClsBtn.Click += new System.EventHandler(this.ClsBtn_Click);
            // 
            // btnImgRight
            // 
            this.btnImgRight.BackColor = System.Drawing.Color.Transparent;
            this.btnImgRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImgRight.BackgroundImage")));
            this.btnImgRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImgRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImgRight.FlatAppearance.BorderSize = 0;
            this.btnImgRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImgRight.Location = new System.Drawing.Point(754, 23);
            this.btnImgRight.Name = "btnImgRight";
            this.btnImgRight.Size = new System.Drawing.Size(46, 427);
            this.btnImgRight.TabIndex = 9;
            this.btnImgRight.UseVisualStyleBackColor = false;
            this.btnImgRight.Click += new System.EventHandler(this.btnImgRight_Click);
            // 
            // btnImgLeft
            // 
            this.btnImgLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnImgLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImgLeft.BackgroundImage")));
            this.btnImgLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImgLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImgLeft.FlatAppearance.BorderSize = 0;
            this.btnImgLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImgLeft.ForeColor = System.Drawing.Color.Transparent;
            this.btnImgLeft.Location = new System.Drawing.Point(0, 23);
            this.btnImgLeft.Name = "btnImgLeft";
            this.btnImgLeft.Size = new System.Drawing.Size(46, 427);
            this.btnImgLeft.TabIndex = 10;
            this.btnImgLeft.UseVisualStyleBackColor = false;
            this.btnImgLeft.Click += new System.EventHandler(this.btnImgLeft_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImgLeft);
            this.Controls.Add(this.btnImgRight);
            this.Controls.Add(this.ClsBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClsBtn;
        private System.Windows.Forms.Button btnImgRight;
        private System.Windows.Forms.Button btnImgLeft;
    }
}