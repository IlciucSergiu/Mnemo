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
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelWords = new System.Windows.Forms.Label();
            this.buttonShowHouse = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
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
            // TestLoci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonShowHouse);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Name = "TestLoci";
            this.Text = "TestLoci";
            this.Load += new System.EventHandler(this.TestLoci_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Button buttonShowHouse;
        private System.Windows.Forms.Button buttonStart;
    }
}