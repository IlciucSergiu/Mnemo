namespace MemoTricks
{
    partial class LociHouse
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
            this.pictureBoxHouse = new System.Windows.Forms.PictureBox();
            this.zoomIn = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHouse
            // 
            this.pictureBoxHouse.BackgroundImage = global::MemoTricks.Imagini2.loci_house;
            this.pictureBoxHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHouse.Location = new System.Drawing.Point(-366, -452);
            this.pictureBoxHouse.Name = "pictureBoxHouse";
            this.pictureBoxHouse.Size = new System.Drawing.Size(1668, 1667);
            this.pictureBoxHouse.TabIndex = 0;
            this.pictureBoxHouse.TabStop = false;
            this.pictureBoxHouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxHouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxHouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(754, 514);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(42, 35);
            this.zoomIn.TabIndex = 1;
            this.zoomIn.Text = "+";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Location = new System.Drawing.Point(818, 514);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(42, 35);
            this.ZoomOut.TabIndex = 2;
            this.ZoomOut.Text = "-";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // LociHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.pictureBoxHouse);
            this.Name = "LociHouse";
            this.Text = "LociHouse";
            this.Load += new System.EventHandler(this.LociHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHouse;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button ZoomOut;
    }
}