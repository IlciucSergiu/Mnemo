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
    public partial class MeniuPrincipal : Form
    {
        public MeniuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideButtons();

            learnPeg.Visible = true;
            practicePeg.Visible =  true;
        }

        private void learnPeg_Click(object sender, EventArgs e)
        {
            SistemulPeg learnPegForm = new SistemulPeg();
            this.Hide();
            learnPegForm.StartPosition = FormStartPosition.Manual;
            learnPegForm.Location = new Point(this.Location.X , this.Location.Y);
            
            if (learnPegForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }


        }

        private void testPeg_Click(object sender, EventArgs e)
        {
            TestPeg testPegForm = new TestPeg();
            this.Hide();
            testPegForm.StartPosition = FormStartPosition.Manual;
            testPegForm.Location = new Point(this.Location.X, this.Location.Y);
            
            if (testPegForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }

        }

        private void MeniuPrincipal_Load(object sender, EventArgs e)
        {
            homeInfo.Text = Texte1.home_info;
            homeInfo2.Text = Texte1.home_info_2;  
        }

        void HideButtons()
        {
            practicePeg.Visible = false;
            practiceLoci.Visible = false;
            practiceMajor.Visible = false;
            learnPeg.Visible = false;
            learnLoci.Visible = false;
            learnMajor.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideButtons();

            learnLoci.Visible = true;
            practiceLoci.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideButtons();

            learnMajor.Visible = true;
            practiceMajor.Visible = true;
           
        }

        private void learnLoci_Click(object sender, EventArgs e)
        {
            SistemulLoci sistemulLoci = new SistemulLoci();
            this.Hide();
            sistemulLoci.StartPosition = FormStartPosition.Manual;
            sistemulLoci.Location = new Point(this.Location.X, this.Location.Y);

            if (sistemulLoci.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void practiceLoci_Click(object sender, EventArgs e)
        {
            TestLoci testLociForm = new TestLoci();

            this.Hide();
            testLociForm.StartPosition = FormStartPosition.Manual;
            testLociForm.Location = new Point(this.Location.X, this.Location.Y);

            if (testLociForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
