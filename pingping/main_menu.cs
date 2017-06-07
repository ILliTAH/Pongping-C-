using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace pingping
{
    public partial class main_menu : Form
    {
        System.Media.SoundPlayer playerbg = new System.Media.SoundPlayer();
        public int ballmenu_speedleft = 4;
        public int ballmenu_speedtop = 4;

        //ball 2 blue

        public int ballmenu2_speedleft = 4;
        public int ballmenu2_speedtop = 4;

        


        public main_menu()
        {
            InitializeComponent();

            playerbg.SoundLocation = "mumu.wav";

            playerbg.PlayLooping();

            Cursor.Hide();
            timer1.Enabled = true;


            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            

            ///  location 
            ponglogobox.Location = new Point((ponglogobox.Parent.ClientSize.Width / 2) - (ponglogobox.Width / 2), (ponglogobox.Parent.ClientSize.Height / 2) - (ponglogobox.Height / 1));

            //menu label

            new_game_label.Location = new Point((new_game_label.Parent.ClientSize.Width / 2) - (new_game_label.Width / 2), (new_game_label.Parent.ClientSize.Height / 2));

            

        




        }

        private void main_menu_Load(object sender, EventArgs e)
        {

        }

        private void new_game_label_Click(object sender, EventArgs e)
        {
            

            Form1 f = new Form1();
            f.Show();
            


        }

        private void main_menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Form1 l1 = new Form1();
                l1.Show();


            }

            if(e.KeyCode == Keys.X)
            {
                Application.Exit();


            }

            if(e.KeyCode == Keys.D1)
            {

                Form2 f2 = new Form2();
                f2.Show();



            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ballmenu1.Left += ballmenu_speedleft;
            ballmenu1.Top += ballmenu_speedtop;

           
            ballmenu2.Top += ballmenu2_speedtop;
            ballmenu2.Left += ballmenu2_speedleft;


            ///ball 1 move to monitor  
            if(ballmenu1.Left <= panel1.Left)
            {
                ballmenu_speedleft = -ballmenu_speedleft;

            }

            if(ballmenu1.Right >= panel1.Right)
            {
                ballmenu_speedleft = -ballmenu_speedleft;

            }


            if(ballmenu1.Top <= panel1.Top)
            {

                ballmenu_speedtop = -ballmenu_speedtop;

            }

            if(ballmenu1.Bottom >= panel1.Bottom)
            {
                ballmenu_speedtop = -ballmenu_speedtop;

            }
            ///// end ball 1 move to monitor

            //// ball 2 move to monitor

            if(ballmenu2.Left <= panel1.Left)
            {
                ballmenu2_speedleft = -ballmenu2_speedleft;


            }

            if(ballmenu2.Right >= panel1.Right)
            {

                ballmenu2_speedleft = -ballmenu2_speedleft;


            }
            if (ballmenu2.Top <= panel1.Top)
            {
                ballmenu2_speedtop = -ballmenu2_speedtop;


            }
            if (ballmenu2.Bottom >= panel1.Bottom)
            {

                ballmenu2_speedtop = -ballmenu2_speedtop;
            }



        }
    }
}
