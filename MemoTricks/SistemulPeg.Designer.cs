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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pictureBoxLista = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftText
            // 
            this.LeftText.BackColor = System.Drawing.Color.White;
            this.LeftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftText.ForeColor = System.Drawing.Color.Black;
            this.LeftText.Location = new System.Drawing.Point(12, 43);
            this.LeftText.Name = "LeftText";
            this.LeftText.Size = new System.Drawing.Size(321, 377);
            this.LeftText.TabIndex = 0;
            this.LeftText.Text = resources.GetString("LeftText.Text");
            // 
            // HeadText
            // 
            this.HeadText.BackColor = System.Drawing.Color.White;
            this.HeadText.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(105)))));
            this.HeadText.Location = new System.Drawing.Point(220, 5);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(365, 38);
            this.HeadText.TabIndex = 1;
            this.HeadText.Text = "Sistemul Peg (cuier)";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(383, 369);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 8;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Visible = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(647, 369);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 9;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pictureBoxLista
            // 
            this.pictureBoxLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLista.Location = new System.Drawing.Point(362, 67);
            this.pictureBoxLista.Name = "pictureBoxLista";
            this.pictureBoxLista.Size = new System.Drawing.Size(371, 296);
            this.pictureBoxLista.TabIndex = 7;
            this.pictureBoxLista.TabStop = false;
            this.pictureBoxLista.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MemoTricks.Imagini1.Cuier;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(362, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 146);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // SistemulPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 429);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.pictureBoxLista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeadText);
            this.Controls.Add(this.LeftText);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "SistemulPeg";
            this.Text = "                              SistemulPeg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LeftText;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxLista;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
    }
}