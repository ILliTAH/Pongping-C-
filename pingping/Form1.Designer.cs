namespace pingping
{
    partial class Form1
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
            this.playground = new System.Windows.Forms.Panel();
            this.label_suc2 = new System.Windows.Forms.Label();
            this.levelnum2_label = new System.Windows.Forms.Label();
            this.rockket2 = new System.Windows.Forms.PictureBox();
            this.label_suc = new System.Windows.Forms.Label();
            this.levelnum_lebel = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.rockket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Black;
            this.playground.Controls.Add(this.label_suc2);
            this.playground.Controls.Add(this.levelnum2_label);
            this.playground.Controls.Add(this.rockket2);
            this.playground.Controls.Add(this.label_suc);
            this.playground.Controls.Add(this.levelnum_lebel);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.rockket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(689, 435);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // label_suc2
            // 
            this.label_suc2.AutoSize = true;
            this.label_suc2.Font = new System.Drawing.Font("Death Star", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suc2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_suc2.Location = new System.Drawing.Point(281, 211);
            this.label_suc2.Name = "label_suc2";
            this.label_suc2.Size = new System.Drawing.Size(298, 51);
            this.label_suc2.TabIndex = 9;
            this.label_suc2.Text = "RED WIN !";
            // 
            // levelnum2_label
            // 
            this.levelnum2_label.AutoSize = true;
            this.levelnum2_label.Font = new System.Drawing.Font("Death Star", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelnum2_label.ForeColor = System.Drawing.Color.Crimson;
            this.levelnum2_label.Location = new System.Drawing.Point(12, 227);
            this.levelnum2_label.Name = "levelnum2_label";
            this.levelnum2_label.Size = new System.Drawing.Size(63, 51);
            this.levelnum2_label.TabIndex = 8;
            this.levelnum2_label.Text = "0";
            this.levelnum2_label.Click += new System.EventHandler(this.levelnum2_label_Click);
            // 
            // rockket2
            // 
            this.rockket2.BackColor = System.Drawing.Color.Blue;
            this.rockket2.Location = new System.Drawing.Point(233, 53);
            this.rockket2.Name = "rockket2";
            this.rockket2.Size = new System.Drawing.Size(200, 20);
            this.rockket2.TabIndex = 7;
            this.rockket2.TabStop = false;
            // 
            // label_suc
            // 
            this.label_suc.AutoSize = true;
            this.label_suc.BackColor = System.Drawing.Color.Transparent;
            this.label_suc.Font = new System.Drawing.Font("Death Star", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_suc.Location = new System.Drawing.Point(255, 211);
            this.label_suc.Name = "label_suc";
            this.label_suc.Size = new System.Drawing.Size(332, 51);
            this.label_suc.TabIndex = 6;
            this.label_suc.Text = "BLUE WIN !";
            // 
            // levelnum_lebel
            // 
            this.levelnum_lebel.AutoSize = true;
            this.levelnum_lebel.BackColor = System.Drawing.Color.Transparent;
            this.levelnum_lebel.Font = new System.Drawing.Font("Death Star", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelnum_lebel.ForeColor = System.Drawing.Color.Blue;
            this.levelnum_lebel.Location = new System.Drawing.Point(12, 297);
            this.levelnum_lebel.Name = "levelnum_lebel";
            this.levelnum_lebel.Size = new System.Drawing.Size(63, 51);
            this.levelnum_lebel.TabIndex = 3;
            this.levelnum_lebel.Text = "0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.Location = new System.Drawing.Point(324, 281);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // rockket
            // 
            this.rockket.BackColor = System.Drawing.Color.Crimson;
            this.rockket.Location = new System.Drawing.Point(233, 379);
            this.rockket.Name = "rockket";
            this.rockket.Size = new System.Drawing.Size(200, 20);
            this.rockket.TabIndex = 0;
            this.rockket.TabStop = false;
            this.rockket.Click += new System.EventHandler(this.rockket_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 435);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox rockket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label levelnum_lebel;
        private System.Windows.Forms.Label label_suc;
        private System.Windows.Forms.PictureBox rockket2;
        private System.Windows.Forms.Label levelnum2_label;
        private System.Windows.Forms.Label label_suc2;
    }
}

