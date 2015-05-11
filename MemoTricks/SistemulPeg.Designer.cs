namespace MemoTricks
{
    partial class SistemulPeg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemulPeg));
            this.LeftText = new System.Windows.Forms.Label();
            this.HeadText = new System.Windows.Forms.Label();
            this.TopText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.HeadColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftText
            // 
            this.LeftText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.LeftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftText.ForeColor = System.Drawing.Color.White;
            this.LeftText.Location = new System.Drawing.Point(-4, 51);
            this.LeftText.Name = "LeftText";
            this.LeftText.Size = new System.Drawing.Size(321, 377);
            this.LeftText.TabIndex = 0;
            this.LeftText.Text = resources.GetString("LeftText.Text");
            // 
            // HeadText
            // 
            this.HeadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))));
            this.HeadText.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(105)))));
            this.HeadText.Location = new System.Drawing.Point(220, 5);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(365, 38);
            this.HeadText.TabIndex = 1;
            this.HeadText.Text = "Sistemul Peg (cuier)";
            // 
            // TopText
            // 
            this.TopText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.TopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopText.Location = new System.Drawing.Point(-3, 301);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(730, 127);
            this.TopText.TabIndex = 2;
            this.TopText.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MemoTricks.Imagini1.Cuier;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(344, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 146);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // HeadColor
            // 
            this.HeadColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(232)))));
            this.HeadColor.Location = new System.Drawing.Point(-6, -7);
            this.HeadColor.Name = "HeadColor";
            this.HeadColor.Size = new System.Drawing.Size(733, 58);
            this.HeadColor.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 38);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 38);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SistemulPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeadText);
            this.Controls.Add(this.LeftText);
            this.Controls.Add(this.TopText);
            this.Controls.Add(this.HeadColor);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "SistemulPeg";
            this.Text = "                              SistemulPeg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LeftText;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label HeadColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}