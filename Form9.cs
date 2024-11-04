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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        int food = 0, food1 = 8, hp = 3, hd = 0;

        private void MouseEnter(object sender, EventArgs e)
        {
            if (hp == hd)
            {
                MessageBox.Show("У вас закончились жизни");

                this.Visible = false;
                Form a = new Form42();
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
                point = pictureBox57.Location;
                Cursor.Position = PointToScreen(point);
            }

        }
    

        private void MouseEnterOB(object sender, EventArgs e)
        {
            this.Visible = false;
            Form a = new Form62();
            a.ShowDialog();
        }
        
        private void start_game()
        {
            Point point;
            point = pictureBox57.Location;
            Cursor.Position = PointToScreen(point);
        }


        private void Form9_Shown(object sender, EventArgs e)
        {
            start_game();
        }
       
        private void Fd1(object sender, EventArgs e)
        {
            pictureBox60.Visible = false;
            food++;
        }

        

        private void Fd2(object sender, EventArgs e)
        {
            pictureBox64.Visible = false;
            food++;
        }

        

        private void Fd3(object sender, EventArgs e)
        {
            pictureBox61.Visible = false;
            food++;
        }

        

        private void Fd4(object sender, EventArgs e)
        {
            pictureBox62.Visible = false;
            food++;
        }

        
        private void Fd5(object sender, EventArgs e)
        {
            pictureBox63.Visible = false;
            food++;
        }

        

        private void Fd6(object sender, EventArgs e)
        {
            pictureBox65.Visible = false;
            food++;
        }

        

        private void Fd7(object sender, EventArgs e)
        {
            pictureBox66.Visible = false;
            food++;
        }

        private void Fd8(object sender, EventArgs e)
        {
            pictureBox67.Visible = false;
            food++;
        }

        
        private void Screamer(object sender, EventArgs e)
        {
            this.Visible = false;
            Form a = new Form10();
            a.ShowDialog();
        }

        
    }
}
