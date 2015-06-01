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
        int pos, pos2 = 1;
        

        private void TestLoci_Load(object sender, EventArgs e)
        {
            
            ImageClass imgcls = new ImageClass();

            pictureBoxHelpImage.BackgroundImage =imgcls.CropImage(Imagini2.loci_house, 0, 0, 500, 500);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerTestLoci.Start();
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

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            labelWords2.Text = " 1 ";
            panelVerify.Visible = true;
            timerTestLoci.Stop();
        }

        // Contorul care retine numarul raspunsurilor corecte
        int rightAnswers = 0;
        string ver1, ver2;

        private void buttonFinish_Click(object sender, EventArgs e)
        {
           
            

            wordsCheck[pos2] = textBoxWords.Text.Trim();
            for (int i = 1; i <= 10; i++)
            {
                if (wordsCheck[i] == words[i].Trim())
                    rightAnswers++;
                    
            }

            
            for (int i = 1; i < 15; i++)
            {
                ver1 += i + ". " + words[i].Trim() + " -- " + wordsCheck[i] + "\n";
            }
            ver1 += "\n";

            for (int i = 15; i < 21; i++)
            {
                ver2 += i + ". " + words[i].Trim() + " -- " + wordsCheck[i] + "\n";
            }

            string time = "00:23";

            SubmitLoci submitLoci = new SubmitLoci(rightAnswers, time, ver1, ver2);

            submitLoci.StartPosition = FormStartPosition.Manual;
            submitLoci.Location = new Point(this.Location.X + 150, this.Location.Y);

            if (submitLoci.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                this.Close();
           // MessageBox.Show(ver);
        }

        private void buttonPrevious2_Click(object sender, EventArgs e)
        {
            if (pos2 > 1)
            {
                wordsCheck[pos2] = textBoxWords.Text.Trim();
                pos2--;
                labelWords2.Text = pos2.ToString();

                textBoxWords.Text = wordsCheck[pos2];
            }
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            if (pos2 < 20)
            {
                wordsCheck[pos2] = textBoxWords.Text.Trim();
                pos2++;
                labelWords2.Text = pos2.ToString();
                textBoxWords.Text = wordsCheck[pos2];
            }
        }

        // variabilele pentru timp
        int sec, min;

        private void timerTestLoci_Tick(object sender, EventArgs e)
        {
          
           sec++;
           if (sec == 60)
           {
               sec = 0;
               min++;
           }
          
           ShowTime(sec , min);
        
        }

        void ShowTime(int sec1, int min)
        {
            if (sec < 10 && min == 0)
                labelTime.Text = "00:00:0" + sec1;
            if (sec >= 10 && min == 0)
                labelTime.Text = "00:00:" + sec1;
            if (sec < 10 && min < 10 && min > 0)
                labelTime.Text = "00:0" + min + ":0" + sec1;
            if (sec < 10 && min > 10)
                labelTime.Text = "00:" + min + ":0" + sec1;
            if (sec >= 10 && min > 10)
                labelTime.Text = "00:" + min + ":" + sec1;
            if (sec >= 10 && min < 10 && min > 0)
                labelTime.Text = "00:0" + min + ":" + sec1;
        }

        private void checkBoxImages_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxImages.Checked == true)
                pictureBoxHelpImage.Visible = true;
            else
                pictureBoxHelpImage.Visible = false;
        }

        //Image CropImage(int x, int y, int width, int height)
        //{
        //    Rectangle cropRect = new Rectangle(x, y, width, height);
        //    Bitmap sourceImage = new Bitmap(Imagini2.loci_house);
        //    Bitmap returnImage = sourceImage.Clone(cropRect, sourceImage.PixelFormat);

        //    return returnImage;
        //}

    }
}
