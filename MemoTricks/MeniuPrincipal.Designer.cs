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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.learnPeg = new System.Windows.Forms.Button();
            this.testPeg = new System.Windows.Forms.Button();
            this.homeInfo = new System.Windows.Forms.Label();
            this.homeInfo2 = new System.Windows.Forms.Label();
            this.testLoci = new System.Windows.Forms.Button();
            this.learnLoci = new System.Windows.Forms.Button();
            this.testMajor = new System.Windows.Forms.Button();
            this.learnMajor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sistemul Peg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sistemul \"loci\"";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sistemul major";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // learnPeg
            // 
            this.learnPeg.Location = new System.Drawing.Point(363, 53);
            this.learnPeg.Name = "learnPeg";
            this.learnPeg.Size = new System.Drawing.Size(75, 23);
            this.learnPeg.TabIndex = 3;
            this.learnPeg.Text = "Invata";
            this.learnPeg.UseVisualStyleBackColor = true;
            this.learnPeg.Visible = false;
            this.learnPeg.Click += new System.EventHandler(this.learnPeg_Click);
            // 
            // testPeg
            // 
            this.testPeg.Location = new System.Drawing.Point(362, 107);
            this.testPeg.Name = "testPeg";
            this.testPeg.Size = new System.Drawing.Size(75, 23);
            this.testPeg.TabIndex = 4;
            this.testPeg.Text = "Testeaza";
            this.testPeg.UseVisualStyleBackColor = true;
            this.testPeg.Visible = false;
            this.testPeg.Click += new System.EventHandler(this.testPeg_Click);
            // 
            // homeInfo
            // 
            this.homeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeInfo.Location = new System.Drawing.Point(475, 20);
            this.homeInfo.Name = "homeInfo";
            this.homeInfo.Size = new System.Drawing.Size(397, 290);
            this.homeInfo.TabIndex = 5;
            this.homeInfo.Text = "infoLabel";
            // 
            // homeInfo2
            // 
            this.homeInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeInfo2.Location = new System.Drawing.Point(476, 334);
            this.homeInfo2.Name = "homeInfo2";
            this.homeInfo2.Size = new System.Drawing.Size(396, 56);
            this.homeInfo2.TabIndex = 6;
            this.homeInfo2.Text = "label1";
            // 
            // testLoci
            // 
            this.testLoci.Location = new System.Drawing.Point(361, 207);
            this.testLoci.Name = "testLoci";
            this.testLoci.Size = new System.Drawing.Size(75, 23);
            this.testLoci.TabIndex = 8;
            this.testLoci.Text = "Testeaza";
            this.testLoci.UseVisualStyleBackColor = true;
            this.testLoci.Visible = false;
            // 
            // learnLoci
            // 
            this.learnLoci.Location = new System.Drawing.Point(362, 153);
            this.learnLoci.Name = "learnLoci";
            this.learnLoci.Size = new System.Drawing.Size(75, 23);
            this.learnLoci.TabIndex = 7;
            this.learnLoci.Text = "Invata";
            this.learnLoci.UseVisualStyleBackColor = true;
            this.learnLoci.Visible = false;
            // 
            // testMajor
            // 
            this.testMajor.Location = new System.Drawing.Point(360, 329);
            this.testMajor.Name = "testMajor";
            this.testMajor.Size = new System.Drawing.Size(75, 23);
            this.testMajor.TabIndex = 10;
            this.testMajor.Text = "Testeaza";
            this.testMajor.UseVisualStyleBackColor = true;
            this.testMajor.Visible = false;
            // 
            // learnMajor
            // 
            this.learnMajor.Location = new System.Drawing.Point(361, 275);
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
            this.Controls.Add(this.testMajor);
            this.Controls.Add(this.learnMajor);
            this.Controls.Add(this.testLoci);
            this.Controls.Add(this.learnLoci);
            this.Controls.Add(this.homeInfo2);
            this.Controls.Add(this.homeInfo);
            this.Controls.Add(this.testPeg);
            this.Controls.Add(this.learnPeg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MeniuPrincipal";
            this.Text = "MeniuPrincipal";
            this.Load += new System.EventHandler(this.MeniuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button learnPeg;
        private System.Windows.Forms.Button testPeg;
        private System.Windows.Forms.Label homeInfo;
        private System.Windows.Forms.Label homeInfo2;
        private System.Windows.Forms.Button testLoci;
        private System.Windows.Forms.Button learnLoci;
        private System.Windows.Forms.Button testMajor;
        private System.Windows.Forms.Button learnMajor;

    }
}

