namespace MemoTricks
{
    partial class TestPeg
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
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.checkImages = new System.Windows.Forms.CheckBox();
            this.pictureBoxLista = new System.Windows.Forms.PictureBox();
            this.finish = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuvant";
            this.label1.Visible = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(238, 262);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(127, 37);
            this.start.TabIndex = 1;
            this.start.Text = "Incepe testul";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(151, 159);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 25);
            this.next.TabIndex = 2;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(31, 159);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 25);
            this.previous.TabIndex = 3;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Visible = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(28, 9);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(0, 18);
            this.info1.TabIndex = 4;
            // 
            // info2
            // 
            this.info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.Location = new System.Drawing.Point(12, 243);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(195, 56);
            this.info2.TabIndex = 5;
            // 
            // checkImages
            // 
            this.checkImages.AutoSize = true;
            this.checkImages.Location = new System.Drawing.Point(29, 208);
            this.checkImages.Name = "checkImages";
            this.checkImages.Size = new System.Drawing.Size(59, 17);
            this.checkImages.TabIndex = 6;
            this.checkImages.Text = "Imagini";
            this.checkImages.UseVisualStyleBackColor = true;
            this.checkImages.Visible = false;
            this.checkImages.CheckedChanged += new System.EventHandler(this.checkImages_CheckedChanged);
            // 
            // pictureBoxLista
            // 
            this.pictureBoxLista.BackgroundImage = global::MemoTricks.Imagini1.Cuier;
            this.pictureBoxLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLista.Location = new System.Drawing.Point(330, 42);
            this.pictureBoxLista.Name = "pictureBoxLista";
            this.pictureBoxLista.Size = new System.Drawing.Size(235, 168);
            this.pictureBoxLista.TabIndex = 7;
            this.pictureBoxLista.TabStop = false;
            this.pictureBoxLista.Visible = false;
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(417, 262);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(127, 37);
            this.finish.TabIndex = 8;
            this.finish.Text = "Finalizeaza";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Visible = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Red;
            this.timeLabel.Location = new System.Drawing.Point(256, 223);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(80, 24);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "00:00:00";
            // 
            // TestPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 326);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.pictureBoxLista);
            this.Controls.Add(this.checkImages);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "TestPeg";
            this.Text = "TestPeg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.CheckBox checkImages;
        private System.Windows.Forms.PictureBox pictureBoxLista;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
    }
}