namespace pingping
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playgroud = new System.Windows.Forms.Panel();
            this.rockketsing = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameover_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.scorenum_label = new System.Windows.Forms.Label();
            this.playgroud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockketsing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playgroud
            // 
            this.playgroud.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playgroud.Controls.Add(this.scorenum_label);
            this.playgroud.Controls.Add(this.score_label);
            this.playgroud.Controls.Add(this.gameover_label);
            this.playgroud.Controls.Add(this.ball);
            this.playgroud.Controls.Add(this.rockketsing);
            this.playgroud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playgroud.Location = new System.Drawing.Point(0, 0);
            this.playgroud.Name = "playgroud";
            this.playgroud.Size = new System.Drawing.Size(284, 261);
            this.playgroud.TabIndex = 0;
            // 
            // rockketsing
            // 
            this.rockketsing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rockketsing.Location = new System.Drawing.Point(163, 206);
            this.rockketsing.Name = "rockketsing";
            this.rockketsing.Size = new System.Drawing.Size(200, 20);
            this.rockketsing.TabIndex = 0;
            this.rockketsing.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(196, 78);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // gameover_label
            // 
            this.gameover_label.AutoSize = true;
            this.gameover_label.Font = new System.Drawing.Font("Death Star", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gameover_label.Location = new System.Drawing.Point(193, 123);
            this.gameover_label.Name = "gameover_label";
            this.gameover_label.Size = new System.Drawing.Size(403, 153);
            this.gameover_label.TabIndex = 2;
            this.gameover_label.Text = " GAME OVER \r\n\r\nESC - TO EXIT";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Death Star", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.Aqua;
            this.score_label.Location = new System.Drawing.Point(12, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(186, 38);
            this.score_label.TabIndex = 3;
            this.score_label.Text = "SCORE :";
            // 
            // scorenum_label
            // 
            this.scorenum_label.AutoSize = true;
            this.scorenum_label.BackColor = System.Drawing.Color.Transparent;
            this.scorenum_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.scorenum_label.Font = new System.Drawing.Font("Death Star", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorenum_label.ForeColor = System.Drawing.Color.Aqua;
            this.scorenum_label.Location = new System.Drawing.Point(195, 9);
            this.scorenum_label.Name = "scorenum_label";
            this.scorenum_label.Size = new System.Drawing.Size(47, 38);
            this.scorenum_label.TabIndex = 4;
            this.scorenum_label.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.playgroud);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.playgroud.ResumeLayout(false);
            this.playgroud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockketsing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel playgroud;
        private System.Windows.Forms.PictureBox rockketsing;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label gameover_label;
        private System.Windows.Forms.Label scorenum_label;
        private System.Windows.Forms.Label score_label;
    }
}