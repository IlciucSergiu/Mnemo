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
    public partial class SistemulPeg : Form
    {
        public SistemulPeg()
        {
            InitializeComponent();
        }
        int slide = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            PictureSlideForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureSlideBackwards();
        }

        void PictureSlideForward()
        {
            if (slide < 9)
            {
                slide++;
                switch (slide)
                {
                    case 1:
                        {
                            LeftText.Text = Texte1.text1_1;
                            LeftText.Font = new Font("Arial", 16);
                            
                            break;
                        }
                    case 2:
                        {
                            LeftText.Text = Texte1.text1_2;

                           
                            LeftText.Font = new Font("Arial", 14);
                            break;
                        }
                    case 3:
                        {
                            LeftText.Text = Texte1.text1_3;
                            LeftText.Font = new Font("Arial", 16);
                            
                            break;
                        }
                    case 4: { LeftText.Text = Texte1.text1_4; break; }
                       
                       
                }
                if (slide == 2)
                    pictureBox1.Visible = true;
                else
                    pictureBox1.Visible = false;

                if (slide > 4)
                    pictureBoxLista.Visible = true;
                else
                    pictureBoxLista.Visible = false;
            }

            
                switch (slide)
                {
                    case 5:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._1_imagine;
                            break;
                        }
                    case 6:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._2_img;
                            break;
                        }
                    case 7:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._3_img;
                            break;
                        }
                    case 8:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._4_img;
                            break;
                        }
                    case 9:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._5_img;
                            break;
                        }
                
            }
        }
        void PictureSlideBackwards()
        {

            if (slide > 1)
            {
                slide--;
                switch (slide)
                {
                    case 1:
                        {
                            LeftText.Text = Texte1.text1_1;
                            LeftText.Font = new Font("Arial", 16);
                            
                            break;
                        }
                    case 2:
                        {
                            LeftText.Text = Texte1.text1_2;

                            
                            LeftText.Font = new Font("Arial", 14);
                            break;
                        }
                    case 3:
                        {
                            LeftText.Text = Texte1.text1_3;
                            LeftText.Font = new Font("Arial", 16);
                            
                            break;
                        }
                    case 4: { LeftText.Text = Texte1.text1_4; break; }
                }
                if (slide == 2)
                    pictureBox1.Visible = true;
                else 
                    pictureBox1.Visible = false;

                if (slide > 4)
                    pictureBoxLista.Visible = true;
                else
                    pictureBoxLista.Visible = false;
            }
            
                
                switch (slide)
                {
                    case 5:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._1_imagine;
                            break;
                        }
                    case 6:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._2_img;
                            break;
                        }
                    case 7:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._3_img;
                            break;
                        }
                    case 8:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._4_img;
                            break;
                        }
                    case 9:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._5_img;
                            break;
                        }
                
            }

        }
    }
}
