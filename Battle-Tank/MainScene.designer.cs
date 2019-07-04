namespace Battle_Tank
{
    partial class MainScene
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbScores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Battle_Tank.Properties.Resources.keys_1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseEnter += new System.EventHandler(this.PictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.PictureBox4_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Battle_Tank.Properties.Resources.sound_control;
            this.pictureBox5.Location = new System.Drawing.Point(767, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(184, 135);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox5_MouseClick);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.PictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.PictureBox5_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Battle_Tank.Properties.Resources.play_1;
            this.pictureBox3.Location = new System.Drawing.Point(358, 359);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 152);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.PictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.PictureBox3_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Battle_Tank.Properties.Resources.login_1;
            this.pictureBox6.Location = new System.Drawing.Point(734, 375);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(208, 142);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.PictureBox6_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.PictureBox6_MouseLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pbScores
            // 
            this.pbScores.BackColor = System.Drawing.Color.Transparent;
            this.pbScores.Image = global::Battle_Tank.Properties.Resources.scores_1;
            this.pbScores.Location = new System.Drawing.Point(12, 359);
            this.pbScores.Name = "pbScores";
            this.pbScores.Size = new System.Drawing.Size(229, 158);
            this.pbScores.TabIndex = 8;
            this.pbScores.TabStop = false;
            this.pbScores.Click += new System.EventHandler(this.pbScores_Click);
            this.pbScores.MouseEnter += new System.EventHandler(this.PictureBox8_MouseEnter);
            this.pbScores.MouseLeave += new System.EventHandler(this.PictureBox8_MouseLeave);
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Battle_Tank.Properties.Resources.Tank_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 610);
            this.Controls.Add(this.pbScores);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Name = "MainScene";
            this.Text = "MainScene";
            this.Load += new System.EventHandler(this.MainScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbScores;
    }
}