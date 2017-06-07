namespace pingping
{
    partial class main_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.ponglogobox = new System.Windows.Forms.PictureBox();
            this.new_game_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ballmenu2 = new System.Windows.Forms.PictureBox();
            this.ballmenu1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ponglogobox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballmenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballmenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ponglogobox
            // 
            this.ponglogobox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ponglogobox.BackgroundImage")));
            this.ponglogobox.Location = new System.Drawing.Point(313, 123);
            this.ponglogobox.Name = "ponglogobox";
            this.ponglogobox.Size = new System.Drawing.Size(724, 216);
            this.ponglogobox.TabIndex = 0;
            this.ponglogobox.TabStop = false;
            // 
            // new_game_label
            // 
            this.new_game_label.AutoSize = true;
            this.new_game_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_game_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.new_game_label.Location = new System.Drawing.Point(590, 399);
            this.new_game_label.Name = "new_game_label";
            this.new_game_label.Size = new System.Drawing.Size(339, 100);
            this.new_game_label.TabIndex = 1;
            this.new_game_label.Text = "PRESS  ENTER TO 2 PLAYER\r\nPRESS 1 TO SINGLE PLAYER \r\n\r\n        PRESS X TO EXIT";
            this.new_game_label.Click += new System.EventHandler(this.new_game_label_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ballmenu2);
            this.panel1.Controls.Add(this.ballmenu1);
            this.panel1.Controls.Add(this.ponglogobox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 599);
            this.panel1.TabIndex = 2;
            // 
            // ballmenu2
            // 
            this.ballmenu2.BackColor = System.Drawing.Color.RoyalBlue;
            this.ballmenu2.Location = new System.Drawing.Point(253, 165);
            this.ballmenu2.Name = "ballmenu2";
            this.ballmenu2.Size = new System.Drawing.Size(20, 20);
            this.ballmenu2.TabIndex = 2;
            this.ballmenu2.TabStop = false;
            // 
            // ballmenu1
            // 
            this.ballmenu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ballmenu1.BackColor = System.Drawing.Color.Yellow;
            this.ballmenu1.Location = new System.Drawing.Point(1003, 65);
            this.ballmenu1.Name = "ballmenu1";
            this.ballmenu1.Size = new System.Drawing.Size(20, 20);
            this.ballmenu1.TabIndex = 1;
            this.ballmenu1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1134, 599);
            this.Controls.Add(this.new_game_label);
            this.Controls.Add(this.panel1);
            this.Name = "main_menu";
            this.Text = "main_menu";
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ponglogobox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballmenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballmenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ponglogobox;
        private System.Windows.Forms.Label new_game_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ballmenu1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ballmenu2;
    }
}