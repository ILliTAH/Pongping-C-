using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingping
{
    public partial class Form2 : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public int point2 = 0;
        public int levels = 0;

        public Form2()
        {
            InitializeComponent();

            timer1.Enabled = true;



            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            rockketsing.Top = playgroud.Top + 50;



            rockketsing.Top = (playgroud.Bottom) - (playgroud.Bottom / 10);

            gameover_label.Visible = false;

            gameover_label.Location = new Point((gameover_label.Parent.ClientSize.Width / 2) - (gameover_label.Width / 2), (gameover_label.Parent.Height / 2));


        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ball.Left += speed_left;
            ball.Top += speed_top;


            rockketsing.Left = Cursor.Position.X - (rockketsing.Width / 2);


            if (ball.Bottom >= rockketsing.Top && ball.Bottom <= rockketsing.Bottom && ball.Left >= rockketsing.Left && ball.Right <= rockketsing.Right)
            {


                point += 1;

                scorenum_label.Text = point.ToString();
                speed_top += 1;
                speed_left += 1;

                speed_top = -speed_top;














            }


            if (ball.Left <= playgroud.Left)
            {
                speed_left = -speed_left;

            }
            if (ball.Right >= playgroud.Right)
            {
                speed_left = -speed_left;


            }
            if (ball.Top <= playgroud.Top)
            {

                
                speed_top = -speed_top;


            }
            if (ball.Bottom >= playgroud.Bottom)
            {
                point += 1;

                gameover_label.Visible = true;

                timer1.Enabled = false;
            }


        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Escape)
            {

                this.Close();


            }


        }
    }
}
