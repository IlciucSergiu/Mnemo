﻿using System;
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
    public partial class TestPeg : Form
    {
        public TestPeg()
        {
            InitializeComponent();
        }
         string[] words = new string[11];
          string[] wordsCheck = new string[11];
         int pos = 0, sec1, min;
         string time;
       // Butonul start
        private void start_Click(object sender, EventArgs e)
        {
            labelTestPegInfo.Visible = false;
            timeLabel.Text = "00:00:00";
            timer1.Start();
            sec1 = 0; min = 0;
            ButtonsVisibleTrue();
            start.Text = "Reincepe";
            info1.Text = Texte1.text_info_1;
            info2.Text = Texte1.text_info_2;

            // Primirea cuvintelor aleatorii
            RandomWords cv = new RandomWords();
            
            // Setarea cuvintelor in vector
               cv.SetWords("peg");
            for (int i = 1; i <= 10; i++)
            {
                // Primirea cuvintelor din vector in ordine aleatorie
                words[i] = cv.GetWords();
                
            }
            pos = 1;
            label1.Text = pos + ": " + words[1];
            ImageClass imgList = new ImageClass();
            pictureBoxLista.BackgroundImage = imgList.ReturnImage(pos);
            finish.Visible = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (pos < 10)
            {
                pos++;
                label1.Text = pos +": "+ words[pos];
                ImageClass imgList = new ImageClass();
                pictureBoxLista.BackgroundImage = imgList.ReturnImage(pos);
            }
            if (pos == 10)
                finish.Visible = true;
            
            
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (pos > 1)
            {
                pos--;
                label1.Text = pos + ": " + words[pos];
                ImageClass imgList = new ImageClass();
                pictureBoxLista.BackgroundImage = imgList.ReturnImage(pos);
            }
        }
        // dupa apasarea butonului Finalizeaza se ascund butoanele
        void ButtonsVisibleFalse()
        {
            previous.Visible = false;
            next.Visible = false;
            label1.Visible = false;
            checkImages.Visible = false;
            start.Visible = false;
        }
        // la apasarea butonului Incepe testul se vor afisa butoanele
        void ButtonsVisibleTrue()
        {
            previous.Visible = true;
            next.Visible = true;
            label1.Visible = true;
            checkImages.Visible = true;
            
        }

        private void checkImages_CheckedChanged(object sender, EventArgs e)
        {
            if (checkImages.Checked == true)
                pictureBoxLista.Visible = true;
            else
                pictureBoxLista.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           sec1++;
           if (sec1 == 60)
           {
               sec1 = 0;
               min++;
           }
          
           ShowTime(sec1 , min);
        }

        void ShowTime(int sec1, int min)
        {
            if(sec1 < 10 && min == 0)
            timeLabel.Text = "00:00:0" + sec1;
            if (sec1 >= 10 && min == 0)
                timeLabel.Text = "00:00:" + sec1;
            if (sec1 < 10 && min < 10 && min > 0)
                timeLabel.Text = "00:0"+min+":0" + sec1;
            if (sec1 < 10 && min > 10)
                timeLabel.Text = "00:"+min+":0" + sec1;
            if (sec1 >= 10 && min > 10 )
                timeLabel.Text = "00:"+min+":" + sec1;
            if (sec1 >= 10 && min < 10 && min > 0)
                timeLabel.Text = "00:0" + min + ":" + sec1;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            panel1.Visible = true;
            timeTest.Text = timeLabel.Text;
            pictureBoxLista.BringToFront();
            pos = 1;
            ImageClass imgList = new ImageClass();
            pictureBoxLista.BackgroundImage = imgList.ReturnImage(pos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int pos2 = 1;

        private void previous2_Click(object sender, EventArgs e)
        {
            if (pos > 1)
            {
                pos--;
                label1.Text = pos + ": " + words[pos];
                ImageClass imgList = new ImageClass();
                pictureBoxLista.BackgroundImage = imgList.ReturnImage(pos);
            }

            if (pos2 > 1)
            {
                wordsCheck[pos2] = testTextBox.Text.Trim() ;
                pos2--;
                labelPos2.Text = pos2.ToString();
                
                testTextBox.Text = wordsCheck[pos2];
            }
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if (pos < 10)
            {
                pos++;
                label1.Text = pos + ": " + words[pos];
                ImageClass imgList = new ImageClass();
                pictureBoxLista.BackgroundImage = imgList.ReturnImage(pos);
            }

            if (pos2 < 10 )
            {
                wordsCheck[pos2] = testTextBox.Text.Trim() ;
                pos2++;
                labelPos2.Text = pos2.ToString();
                testTextBox.Text = wordsCheck[pos2];
            }
        }

        // Contorul care retine numarul raspunsurilor corecte
        int rightAnswers = 0;
        string ver;
        private void verifyButton_Click(object sender, EventArgs e)
        {
            wordsCheck[pos2] = testTextBox.Text.Trim();
            for (int i = 1; i <= 10; i++)
            {
                if (wordsCheck[i] == words[i].Trim())
                    rightAnswers++;
                    
            }

            
            for (int i = 1; i < 11; i++)
            {
                ver += i + ". " + words[i].Trim() + " -- " + wordsCheck[i] + "\n";
            }
            ver += "\n";
            #region Time

            

            if (sec1 < 10 && min == 0)
                time = "00:00:0" + sec1;
            if (sec1 >= 10 && min == 0)
                time = "00:00:" + sec1;
            if (sec1 < 10 && min < 10 && min > 0)
                time = "00:0" + min + ":0" + sec1;
            if (sec1 < 10 && min > 10)
                time = "00:" + min + ":0" + sec1;
            if (sec1 >= 10 && min > 10)
                time = "00:" + min + ":" + sec1;
            if (sec1 >= 10 && min < 10 && min > 0)
                time = "00:0" + min + ":" + sec1;
            #endregion
            // MessageBox.Show("Ati raspuns corect la "+ rightAnswers +" din 10 intr-un timp de " + min + ":" + sec1 + "\n"+ ver , "Rezultat ");
            SubmitPeg submitPeg = new SubmitPeg(rightAnswers, time , ver);

            submitPeg.StartPosition = FormStartPosition.Manual;
            submitPeg.Location = new Point(this.Location.X + 150, this.Location.Y);

            if (submitPeg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                this.Close();

        }

        private void TestPeg_Load(object sender, EventArgs e)
        {
            labelTestPegInfo.Text = Texte1.text_testPegInfo;
        }

        
    }
}
