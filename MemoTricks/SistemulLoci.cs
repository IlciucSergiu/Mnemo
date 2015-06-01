using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoTricks
{
    public partial class SistemulLoci : Form
    {
        public SistemulLoci()
        {
            InitializeComponent();
        }
        int slide = 1;
        private void SistemulLoci_Load(object sender, EventArgs e)
        {
            labelText1.Text = Texte1.text2_1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (slide < 4)
            {
                slide++;
                ChangeSlide(slide);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (slide > 1 )
            {
                slide--;
                ChangeSlide(slide);
            }
        }
        void ChangeSlide(int slide)
        {
            switch (slide)
            {
                case 1:
                    {
                        pictureBoxLearn1.BackgroundImage = null;
                        labelText1.Text = Texte1.text2_1;
                        break;
                    }

                case 2:
                    {
                        pictureBoxLearn1.BackgroundImage = Imagini2.learnLoci_2;
                        labelText1.Text = Texte1.text2_2;
                        break;
                    }

                case 3:
                    {
                        pictureBoxLearn1.BackgroundImage = Imagini2.learnLoci_3;
                        labelText1.Text = Texte1.text2_3;
                        break;
                    }

                case 4:
                    {
                        pictureBoxLearn1.BackgroundImage = null;
                        labelText1.Text = Texte1.text2_4;
                        break;
                    }

                    

            }
            if (slide == 4)
            {
                buttonPractice.Visible = true;
            }
            else { buttonPractice.Visible = false; }
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            TestLoci testLociForm = new TestLoci();

            this.Hide();
            testLociForm.StartPosition = FormStartPosition.Manual;
            testLociForm.Location = new Point(this.Location.X, this.Location.Y);

            if (testLociForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

       


        
    }
}
