using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace MemoTricks
{
    public partial class LociHouse : Form
    {
        public LociHouse()
        {
            InitializeComponent();
        }

        bool mousePress;
        int initialX, initialY ;
        private void LociHouse_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePress = true;
            initialX = e.X;
            initialY = e.Y;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePress = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousePress == true)
            {
                int diffX , diffY;
                diffX = e.X - initialX;
                diffY = e.Y - initialY;
                Point position = new Point(pictureBoxHouse.Location.X, pictureBoxHouse.Location.Y);
               // if(position.X + diffX < 0 && position.Y + diffY <= 0)
               // pictureBoxHouse.Location = new Point(position.X + diffX , position.Y + diffY);
                if (position.X + diffX < 0
                    &&
                    position.X + diffX + pictureBoxHouse.Width > this.Width
                    )
                    pictureBoxHouse.Location = new Point(position.X + diffX, pictureBoxHouse.Location.Y);

                if (position.Y + diffY < 0
                    &&
                    position.Y + diffY + pictureBoxHouse.Height > this.Height
                    )
                    pictureBoxHouse.Location = new Point(pictureBoxHouse.Location.X, position.Y + diffY);

               // if (position.X + diffX + pictureBoxHouse.Width > this.Width)
                 //   pictureBoxHouse.Location = new Point(position.X + diffX, pictureBoxHouse.Location.Y);

                //if (position.Y + diffY + pictureBoxHouse.Width < 0)
                 //   pictureBoxHouse.Location = new Point(pictureBoxHouse.Location.X, position.Y + diffY);
            }
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            if(pictureBoxHouse.Width < 2000)
            pictureBoxHouse.Size = new Size(pictureBoxHouse.Width + 20, pictureBoxHouse.Height + 20);
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            if (pictureBoxHouse.Width > 1000 && pictureBoxHouse.Width > this.Width)
                pictureBoxHouse.Size = new Size(pictureBoxHouse.Width - 20, pictureBoxHouse.Height - 20);
        }
    }
}
