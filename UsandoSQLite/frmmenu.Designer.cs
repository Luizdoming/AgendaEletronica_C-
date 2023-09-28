namespace UsandoSQLite
{
    partial class frmmenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_admin = new Guna.UI2.WinForms.Guna2Button();
            this.btn_users = new Guna.UI2.WinForms.Guna2Button();
            this.tbn_relatorio = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_relogio = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_turno = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.btn_admin);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.tbn_relatorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 480);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_admin
            // 
            this.btn_admin.BorderRadius = 5;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Image = global::UsandoSQLite.Properties.Resources.icons8_workspace;
            this.btn_admin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_admin.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_admin.Location = new System.Drawing.Point(21, 148);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(129, 45);
            this.btn_admin.TabIndex = 13;
            this.btn_admin.Text = "Admin";
            this.btn_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_users
            // 
            this.btn_users.Animated = true;
            this.btn_users.AnimatedGIF = true;
            this.btn_users.BorderRadius = 5;
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_users.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.btn_users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_users.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btn_users.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.btn_users.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_users.Image = global::UsandoSQLite.Properties.Resources.icons8_registration;
            this.btn_users.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_users.ImageSize = new System.Drawing.Size(45, 42);
            this.btn_users.Location = new System.Drawing.Point(21, 12);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(126, 50);
            this.btn_users.TabIndex = 14;
            this.btn_users.Text = "Usuário";
            this.btn_users.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // tbn_relatorio
            // 
            this.tbn_relatorio.Animated = true;
            this.tbn_relatorio.AnimatedGIF = true;
            this.tbn_relatorio.BorderColor = System.Drawing.Color.Transparent;
            this.tbn_relatorio.BorderRadius = 5;
            this.tbn_relatorio.BorderThickness = 1;
            this.tbn_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbn_relatorio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbn_relatorio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tbn_relatorio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.tbn_relatorio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tbn_relatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.tbn_relatorio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.tbn_relatorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_relatorio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbn_relatorio.Image = global::UsandoSQLite.Properties.Resources.icons8_business_report;
            this.tbn_relatorio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbn_relatorio.ImageOffset = new System.Drawing.Point(-6, 1);
            this.tbn_relatorio.ImageSize = new System.Drawing.Size(40, 38);
            this.tbn_relatorio.Location = new System.Drawing.Point(21, 80);
            this.tbn_relatorio.Name = "tbn_relatorio";
            this.tbn_relatorio.Size = new System.Drawing.Size(126, 50);
            this.tbn_relatorio.TabIndex = 13;
            this.tbn_relatorio.Text = "Relatório";
            this.tbn_relatorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbn_relatorio.Click += new System.EventHandler(this.tbn_relatorio_Click);
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.lbl_nivel.Location = new System.Drawing.Point(790, 418);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(51, 20);
            this.lbl_nivel.TabIndex = 5;
            this.lbl_nivel.Text = ".......";
            // 
            // lbl_relogio
            // 
            this.lbl_relogio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_relogio.Font = new System.Drawing.Font("Trebuchet MS", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relogio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_relogio.Location = new System.Drawing.Point(169, 418);
            this.lbl_relogio.Name = "lbl_relogio";
            this.lbl_relogio.Size = new System.Drawing.Size(672, 62);
            this.lbl_relogio.TabIndex = 3;
            this.lbl_relogio.Text = "00:00:00";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleProgressBar1.AnimationSpeed = 0.3F;
            this.guna2CircleProgressBar1.Controls.Add(this.guna2CircleProgressBar2);
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.FillThickness = 15;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(691, 37);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Bisque;
            this.guna2CircleProgressBar1.ProgressThickness = 11;
            this.guna2CircleProgressBar1.ShadowDecoration.BorderRadius = 15;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(138, 138);
            this.guna2CircleProgressBar1.TabIndex = 8;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.Value = 75;
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleProgressBar2.AnimationSpeed = 0.2F;
            this.guna2CircleProgressBar2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar2.FillThickness = 10;
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(37, 38);
            this.guna2CircleProgressBar2.Minimum = 0;
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(98)))), ((int)(((byte)(212)))));
            this.guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.GhostWhite;
            this.guna2CircleProgressBar2.ProgressThickness = 10;
            this.guna2CircleProgressBar2.ShadowDecoration.BorderRadius = 15;
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(64, 64);
            this.guna2CircleProgressBar2.TabIndex = 9;
            this.guna2CircleProgressBar2.Text = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.Value = 80;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(807, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 22);
            this.guna2ControlBox1.TabIndex = 9;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(762, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 22);
            this.guna2ControlBox2.TabIndex = 10;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(717, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(30, 22);
            this.guna2ControlBox3.TabIndex = 11;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_turno
            // 
            this.lbl_turno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_turno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turno.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_turno.Location = new System.Drawing.Point(172, 1);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(65, 35);
            this.lbl_turno.TabIndex = 12;
            this.lbl_turno.Text = "Turno";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(841, 480);
            this.Controls.Add(this.lbl_turno);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_relogio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmenu";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmenu_FormClosing);
            this.Load += new System.EventHandler(this.frmmenu_Load);
            this.panel1.ResumeLayout(false);
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_relogio;
        private System.Windows.Forms.Label lbl_nivel;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_turno;
        private Guna.UI2.WinForms.Guna2Button tbn_relatorio;
        private Guna.UI2.WinForms.Guna2Button btn_users;
        private Guna.UI2.WinForms.Guna2Button btn_admin;
    }
}