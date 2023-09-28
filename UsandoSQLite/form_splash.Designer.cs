namespace UsandoSQLite
{
    partial class form_splash
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
            this.guna_progres = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.time_splash = new System.Windows.Forms.Timer(this.components);
            this.guna_progres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna_progres
            // 
            this.guna_progres.Controls.Add(this.guna2CirclePictureBox1);
            this.guna_progres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna_progres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna_progres.ForeColor = System.Drawing.Color.White;
            this.guna_progres.Location = new System.Drawing.Point(4, 12);
            this.guna_progres.Minimum = 0;
            this.guna_progres.Name = "guna_progres";
            this.guna_progres.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.guna_progres.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.guna_progres.ProgressThickness = 20;
            this.guna_progres.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna_progres.Size = new System.Drawing.Size(328, 328);
            this.guna_progres.TabIndex = 1;
            this.guna_progres.Text = "guna2CircleProgressBar1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2CirclePictureBox1.Image = global::UsandoSQLite.Properties.Resources.luiz;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(65, 63);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.BorderRadius = 15;
            this.guna2CirclePictureBox1.ShadowDecoration.Enabled = true;
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(199, 208);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iniciando sistema...";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // time_splash
            // 
            this.time_splash.Interval = 40;
            this.time_splash.Tick += new System.EventHandler(this.time_splash_Tick);
            // 
            // form_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(339, 379);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna_progres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_splash_Load);
            this.guna_progres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna_progres;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer time_splash;
    }
}