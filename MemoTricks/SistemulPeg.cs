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
        int slide = 1, _image;

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
            if (slide < 5)
            {
                slide++;
                switch (slide)
                {
                    case 1:
                        {
                            LeftText.Text = Texte1.text1_1;
                            pictureBox1.BackgroundImage = Imagini1.Cuier;


                            break;
                        }
                    case 2:
                        {
                            LeftText.Text = Texte1.text1_2;
                          

                           
                            break;
                        }
                    case 3:
                        {
                            LeftText.Text = Texte1.text1_3;
                            pictureBoxLista.BackgroundImage = Imagini1._1_img;
                            pictureBoxLista.Visible = true;

                            break;
                        }
                    case 4:
                        {
                            LeftText.Text = Texte1.text1_4;
                            pictureBox1.BackgroundImage = Imagini1.scrisoare_final;

                            break;
                        }
                    case 5:
                        {
                            LeftText.Text = Texte1.text1_5;
                            
                            break;
                        }


                }
                if (slide == 1 || slide == 4)
                {
                    
                    pictureBox1.Visible = true;
                }
                else
                    pictureBox1.Visible = false;

                if (slide == 5)
                    practiceButton.Visible = true;
                else
                    practiceButton.Visible = false;

                if (slide == 3)
                    pictureBoxLista.Visible = true;
                else
                    pictureBoxLista.Visible = false;

                if (slide == 3)
                {
                    _image = 1;
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
                            pictureBox1.BackgroundImage = Imagini1.Cuier;

                            break;
                        }
                    case 2:
                        {
                            LeftText.Text = Texte1.text1_2;
                            

                           
                            break;
                        }
                    case 3:
                        {
                            LeftText.Text = Texte1.text1_3;
                            pictureBoxLista.BackgroundImage = Imagini1._1_img;
                            pictureBoxLista.Visible = true;

                            break;
                        }
                    case 4:
                        {
                            LeftText.Text = Texte1.text1_4;
                            pictureBox1.BackgroundImage = Imagini1.scrisoare_final;

                            break;
                        }
                    case 5:
                        {
                            LeftText.Text = Texte1.text1_5;
                           
                            break;
                        }


                }
                if (slide == 1 || slide == 4)
                {
                   
                    pictureBox1.Visible = true;
                }
                else
                    pictureBox1.Visible = false;

                

                if (slide == 3)
                    pictureBoxLista.Visible = true;
                else
                    pictureBoxLista.Visible = false;

                if (slide == 3)
                {
                    _image = 1;
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

            NextClick();
        }
        private void previous_Click(object sender, EventArgs e)
        {
            PreviousClick();           
        }
        public void NextClick()
        {
            if (_image < 10)
            {
                _image++;
                ImageList imgList = new ImageList();
                pictureBoxLista.BackgroundImage = imgList.ReturnImage(_image);
                
            }

        }
        public void PreviousClick()
        {
            if (_image > 1)
            {
                _image--;

                ImageList imgList = new ImageList();
                pictureBoxLista.BackgroundImage = imgList.ReturnImage(_image);
            }
        }

        private void SistemulPeg_Load(object sender, EventArgs e)
        {
            SetBorders();
            LeftText.Text = Texte1.text1_1;
            pictureBox1.BackgroundImage = Imagini1.Cuier;
            pictureBox1.Visible = true;
        }


        void SetBorders()
        {
            previous.FlatStyle = FlatStyle.Flat;
            previous.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            next.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            practiceButton.FlatStyle = FlatStyle.Flat;
            practiceButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.FlatAppearance.BorderSize = 0;

            //previous.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void practiceButton_Click(object sender, EventArgs e)
        {
            this.Close();

            TestPeg testPegForm = new TestPeg();
            this.Hide();
            testPegForm.StartPosition = FormStartPosition.Manual;
            testPegForm.Location = new Point(this.Location.X, this.Location.Y);

            if (testPegForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

    }
}