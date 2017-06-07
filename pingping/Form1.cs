using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace pingping
{
    public partial class Form1 : Form
    {

        


        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public int point2 = 0;
        public int levels = 0;
        bool checklvup = true;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;

           

            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            rockket2.Top = playground.Top + 50;
            rockket.Top = playground.Bottom - (playground.Bottom / 10);


            label_suc.Visible = false;
            label_suc2.Visible = false;

            label_suc2.Location = new Point((label_suc2.Parent.ClientSize.Width / 2) - (label_suc2.Width / 2), (label_suc2.Parent.Height / 2));
            label_suc.Location = new Point((label_suc.Parent.ClientSize.Width / 2) - (label_suc.Width / 2), (label_suc.Parent.ClientSize.Height / 2));

            levelnum_lebel.Location = new Point((levelnum_lebel.Parent.ClientSize.Width / 30) - (levelnum_lebel.Width / 30), (levelnum_lebel.Parent.ClientSize.Height / 3));

            levelnum2_label.Location = new Point((levelnum2_label.Parent.ClientSize.Width / 30) - (levelnum2_label.Width / 30), (levelnum2_label.Parent.ClientSize.Height / 2));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //rockket.Left = Cursor.Position.X - (rockket.Width / 3);
            ball.Left += speed_left;
            ball.Top += speed_top;

           
            //rockket 1
            if (ball.Bottom >= rockket.Top && ball.Bottom <= rockket.Bottom && ball.Left >= rockket.Left && ball.Right <= rockket.Right)
            {

                speed_top += 2;
                speed_left += 2;

                speed_top = -speed_top;
        
            }

            //rocket 2
            if (ball.Top <= rockket2.Bottom && ball.Top >= rockket2.Top && ball.Left >= rockket2.Left && ball.Right <= rockket2.Right)
            {

                speed_top += 2;
                speed_left += 2;

                speed_top = -speed_top;

            }




            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;

            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;


            }
            if (ball.Top <= playground.Top)
            {

                point2 += 1;
                levelnum2_label.Text = point.ToString();
               // Thread a2 = new Thread(new ThreadStart(ai2));
               // a2.Start();
               // ai2();
                speed_top = -speed_top;


            }
            if (ball.Bottom >= playground.Bottom)
            {
                point += 1;
                levelnum_lebel.Text = point.ToString();
               // Thread a1 = new Thread(new ThreadStart(ai1));
                //a1.Start();
               // ai1();
                speed_top = -speed_top;
            }

            if( point == 10)
            {

                timer1.Enabled = false;

                label_suc.Visible = true;

            }

            if( point2 == 10)
            {
                timer1.Enabled = false;

                label_suc2.Visible = true;
            }

            
        }
      /*  private void golv()
        {
            

        }
        
        private void lvuper()
        {
           

        }*/

       /* private void ai2()
        {

            //point2 += 1;
        }
        private void ai1()
        {

            //point += 1;

            

        }
        */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }


            if (e.KeyCode == Keys.Left)
            {

                rockket.Left += -150;

            }

            if (e.KeyCode == Keys.Right)
            {

                rockket.Left += 150;

            }

            if(e.KeyCode == Keys.A)
            {
                rockket2.Left += -150;


            }

            if(e.KeyCode == Keys.D)
            {
                rockket2.Left += 150;

            }
        }

        private void rockket_Click(object sender, EventArgs e)
        {

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void levelnum2_label_Click(object sender, EventArgs e)
        {

        }
    }
}
