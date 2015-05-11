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
            if(slide<4)
            {
                slide++;
            switch (slide)
            {
                case 1:
                    {
                        LeftText.Text = Texte1.text1_1;
                        LeftText.Font = new Font("Arial", 16);
                        pictureBox1.Visible = false;
                        break;
                    }
                case 2:
                    {
                        LeftText.Text = Texte1.text1_2;

                        pictureBox1.Visible = true;
                        LeftText.Font = new Font("Arial", 14);
                        break;
                    }
                case 3:
                    {
                        LeftText.Text = Texte1.text1_3;
                        LeftText.Font = new Font("Arial", 16);
                        pictureBox1.Visible = false;
                        break;
                    }
                case 4: { LeftText.Text = Texte1.text1_4; break; }
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (slide > 1)
            {
                slide--;
                switch (slide)
                {
                    case 1: { LeftText.Text = Texte1.text1_1;
                    LeftText.Font = new Font("Arial", 16);
                        pictureBox1.Visible = false; 
                        break; }
                    case 2: { LeftText.Text = Texte1.text1_2;
                    
                    pictureBox1.Visible = true;
                    LeftText.Font = new Font("Arial", 14);
                    break;
                    }
                    case 3: { LeftText.Text = Texte1.text1_3;
                    LeftText.Font = new Font("Arial", 16);
                    pictureBox1.Visible = false; 
                        break;
                    }
                    case 4: { LeftText.Text = Texte1.text1_4; break; }
                }
            }
        }
    }
}
