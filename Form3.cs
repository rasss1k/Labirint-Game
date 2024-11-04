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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        int food = 0,food1 = 7, hp=3, hd=0;
        

        private new void MouseEnter(object sender, EventArgs e)
        {

            if (hp == hd)
            {
                MessageBox.Show("У вас закончились жизни");

                this.Visible = false;
                Form a = new Form4();
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

        private void MouseE(object sender, EventArgs e)
        {
            if (food >= food1)
            {
                Win();
            }
            if (food<=food1) 
            {
                lose();
            }
        }
        private void Win()
        {
            this.Visible = false;
            Form a = new Form5();
            a.ShowDialog();
        }
        private void lose()
        {
            MessageBox.Show("Вы собрали не достаточное колличество еды");
            this.Visible = false;
            Form a = new Form4();
            a.ShowDialog();
        }



        private void Fd1(object sender, EventArgs e)
        {
            pictureBox65.Visible = false;
            food++;
        }

       
        private void Fd2(object sender, EventArgs e)
        {
            pictureBox66.Visible = false;
            food++;
        }

        private void Fd3(object sender, EventArgs e)
        {
            pictureBox70.Visible = false;
            food++;
        }

        
        private void Fd4(object sender, EventArgs e)
        {
            pictureBox71.Visible = false;
            food++;
        }

        
        private void Fd5(object sender, EventArgs e)
        {
            pictureBox69.Visible = false;
            food++;
        }

       
        private void Fd6(object sender, EventArgs e)
        {
            pictureBox67.Visible = false;
            food++;
        }

        

        private void Fd7(object sender, EventArgs e)
        {
            pictureBox68.Visible = false;
            food++;
        }

       
      
        private void MouseEN(object sender, EventArgs e)
        {
            
                this.Visible = false;
                Form f = new Form6();
                f.ShowDialog();     

        }
        private void start_game()
        {
            Point point;
            point = pictureBox47.Location;
            Cursor.Position = PointToScreen(point);
        }

        
        private void Form3_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        
    }
}
