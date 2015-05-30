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
    public partial class TestLoci : Form
    {
        public TestLoci()
        {
            InitializeComponent();
        }
        string[] words = new string[25];
        string[] wordsCheck = new string[25];
        int pos;

        private void TestLoci_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
               SetVisible();
            RandomWords randomWords = new RandomWords();

            randomWords.SetWords("loci");
            for (int i = 1; i <= 20; i++)
            {
                words[i] = randomWords.GetWords();
                //MessageBox.Show(cv.GetWords());
            }

            buttonStart.Text = "Reincepe";
            pos = 1;
            labelWords.Text = pos + " : " +  words[pos];

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < 20)
            {
                pos++;
                labelWords.Text = pos + " : " + words[pos];
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 1)
            {
                pos--;
                labelWords.Text = pos + " : " + words[pos];
            }
        }

        void SetVisible()
        {
            buttonPrevious.Visible = true;
            buttonNext.Visible = true;
            buttonVerify.Visible = true;
            labelWords.Visible = true;
        }

        private void buttonShowHouse_Click(object sender, EventArgs e)
        {
            LociHouse lociHouseForm = new LociHouse();

            lociHouseForm.Show();
        }

    }
}
