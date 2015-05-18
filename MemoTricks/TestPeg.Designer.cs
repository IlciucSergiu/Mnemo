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
            this.panel1 = new System.Windows.Forms.Panel();
            this.next2 = new System.Windows.Forms.Button();
            this.previous2 = new System.Windows.Forms.Button();
            this.labelPos2 = new System.Windows.Forms.Label();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLista)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.verifyButton);
            this.panel1.Controls.Add(this.next2);
            this.panel1.Controls.Add(this.previous2);
            this.panel1.Controls.Add(this.labelPos2);
            this.panel1.Controls.Add(this.testTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 329);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // next2
            // 
            this.next2.Location = new System.Drawing.Point(178, 170);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(75, 23);
            this.next2.TabIndex = 3;
            this.next2.Text = ">";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // previous2
            // 
            this.previous2.Location = new System.Drawing.Point(46, 170);
            this.previous2.Name = "previous2";
            this.previous2.Size = new System.Drawing.Size(75, 23);
            this.previous2.TabIndex = 2;
            this.previous2.Text = "<";
            this.previous2.UseVisualStyleBackColor = true;
            this.previous2.Click += new System.EventHandler(this.previous2_Click);
            // 
            // labelPos2
            // 
            this.labelPos2.AutoSize = true;
            this.labelPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPos2.Location = new System.Drawing.Point(85, 80);
            this.labelPos2.Name = "labelPos2";
            this.labelPos2.Size = new System.Drawing.Size(25, 25);
            this.labelPos2.TabIndex = 1;
            this.labelPos2.Text = "1";
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(74, 122);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(122, 20);
            this.testTextBox.TabIndex = 0;
            this.testTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(404, 243);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(139, 46);
            this.verifyButton.TabIndex = 4;
            this.verifyButton.Text = "Verifica";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // TestPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 326);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.Button previous2;
        private System.Windows.Forms.Label labelPos2;
        private System.Windows.Forms.Button verifyButton;
    }
}