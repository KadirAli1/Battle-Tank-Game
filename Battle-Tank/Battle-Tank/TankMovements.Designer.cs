namespace Battle_Tank
{
    partial class TankMovements
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
            this.tank = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tank)).BeginInit();
            this.SuspendLayout();
            // 
            // tank
            // 
            this.tank.Image = global::Battle_Tank.Properties.Resources.tank;
            this.tank.Location = new System.Drawing.Point(331, 191);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(47, 50);
            this.tank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tank.TabIndex = 0;
            this.tank.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TankMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tank);
            this.Name = "TankMovements";
            this.Text = "TankMovements";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TankMovements_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TankMovements_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tank;
        private System.Windows.Forms.Timer timer1;
    }
}