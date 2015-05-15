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
        int slide = 1, _image = 1;

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
            if (slide < 4)
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
                    case 4: 
                        { 
                    LeftText.Text = Texte1.text1_4;
                    pictureBoxLista.BackgroundImage = Imagini1._1_img;
                    pictureBoxLista.Visible = true; 
                        break;
                        }
                       
                       
                }
                if (slide == 2)
                    pictureBox1.Visible = true;
                else
                    pictureBox1.Visible = false;

                if (slide >= 4)
                    pictureBoxLista.Visible = true;
                else
                    pictureBoxLista.Visible = false;
                
                if (slide == 4)
                {
                    previous.Visible = true;
                    next.Visible = true;

                }
                else 
                {
                    previous.Visible = false;
                    next.Visible = false;
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
                    case 4: { 
                        LeftText.Text = Texte1.text1_4; 
                        pictureBoxLista.BackgroundImage = Imagini1._1_img;
                        pictureBoxLista.Visible = true;
                        break;
                    }
                }
                if (slide == 2)
                    pictureBox1.Visible = true;
                else 
                    pictureBox1.Visible = false;

                if (slide >= 4)
                    pictureBoxLista.Visible = true;
                else
                    pictureBoxLista.Visible = false;
                
                if (slide == 4)
                {
                    previous.Visible = true;
                    next.Visible = true;

                }
                else
                {
                    previous.Visible = false;
                    next.Visible = false;
                }
            }
            
                
             

        }

        private void pictureBoxLista_MouseEnter(object sender, EventArgs e)
        {
           // MessageBox.Show("Test");

            if (MousePosition.X > pictureBoxLista.Width / 2 + 344)
            {
                pictureBoxLista.Image = Imagini1.Imagini_margine2;
            }
            else
                pictureBoxLista.Image = Imagini1.Imagini_margine1;
        }

        private void next_Click(object sender, EventArgs e)
        {

            if (_image < 10)
            {
                _image++;

                switch (_image)
                {
                    case 1:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._1_img;
                            break;
                        }
                    case 2:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._2_img;
                            break;
                        }
                    case 3:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._3_img;
                            break;
                        }
                    case 4:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._4_img;
                            break;
                        }
                    case 5:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._5_img;
                            break;
                        }
                    case 6:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._6_img;
                            break;
                        }
                    case 7:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._7_img;
                            break;
                        }
                    case 8:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._8_img;
                            break;
                        }
                    case 9:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._9_img;
                            break;
                        }
                    case 10:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._10_img;
                            break;
                        }
                }
            }
        }
        private void previous_Click(object sender, EventArgs e)
        {

            if ( _image > 1)
            {
                _image--;

                switch (_image)
                {
                    case 1:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._1_img;
                            break;
                        }
                    case 2:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._2_img;
                            break;
                        }
                    case 3:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._3_img;
                            break;
                        }
                    case 4:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._4_img;
                            break;
                        }
                    case 5:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._5_img;
                            break;
                        }
                    case 6:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._6_img;
                            break;
                        }
                    case 7:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._7_img;
                            break;
                        }
                    case 8:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._8_img;
                            break;
                        }
                    case 9:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._9_img;
                            break;
                        }
                    case 10:
                        {
                            pictureBoxLista.BackgroundImage = Imagini1._10_img;
                            break;
                        }
                }
            }
        }

    
    }
}
