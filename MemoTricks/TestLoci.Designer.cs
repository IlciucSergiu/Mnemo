namespace MemoTricks
{
    partial class TestLoci
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
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelWords = new System.Windows.Forms.Label();
            this.buttonShowHouse = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelVerify = new System.Windows.Forms.Panel();
            this.checkBoxImages = new System.Windows.Forms.CheckBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonPrevious2 = new System.Windows.Forms.Button();
            this.labelWords2 = new System.Windows.Forms.Label();
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.timerTestLoci = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxHelpImage = new System.Windows.Forms.PictureBox();
            this.labelInfoTestLoci = new System.Windows.Forms.Label();
            this.panelVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(94, 260);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(66, 23);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Visible = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(219, 260);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(66, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(638, 434);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(123, 41);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "Finalizeaza";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Visible = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // labelWords
            // 
            this.labelWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWords.Location = new System.Drawing.Point(119, 214);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(148, 30);
            this.labelWords.TabIndex = 3;
            this.labelWords.Text = "Cuvinte";
            this.labelWords.Visible = false;
            // 
            // buttonShowHouse
            // 
            this.buttonShowHouse.Location = new System.Drawing.Point(473, 434);
            this.buttonShowHouse.Name = "buttonShowHouse";
            this.buttonShowHouse.Size = new System.Drawing.Size(123, 41);
            this.buttonShowHouse.TabIndex = 4;
            this.buttonShowHouse.Text = "Vizualizeaza casa";
            this.buttonShowHouse.UseVisualStyleBackColor = true;
            this.buttonShowHouse.Click += new System.EventHandler(this.buttonShowHouse_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(315, 434);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(123, 41);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Incepe";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelVerify
            // 
            this.panelVerify.Controls.Add(this.checkBoxImages);
            this.panelVerify.Controls.Add(this.buttonFinish);
            this.panelVerify.Controls.Add(this.buttonNext2);
            this.panelVerify.Controls.Add(this.buttonPrevious2);
            this.panelVerify.Controls.Add(this.labelWords2);
            this.panelVerify.Controls.Add(this.textBoxWords);
            this.panelVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVerify.Location = new System.Drawing.Point(0, 0);
            this.panelVerify.Name = "panelVerify";
            this.panelVerify.Size = new System.Drawing.Size(884, 561);
            this.panelVerify.TabIndex = 6;
            this.panelVerify.Visible = false;
            // 
            // checkBoxImages
            // 
            this.checkBoxImages.AutoSize = true;
            this.checkBoxImages.Location = new System.Drawing.Point(36, 372);
            this.checkBoxImages.Name = "checkBoxImages";
            this.checkBoxImages.Size = new System.Drawing.Size(59, 17);
            this.checkBoxImages.TabIndex = 8;
            this.checkBoxImages.Text = "Imagini";
            this.checkBoxImages.UseVisualStyleBackColor = true;
            this.checkBoxImages.CheckedChanged += new System.EventHandler(this.checkBoxImages_CheckedChanged);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(667, 433);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(131, 42);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Verifica";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(259, 247);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(75, 23);
            this.buttonNext2.TabIndex = 3;
            this.buttonNext2.Text = ">";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // buttonPrevious2
            // 
            this.buttonPrevious2.Location = new System.Drawing.Point(121, 247);
            this.buttonPrevious2.Name = "buttonPrevious2";
            this.buttonPrevious2.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious2.TabIndex = 2;
            this.buttonPrevious2.Text = "<";
            this.buttonPrevious2.UseVisualStyleBackColor = true;
            this.buttonPrevious2.Click += new System.EventHandler(this.buttonPrevious2_Click);
            // 
            // labelWords2
            // 
            this.labelWords2.AutoSize = true;
            this.labelWords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWords2.Location = new System.Drawing.Point(148, 168);
            this.labelWords2.Name = "labelWords2";
            this.labelWords2.Size = new System.Drawing.Size(51, 20);
            this.labelWords2.TabIndex = 1;
            this.labelWords2.Text = "label1";
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(152, 202);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.Size = new System.Drawing.Size(133, 20);
            this.textBoxWords.TabIndex = 0;
            // 
            // timerTestLoci
            // 
            this.timerTestLoci.Interval = 1000;
            this.timerTestLoci.Tick += new System.EventHandler(this.timerTestLoci_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(781, 516);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 20);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00:00";
            // 
            // pictureBoxHelpImage
            // 
            this.pictureBoxHelpImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHelpImage.Location = new System.Drawing.Point(397, 50);
            this.pictureBoxHelpImage.Name = "pictureBoxHelpImage";
            this.pictureBoxHelpImage.Size = new System.Drawing.Size(465, 304);
            this.pictureBoxHelpImage.TabIndex = 7;
            this.pictureBoxHelpImage.TabStop = false;
            this.pictureBoxHelpImage.Visible = false;
            // 
            // labelInfoTestLoci
            // 
            this.labelInfoTestLoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoTestLoci.Location = new System.Drawing.Point(62, 111);
            this.labelInfoTestLoci.Name = "labelInfoTestLoci";
            this.labelInfoTestLoci.Size = new System.Drawing.Size(781, 146);
            this.labelInfoTestLoci.TabIndex = 8;
            this.labelInfoTestLoci.Text = "label1";
            // 
            // TestLoci
            // 
            this.AcceptButton = this.buttonNext2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBoxHelpImage);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panelVerify);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonShowHouse);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelInfoTestLoci);
            this.Name = "TestLoci";
            this.Text = "TestLoci";
            this.Load += new System.EventHandler(this.TestLoci_Load);
            this.panelVerify.ResumeLayout(false);
            this.panelVerify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Button buttonShowHouse;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelVerify;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonPrevious2;
        private System.Windows.Forms.Label labelWords2;
        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.Timer timerTestLoci;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxHelpImage;
        private System.Windows.Forms.CheckBox checkBoxImages;
        private System.Windows.Forms.Label labelInfoTestLoci;
    }
}