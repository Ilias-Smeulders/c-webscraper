namespace Webscraper
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIndeed = new System.Windows.Forms.Button();
            this.btnYT = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(14, 402);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 58);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIndeed
            // 
            this.btnIndeed.Font = new System.Drawing.Font("Segoe Print", 16.2F);
            this.btnIndeed.Location = new System.Drawing.Point(14, 156);
            this.btnIndeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnIndeed.Name = "btnIndeed";
            this.btnIndeed.Size = new System.Drawing.Size(182, 58);
            this.btnIndeed.TabIndex = 1;
            this.btnIndeed.Text = "Indeed";
            this.btnIndeed.UseVisualStyleBackColor = true;
            this.btnIndeed.Click += new System.EventHandler(this.btnIndeed_Click);
            // 
            // btnYT
            // 
            this.btnYT.Font = new System.Drawing.Font("Segoe Print", 16.2F);
            this.btnYT.Location = new System.Drawing.Point(15, 219);
            this.btnYT.Margin = new System.Windows.Forms.Padding(2);
            this.btnYT.Name = "btnYT";
            this.btnYT.Size = new System.Drawing.Size(182, 58);
            this.btnYT.TabIndex = 2;
            this.btnYT.Text = "Youtube";
            this.btnYT.UseVisualStyleBackColor = true;
            this.btnYT.Click += new System.EventHandler(this.btnYT_Click);
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(15, 281);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(182, 58);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Webscraper.Properties.Resources.abstract_eye_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnYT);
            this.Controls.Add(this.btnIndeed);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnIndeed;
        private System.Windows.Forms.Button btnYT;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}