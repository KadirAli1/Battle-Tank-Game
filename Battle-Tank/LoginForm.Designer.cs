namespace Battle_Tank
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnPlayM = new MetroFramework.Controls.MetroButton();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblPlayer1M = new MetroFramework.Controls.MetroLabel();
            this.lblPlayer2M = new MetroFramework.Controls.MetroLabel();
            this.lblLoginPlayer1M = new MetroFramework.Controls.MetroLabel();
            this.lblLoginPlayer2M = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(144, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(226, 149);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 35);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.DisplayIcon = true;
            this.tbUsername.Icon = ((System.Drawing.Image)(resources.GetObject("tbUsername.Icon")));
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(146, 77);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PromptText = "Enter your username";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(164, 23);
            this.tbUsername.TabIndex = 16;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMark = "Enter your username";
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsername.Click += new System.EventHandler(this.tbUsernameM_Click);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.DisplayIcon = true;
            this.tbPassword.Icon = ((System.Drawing.Image)(resources.GetObject("tbPassword.Icon")));
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(146, 110);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PromptText = "Enter your password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(164, 23);
            this.tbPassword.TabIndex = 17;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMark = "Enter your password";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPlayM
            // 
            this.btnPlayM.BackColor = System.Drawing.Color.Red;
            this.btnPlayM.Enabled = false;
            this.btnPlayM.Location = new System.Drawing.Point(337, 149);
            this.btnPlayM.Name = "btnPlayM";
            this.btnPlayM.Size = new System.Drawing.Size(149, 35);
            this.btnPlayM.TabIndex = 18;
            this.btnPlayM.Text = "Play";
            this.btnPlayM.UseSelectable = true;
            this.btnPlayM.Click += new System.EventHandler(this.btnPlayM_Click);
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpace.Location = new System.Drawing.Point(148, 205);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(0, 20);
            this.lblSpace.TabIndex = 19;
            // 
            // lblPlayer1M
            // 
            this.lblPlayer1M.AutoSize = true;
            this.lblPlayer1M.Location = new System.Drawing.Point(337, 79);
            this.lblPlayer1M.Name = "lblPlayer1M";
            this.lblPlayer1M.Size = new System.Drawing.Size(57, 19);
            this.lblPlayer1M.TabIndex = 20;
            this.lblPlayer1M.Text = "Player 1:";
            // 
            // lblPlayer2M
            // 
            this.lblPlayer2M.AutoSize = true;
            this.lblPlayer2M.Location = new System.Drawing.Point(337, 110);
            this.lblPlayer2M.Name = "lblPlayer2M";
            this.lblPlayer2M.Size = new System.Drawing.Size(59, 19);
            this.lblPlayer2M.TabIndex = 21;
            this.lblPlayer2M.Text = "Player 2:";
            // 
            // lblLoginPlayer1M
            // 
            this.lblLoginPlayer1M.AutoSize = true;
            this.lblLoginPlayer1M.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLoginPlayer1M.Location = new System.Drawing.Point(403, 79);
            this.lblLoginPlayer1M.Name = "lblLoginPlayer1M";
            this.lblLoginPlayer1M.Size = new System.Drawing.Size(0, 0);
            this.lblLoginPlayer1M.TabIndex = 22;
            // 
            // lblLoginPlayer2M
            // 
            this.lblLoginPlayer2M.AutoSize = true;
            this.lblLoginPlayer2M.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLoginPlayer2M.Location = new System.Drawing.Point(403, 111);
            this.lblLoginPlayer2M.Name = "lblLoginPlayer2M";
            this.lblLoginPlayer2M.Size = new System.Drawing.Size(0, 0);
            this.lblLoginPlayer2M.TabIndex = 23;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 235);
            this.Controls.Add(this.lblLoginPlayer2M);
            this.Controls.Add(this.lblLoginPlayer1M);
            this.Controls.Add(this.lblPlayer2M);
            this.Controls.Add(this.lblPlayer1M);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.btnPlayM);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbUsername;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroButton btnPlayM;
        private System.Windows.Forms.Label lblSpace;
        private MetroFramework.Controls.MetroLabel lblPlayer1M;
        private MetroFramework.Controls.MetroLabel lblPlayer2M;
        private MetroFramework.Controls.MetroLabel lblLoginPlayer1M;
        private MetroFramework.Controls.MetroLabel lblLoginPlayer2M;
    }
}

