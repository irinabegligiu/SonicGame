namespace Atestat
{
    partial class Form3
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
            this.sonic = new System.Windows.Forms.PictureBox();
            this.e1 = new System.Windows.Forms.PictureBox();
            this.e2 = new System.Windows.Forms.PictureBox();
            this.e3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.e4 = new System.Windows.Forms.PictureBox();
            this.e5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e5)).BeginInit();
            this.SuspendLayout();
            // 
            // sonic
            // 
            this.sonic.BackColor = System.Drawing.Color.Transparent;
            this.sonic.Image = global::Atestat.Properties.Resources.sonic2;
            this.sonic.Location = new System.Drawing.Point(140, 12);
            this.sonic.Name = "sonic";
            this.sonic.Size = new System.Drawing.Size(85, 81);
            this.sonic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sonic.TabIndex = 0;
            this.sonic.TabStop = false;
            this.sonic.Click += new System.EventHandler(this.sonic_Click);
            // 
            // e1
            // 
            this.e1.BackColor = System.Drawing.Color.Transparent;
            this.e1.Image = global::Atestat.Properties.Resources.sonic_coins_png;
            this.e1.Location = new System.Drawing.Point(309, 409);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(46, 40);
            this.e1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e1.TabIndex = 1;
            this.e1.TabStop = false;
            this.e1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // e2
            // 
            this.e2.BackColor = System.Drawing.Color.Transparent;
            this.e2.Image = global::Atestat.Properties.Resources.sonic_coins_png;
            this.e2.Location = new System.Drawing.Point(12, 409);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(44, 40);
            this.e2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e2.TabIndex = 2;
            this.e2.TabStop = false;
            this.e2.Click += new System.EventHandler(this.e2_Click);
            // 
            // e3
            // 
            this.e3.BackColor = System.Drawing.Color.Transparent;
            this.e3.Image = global::Atestat.Properties.Resources.Zero_sonic_adventure;
            this.e3.Location = new System.Drawing.Point(140, 366);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(94, 83);
            this.e3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e3.TabIndex = 4;
            this.e3.TabStop = false;
            this.e3.Click += new System.EventHandler(this.e3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(94, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 69);
            this.button1.TabIndex = 10;
            this.button1.Text = "Joacă din nou";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(6, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(86, 33);
            this.score.TabIndex = 11;
            this.score.Text = "Scor: 0";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Transparent;
            this.over.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(96, 166);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(194, 48);
            this.over.TabIndex = 12;
            this.over.Text = "Ai pierdut!";
            this.over.Click += new System.EventHandler(this.over_Click);
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
            this.button2.Location = new System.Drawing.Point(140, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Închide";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // e4
            // 
            this.e4.BackColor = System.Drawing.Color.Transparent;
            this.e4.Image = global::Atestat.Properties.Resources.sonic_coins_png;
            this.e4.Location = new System.Drawing.Point(73, 340);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(44, 40);
            this.e4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e4.TabIndex = 14;
            this.e4.TabStop = false;
            // 
            // e5
            // 
            this.e5.BackColor = System.Drawing.Color.Transparent;
            this.e5.Image = global::Atestat.Properties.Resources.sonic_coins_png;
            this.e5.Location = new System.Drawing.Point(256, 340);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(46, 40);
            this.e5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e5.TabIndex = 15;
            this.e5.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.wallpaper3;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.e5);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.over);
            this.Controls.Add(this.score);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.sonic);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sonic;
        private System.Windows.Forms.PictureBox e1;
        private System.Windows.Forms.PictureBox e2;
        private System.Windows.Forms.PictureBox e3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox e4;
        private System.Windows.Forms.PictureBox e5;
    }
}