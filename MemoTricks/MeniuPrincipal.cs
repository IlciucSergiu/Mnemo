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
            learnPeg.Visible = true;
            testPeg.Visible =  true;
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
    }
}
