namespace catchDuckGame
{
    partial class Game
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
            this.flyTimer = new System.Windows.Forms.Timer(this.components);
            this.bullet5 = new System.Windows.Forms.PictureBox();
            this.bullet4 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.duckGif = new System.Windows.Forms.PictureBox();
            this.reloadPicture = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flyTimer
            // 
            this.flyTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bullet5
            // 
            this.bullet5.BackColor = System.Drawing.Color.Transparent;
            this.bullet5.Image = global::catchDuckGame.Properties.Resources.bullet1;
            this.bullet5.Location = new System.Drawing.Point(757, 400);
            this.bullet5.Name = "bullet5";
            this.bullet5.Size = new System.Drawing.Size(18, 38);
            this.bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet5.TabIndex = 5;
            this.bullet5.TabStop = false;
            // 
            // bullet4
            // 
            this.bullet4.BackColor = System.Drawing.Color.Transparent;
            this.bullet4.Image = global::catchDuckGame.Properties.Resources.bullet1;
            this.bullet4.Location = new System.Drawing.Point(733, 400);
            this.bullet4.Name = "bullet4";
            this.bullet4.Size = new System.Drawing.Size(18, 38);
            this.bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet4.TabIndex = 4;
            this.bullet4.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.BackColor = System.Drawing.Color.Transparent;
            this.bullet3.Image = global::catchDuckGame.Properties.Resources.bullet1;
            this.bullet3.Location = new System.Drawing.Point(709, 400);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(18, 38);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 3;
            this.bullet3.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.BackColor = System.Drawing.Color.Transparent;
            this.bullet2.Image = global::catchDuckGame.Properties.Resources.bullet1;
            this.bullet2.Location = new System.Drawing.Point(685, 400);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(18, 38);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 2;
            this.bullet2.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.BackColor = System.Drawing.Color.Transparent;
            this.bullet1.Image = global::catchDuckGame.Properties.Resources.bullet1;
            this.bullet1.Location = new System.Drawing.Point(661, 400);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(18, 38);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 1;
            this.bullet1.TabStop = false;
            // 
            // duckGif
            // 
            this.duckGif.BackColor = System.Drawing.Color.Transparent;
            this.duckGif.Image = global::catchDuckGame.Properties.Resources.duck;
            this.duckGif.InitialImage = global::catchDuckGame.Properties.Resources.duck__1_;
            this.duckGif.Location = new System.Drawing.Point(1, 112);
            this.duckGif.Name = "duckGif";
            this.duckGif.Size = new System.Drawing.Size(42, 27);
            this.duckGif.TabIndex = 0;
            this.duckGif.TabStop = false;
            this.duckGif.Click += new System.EventHandler(this.duckGif_Click);
            // 
            // reloadPicture
            // 
            this.reloadPicture.BackColor = System.Drawing.Color.Transparent;
            this.reloadPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadPicture.Image = global::catchDuckGame.Properties.Resources.counter_strike_cs;
            this.reloadPicture.Location = new System.Drawing.Point(287, 319);
            this.reloadPicture.Name = "reloadPicture";
            this.reloadPicture.Size = new System.Drawing.Size(153, 163);
            this.reloadPicture.TabIndex = 6;
            this.reloadPicture.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 414);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(120, 24);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = " ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::catchDuckGame.Properties.Resources._648e4b24ab2d5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.reloadPicture);
            this.Controls.Add(this.bullet5);
            this.Controls.Add(this.bullet4);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.duckGif);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "Game";
            this.Click += new System.EventHandler(this.Game_Click);
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox duckGif;
        private System.Windows.Forms.Timer flyTimer;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox bullet4;
        private System.Windows.Forms.PictureBox bullet5;
        private System.Windows.Forms.PictureBox reloadPicture;
        private System.Windows.Forms.Label scoreLabel;
    }
}