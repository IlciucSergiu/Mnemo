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
    public partial class SubmitPeg : Form
    {
        public SubmitPeg(int rightAnswers, string time, string ver)
        {
            InitializeComponent();
            submitLabel1.Text = "Ati raspuns corect la " + rightAnswers + " din 10 intr-un timp de " + time + " .";
            submitLabel2.Text = ver;
        }

        private void SubmitPeg_Load(object sender, EventArgs e)
        {
            
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            TestPeg testPegForm = new TestPeg();

            this.Hide();
            
            testPegForm.StartPosition = FormStartPosition.Manual;
            testPegForm.Location = new Point(this.Location.X - 150, this.Location.Y);
            testPegForm.ShowDialog();
            this.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
