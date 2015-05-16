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
    public partial class TestPeg : Form
    {
        public TestPeg()
        {
            InitializeComponent();
        }
         string[] words = new string[11];
         int pos = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            RandomWords cv = new RandomWords();
            cv.SetWords();
            for (int i = 1; i <= 10; i++)
            {
                words[i] = cv.GetWords();
                //MessageBox.Show(cv.GetWords());
            }
            pos = 1;
            label1.Text = pos + ": " + words[1];
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (pos < 10)
            {
                pos++;
                label1.Text = pos +": "+ words[pos];
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (pos > 1)
            {
                pos--;
                label1.Text = pos + ": " + words[pos];
            }
        }
    }
}
