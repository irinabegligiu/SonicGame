namespace Atestat
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
            this.bullet = new System.Windows.Forms.PictureBox();
            this.sonic = new System.Windows.Forms.PictureBox();
            this.e3 = new System.Windows.Forms.PictureBox();
            this.e2 = new System.Windows.Forms.PictureBox();
            this.e1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.congrats = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).BeginInit();
            this.SuspendLayout();
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::Atestat.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(177, 329);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(32, 34);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 4;
            this.bullet.TabStop = false;
            this.bullet.Click += new System.EventHandler(this.bullet_Click);
            // 
            // sonic
            // 
            this.sonic.BackColor = System.Drawing.Color.Transparent;
            this.sonic.Image = global::Atestat.Properties.Resources.sonic;
            this.sonic.Location = new System.Drawing.Point(160, 365);
            this.sonic.Name = "sonic";
            this.sonic.Size = new System.Drawing.Size(65, 93);
            this.sonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sonic.TabIndex = 3;
            this.sonic.TabStop = false;
            this.sonic.Click += new System.EventHandler(this.sonic_Click);
            // 
            // e3
            // 
            this.e3.BackColor = System.Drawing.Color.Transparent;
            this.e3.Image = global::Atestat.Properties.Resources.e3;
            this.e3.Location = new System.Drawing.Point(279, 43);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(65, 60);
            this.e3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e3.TabIndex = 2;
            this.e3.TabStop = false;
            this.e3.Click += new System.EventHandler(this.e3_Click);
            // 
            // e2
            // 
            this.e2.BackColor = System.Drawing.Color.Transparent;
            this.e2.Image = global::Atestat.Properties.Resources.e3;
            this.e2.Location = new System.Drawing.Point(160, 43);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(65, 60);
            this.e2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e2.TabIndex = 1;
            this.e2.TabStop = false;
            this.e2.Click += new System.EventHandler(this.e2_Click);
            // 
            // e1
            // 
            this.e1.BackColor = System.Drawing.Color.Transparent;
            this.e1.Image = global::Atestat.Properties.Resources.e3;
            this.e1.Location = new System.Drawing.Point(37, 43);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(65, 60);
            this.e1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e1.TabIndex = 0;
            this.e1.TabStop = false;
            this.e1.Click += new System.EventHandler(this.e1_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Transparent;
            this.score.Location = new System.Drawing.Point(-2, 3);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(93, 37);
            this.score.TabIndex = 5;
            this.score.Text = "Scor: 0";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Transparent;
            this.over.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(100, 178);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(194, 48);
            this.over.TabIndex = 6;
            this.over.Text = "Ai pierdut!";
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // congrats
            // 
            this.congrats.AutoSize = true;
            this.congrats.BackColor = System.Drawing.Color.Transparent;
            this.congrats.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congrats.ForeColor = System.Drawing.Color.Transparent;
            this.congrats.Location = new System.Drawing.Point(-1, 155);
            this.congrats.Name = "congrats";
            this.congrats.Size = new System.Drawing.Size(393, 33);
            this.congrats.TabIndex = 7;
            this.congrats.Text = "Felicitări! Poti trece la nivelul următor!";
            this.congrats.Click += new System.EventHandler(this.congrats_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(60, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nivelul următor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(94, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Joacă din nou";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.wallpaper2;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.congrats);
            this.Controls.Add(this.over);
            this.Controls.Add(this.score);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.sonic);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox e1;
        private System.Windows.Forms.PictureBox e2;
        private System.Windows.Forms.PictureBox e3;
        private System.Windows.Forms.PictureBox sonic;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Label congrats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}