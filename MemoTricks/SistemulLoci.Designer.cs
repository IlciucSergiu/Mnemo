namespace MemoTricks
{
    partial class SistemulLoci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemulLoci));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxLearn1 = new System.Windows.Forms.PictureBox();
            this.buttonPractice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLearn1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(309, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sistemul Loci";
            // 
            // labelText1
            // 
            this.labelText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.Location = new System.Drawing.Point(12, 57);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(344, 424);
            this.labelText1.TabIndex = 1;
            this.labelText1.Text = resources.GetString("labelText1.Text");
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(48, 493);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 39);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(223, 493);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 39);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBoxLearn1
            // 
            this.pictureBoxLearn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLearn1.Location = new System.Drawing.Point(421, 66);
            this.pictureBoxLearn1.Name = "pictureBoxLearn1";
            this.pictureBoxLearn1.Size = new System.Drawing.Size(444, 380);
            this.pictureBoxLearn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLearn1.TabIndex = 5;
            this.pictureBoxLearn1.TabStop = false;
            // 
            // buttonPractice
            // 
            this.buttonPractice.Location = new System.Drawing.Point(579, 470);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(116, 40);
            this.buttonPractice.TabIndex = 6;
            this.buttonPractice.Text = "Exerseaza";
            this.buttonPractice.UseVisualStyleBackColor = true;
            this.buttonPractice.Visible = false;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // SistemulLoci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.pictureBoxLearn1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.labelTitle);
            this.Name = "SistemulLoci";
            this.Text = "Loci";
            this.Load += new System.EventHandler(this.SistemulLoci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLearn1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBoxLearn1;
        private System.Windows.Forms.Button buttonPractice;
    }
}