namespace MemoTricks
{
    partial class MeniuPrincipal
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
            this.buttonPeg = new System.Windows.Forms.Button();
            this.buttonLoci = new System.Windows.Forms.Button();
            this.buttonMajor = new System.Windows.Forms.Button();
            this.learnPeg = new System.Windows.Forms.Button();
            this.practicePeg = new System.Windows.Forms.Button();
            this.homeInfo = new System.Windows.Forms.Label();
            this.homeInfo2 = new System.Windows.Forms.Label();
            this.practiceLoci = new System.Windows.Forms.Button();
            this.learnLoci = new System.Windows.Forms.Button();
            this.practiceMajor = new System.Windows.Forms.Button();
            this.learnMajor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPeg
            // 
            this.buttonPeg.Location = new System.Drawing.Point(73, 102);
            this.buttonPeg.Name = "buttonPeg";
            this.buttonPeg.Size = new System.Drawing.Size(190, 50);
            this.buttonPeg.TabIndex = 0;
            this.buttonPeg.Text = "Sistemul Peg";
            this.buttonPeg.UseVisualStyleBackColor = true;
            this.buttonPeg.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoci
            // 
            this.buttonLoci.Location = new System.Drawing.Point(73, 204);
            this.buttonLoci.Name = "buttonLoci";
            this.buttonLoci.Size = new System.Drawing.Size(190, 50);
            this.buttonLoci.TabIndex = 1;
            this.buttonLoci.Text = "Sistemul Loci";
            this.buttonLoci.UseVisualStyleBackColor = true;
            this.buttonLoci.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMajor
            // 
            this.buttonMajor.Location = new System.Drawing.Point(73, 322);
            this.buttonMajor.Name = "buttonMajor";
            this.buttonMajor.Size = new System.Drawing.Size(190, 50);
            this.buttonMajor.TabIndex = 2;
            this.buttonMajor.Text = "Sistemul Major";
            this.buttonMajor.UseVisualStyleBackColor = true;
            this.buttonMajor.Click += new System.EventHandler(this.button3_Click);
            // 
            // learnPeg
            // 
            this.learnPeg.Location = new System.Drawing.Point(319, 90);
            this.learnPeg.Name = "learnPeg";
            this.learnPeg.Size = new System.Drawing.Size(75, 23);
            this.learnPeg.TabIndex = 3;
            this.learnPeg.Text = "Invata";
            this.learnPeg.UseVisualStyleBackColor = true;
            this.learnPeg.Visible = false;
            this.learnPeg.Click += new System.EventHandler(this.learnPeg_Click);
            // 
            // practicePeg
            // 
            this.practicePeg.Location = new System.Drawing.Point(318, 144);
            this.practicePeg.Name = "practicePeg";
            this.practicePeg.Size = new System.Drawing.Size(75, 23);
            this.practicePeg.TabIndex = 4;
            this.practicePeg.Text = "Exerseaza";
            this.practicePeg.UseVisualStyleBackColor = true;
            this.practicePeg.Visible = false;
            this.practicePeg.Click += new System.EventHandler(this.testPeg_Click);
            // 
            // homeInfo
            // 
            this.homeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeInfo.Location = new System.Drawing.Point(475, 20);
            this.homeInfo.Name = "homeInfo";
            this.homeInfo.Size = new System.Drawing.Size(397, 290);
            this.homeInfo.TabIndex = 5;
            this.homeInfo.Text = "homeInfo1";
            // 
            // homeInfo2
            // 
            this.homeInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeInfo2.Location = new System.Drawing.Point(476, 334);
            this.homeInfo2.Name = "homeInfo2";
            this.homeInfo2.Size = new System.Drawing.Size(396, 56);
            this.homeInfo2.TabIndex = 6;
            this.homeInfo2.Text = "homeInfo2";
            // 
            // practiceLoci
            // 
            this.practiceLoci.Location = new System.Drawing.Point(317, 244);
            this.practiceLoci.Name = "practiceLoci";
            this.practiceLoci.Size = new System.Drawing.Size(75, 23);
            this.practiceLoci.TabIndex = 8;
            this.practiceLoci.Text = "Exerseaza";
            this.practiceLoci.UseVisualStyleBackColor = true;
            this.practiceLoci.Visible = false;
            this.practiceLoci.Click += new System.EventHandler(this.practiceLoci_Click);
            // 
            // learnLoci
            // 
            this.learnLoci.Location = new System.Drawing.Point(318, 190);
            this.learnLoci.Name = "learnLoci";
            this.learnLoci.Size = new System.Drawing.Size(75, 23);
            this.learnLoci.TabIndex = 7;
            this.learnLoci.Text = "Invata";
            this.learnLoci.UseVisualStyleBackColor = true;
            this.learnLoci.Visible = false;
            this.learnLoci.Click += new System.EventHandler(this.learnLoci_Click);
            // 
            // practiceMajor
            // 
            this.practiceMajor.Location = new System.Drawing.Point(316, 366);
            this.practiceMajor.Name = "practiceMajor";
            this.practiceMajor.Size = new System.Drawing.Size(75, 23);
            this.practiceMajor.TabIndex = 10;
            this.practiceMajor.Text = "Exerseaza";
            this.practiceMajor.UseVisualStyleBackColor = true;
            this.practiceMajor.Visible = false;
            // 
            // learnMajor
            // 
            this.learnMajor.Location = new System.Drawing.Point(317, 312);
            this.learnMajor.Name = "learnMajor";
            this.learnMajor.Size = new System.Drawing.Size(75, 23);
            this.learnMajor.TabIndex = 9;
            this.learnMajor.Text = "Invata";
            this.learnMajor.UseVisualStyleBackColor = true;
            this.learnMajor.Visible = false;
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.practiceMajor);
            this.Controls.Add(this.learnMajor);
            this.Controls.Add(this.practiceLoci);
            this.Controls.Add(this.learnLoci);
            this.Controls.Add(this.homeInfo2);
            this.Controls.Add(this.homeInfo);
            this.Controls.Add(this.practicePeg);
            this.Controls.Add(this.learnPeg);
            this.Controls.Add(this.buttonMajor);
            this.Controls.Add(this.buttonLoci);
            this.Controls.Add(this.buttonPeg);
            this.Name = "MeniuPrincipal";
            this.Text = "MeniuPrincipal";
            this.Load += new System.EventHandler(this.MeniuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPeg;
        private System.Windows.Forms.Button buttonLoci;
        private System.Windows.Forms.Button buttonMajor;
        private System.Windows.Forms.Button learnPeg;
        private System.Windows.Forms.Button practicePeg;
        private System.Windows.Forms.Label homeInfo;
        private System.Windows.Forms.Label homeInfo2;
        private System.Windows.Forms.Button practiceLoci;
        private System.Windows.Forms.Button learnLoci;
        private System.Windows.Forms.Button practiceMajor;
        private System.Windows.Forms.Button learnMajor;

    }
}

