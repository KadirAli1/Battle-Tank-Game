namespace Battle_Tank
{
    partial class ResultsScene
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
            this.newGamebtn = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.looserScore = new System.Windows.Forms.Label();
            this.winnerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newGamebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // newGamebtn
            // 
            this.newGamebtn.Image = global::Battle_Tank.Properties.Resources.newGameBtn;
            this.newGamebtn.Location = new System.Drawing.Point(208, 418);
            this.newGamebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newGamebtn.Name = "newGamebtn";
            this.newGamebtn.Size = new System.Drawing.Size(130, 58);
            this.newGamebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newGamebtn.TabIndex = 0;
            this.newGamebtn.TabStop = false;
            this.newGamebtn.Click += new System.EventHandler(this.newGamebtn_Click);
            this.newGamebtn.MouseEnter += new System.EventHandler(this.newGamebtn_MouseEnter);
            this.newGamebtn.MouseLeave += new System.EventHandler(this.newGamebtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::Battle_Tank.Properties.Resources.ExitBtn;
            this.exitBtn.Location = new System.Drawing.Point(394, 418);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(128, 54);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore1.Location = new System.Drawing.Point(262, 341);
            this.lblScore1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(70, 20);
            this.lblScore1.TabIndex = 2;
            this.lblScore1.Text = "SCORE:";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore2.Location = new System.Drawing.Point(385, 341);
            this.lblScore2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(70, 20);
            this.lblScore2.TabIndex = 3;
            this.lblScore2.Text = "SCORE:";
            // 
            // looserScore
            // 
            this.looserScore.AutoSize = true;
            this.looserScore.BackColor = System.Drawing.Color.Transparent;
            this.looserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.looserScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.looserScore.Location = new System.Drawing.Point(332, 341);
            this.looserScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.looserScore.Name = "looserScore";
            this.looserScore.Size = new System.Drawing.Size(32, 20);
            this.looserScore.TabIndex = 4;
            this.looserScore.Text = "Pts";
            // 
            // winnerScore
            // 
            this.winnerScore.AutoSize = true;
            this.winnerScore.BackColor = System.Drawing.Color.Transparent;
            this.winnerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winnerScore.Location = new System.Drawing.Point(454, 341);
            this.winnerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winnerScore.Name = "winnerScore";
            this.winnerScore.Size = new System.Drawing.Size(32, 20);
            this.winnerScore.TabIndex = 5;
            this.winnerScore.Text = "Pts";
            // 
            // ResultsScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Battle_Tank.Properties.Resources.ResultsScene;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 518);
            this.Controls.Add(this.winnerScore);
            this.Controls.Add(this.looserScore);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newGamebtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResultsScene";
            this.Text = "ResultsScene";
            this.Load += new System.EventHandler(this.ResultsScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newGamebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newGamebtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label looserScore;
        private System.Windows.Forms.Label winnerScore;
    }
}