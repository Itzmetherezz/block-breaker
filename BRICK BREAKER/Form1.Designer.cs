namespace BRICK_BREAKER
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
            this.txtScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.LOSSSCREEN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WINSCREEN = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.LOSSSCREEN.SuspendLayout();
            this.WINSCREEN.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Cyan;
            this.txtScore.Location = new System.Drawing.Point(2, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 39);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: ";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(371, 460);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 32);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ball.Location = new System.Drawing.Point(413, 336);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 25);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // LOSSSCREEN
            // 
            this.LOSSSCREEN.Controls.Add(this.WINSCREEN);
            this.LOSSSCREEN.Controls.Add(this.label3);
            this.LOSSSCREEN.Controls.Add(this.label2);
            this.LOSSSCREEN.Controls.Add(this.label1);
            this.LOSSSCREEN.Location = new System.Drawing.Point(-3, -3);
            this.LOSSSCREEN.Name = "LOSSSCREEN";
            this.LOSSSCREEN.Size = new System.Drawing.Size(803, 563);
            this.LOSSSCREEN.TabIndex = 3;
            this.LOSSSCREEN.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(156, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOU LOSE!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(149, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "You Let The Ball Fall!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 20F);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(197, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Press Enter To Try Again";
            // 
            // WINSCREEN
            // 
            this.WINSCREEN.Controls.Add(this.label5);
            this.WINSCREEN.Controls.Add(this.label4);
            this.WINSCREEN.Location = new System.Drawing.Point(4, 0);
            this.WINSCREEN.Name = "WINSCREEN";
            this.WINSCREEN.Size = new System.Drawing.Size(606, 563);
            this.WINSCREEN.TabIndex = 3;
            this.WINSCREEN.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 48F);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(182, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 117);
            this.label4.TabIndex = 0;
            this.label4.Text = "YOU WIN!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 28F);
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(98, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(660, 68);
            this.label5.TabIndex = 1;
            this.label5.Text = "Press ENTER To Play Again";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.LOSSSCREEN);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BRICK BREAKER";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.LOSSSCREEN.ResumeLayout(false);
            this.LOSSSCREEN.PerformLayout();
            this.WINSCREEN.ResumeLayout(false);
            this.WINSCREEN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel LOSSSCREEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WINSCREEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

