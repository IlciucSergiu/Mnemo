using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;




namespace MemoTricks
{
    class RandomWords
    {
        string[] words = new string[101];
        int pos = 0;
        string wordsList;
       
        public void SetWords(string sursa)
        {
            // introducem cuvintele din lista intr-un vector

            //StreamReader sReader = new StreamReader(Application.StartupPath + "\\Cuvinte.txt");
            //wordsList = sReader.ReadToEnd();
            switch(sursa)
            {
                case "peg" :
                    {

                        wordsList = Texte1.text_words_TestPeg;
                        break;
                    }

                case "loci":
                    {

                        wordsList = Texte1.text_words_TestLoci;
                        break;
                    }
             }

            foreach (string word in wordsList.Split('\n'))
            {
                words[pos] = word;
                pos++;
            }
        }

        public string GetWords()
        {

            
            // System.Windows.Forms.MessageBox.Show(pos.ToString());
            Random _rand = new Random();

            int j = _rand.Next(0, pos - 1);
            if (words[j] != "")
            {
                string finalWord = words[j];
                words[j] = "";
                return finalWord;
            }
            else
            {
                while (words[j] == "")
                {
                     
                     j = _rand.Next(0, pos - 1);
                }
                string finalWord = words[j];
                words[j] = "";
                return finalWord;
                
            }


        }
    }
}
