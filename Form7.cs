using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int food = 0, food1 = 6, hp=3, hd=0;

        private void start_game()
        {
            Point point;
            point = pictureBox47.Location;
            Cursor.Position = PointToScreen(point);
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void MouseEnterOb(object sender, EventArgs e)
        {
            this.Visible = false;
            Form a = new Form61();
            a.ShowDialog();
        }

        
        private void Fd2(object sender, EventArgs e)
        {
            pictureBox98.Visible = false;
            food++;
        }

        
        private void Fd3(object sender, EventArgs e)
        {
            pictureBox99.Visible = false;
            food++;
        }

        
        private void Fd4(object sender, EventArgs e)
        {
            pictureBox97.Visible = false;
            food++;
        }

        private void Fd5(object sender, EventArgs e)
        {
            pictureBox101.Visible = false;
            food++;
        }

        private void Finish(object sender, EventArgs e)
        {
            if (food >= food1)
            {
                Win();
            }
            if (food <= food1)
            {
                lose();
            }
        }
        private void Win()
        {
            this.Visible = false;
            Form a = new Form8();
            a.ShowDialog();
        }
        private void lose()
        {
            MessageBox.Show("Вы собрали не достаточное колличество еды");
            this.Visible = false;
            Form a = new Form41();
            a.ShowDialog();
        }

        private void Fd6(object sender, EventArgs e)
        {
            pictureBox100.Visible = false;
            food++;
        }

        private void MS(object sender, EventArgs e)
        {
            
            if (hp == hd)
            {
                MessageBox.Show("У вас закончились жизни");

                this.Visible = false;
                Form a = new Form41();
                a.ShowDialog();
            }
            HP();

        }
        private void HP()
        {
            if (hp > hd)
            {
                hp = hp - 1;
                Point point;
                point = pictureBox47.Location;
                Cursor.Position = PointToScreen(point);
            }

        }




        private void Fd1(object sender, EventArgs e)
        {
            pictureBox96.Visible = false;
            food++;
        }
    }
}
