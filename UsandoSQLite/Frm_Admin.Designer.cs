namespace UsandoSQLite
{
    partial class Frm_Admin
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.data_admin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_turno_A = new System.Windows.Forms.Label();
            this.lbl_ope_A = new System.Windows.Forms.Label();
            this.lbl_turno_B = new System.Windows.Forms.Label();
            this.lbl_op_C = new System.Windows.Forms.Label();
            this.lbl_turno_C = new System.Windows.Forms.Label();
            this.lbl_op_B = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.Lbl_search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conteine_truno_C = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna_msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.conteine_truno_B = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.conteine_turno_A = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.conteine_truno_C.SuspendLayout();
            this.conteine_truno_B.SuspendLayout();
            this.conteine_turno_A.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // data_admin
            // 
            this.data_admin.Animated = true;
            this.data_admin.Checked = true;
            this.data_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_admin.CustomFormat = "yyyy/MM/dd";
            this.data_admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.data_admin.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_admin.ForeColor = System.Drawing.SystemColors.Control;
            this.data_admin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_admin.Location = new System.Drawing.Point(20, 75);
            this.data_admin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.data_admin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.data_admin.Name = "data_admin";
            this.data_admin.Size = new System.Drawing.Size(124, 28);
            this.data_admin.TabIndex = 0;
            this.data_admin.Value = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.guna2Button1.Font = new System.Drawing.Font("Roboto", 13F);
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Location = new System.Drawing.Point(9, 494);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(86, 39);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(852, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(26, 19);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // lbl_turno_A
            // 
            this.lbl_turno_A.AutoSize = true;
            this.lbl_turno_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.lbl_turno_A.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_turno_A.Location = new System.Drawing.Point(363, 21);
            this.lbl_turno_A.Name = "lbl_turno_A";
            this.lbl_turno_A.Size = new System.Drawing.Size(0, 18);
            this.lbl_turno_A.TabIndex = 6;
            this.lbl_turno_A.Tag = "turno";
            // 
            // lbl_ope_A
            // 
            this.lbl_ope_A.AutoSize = true;
            this.lbl_ope_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lbl_ope_A.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ope_A.Location = new System.Drawing.Point(13, 3);
            this.lbl_ope_A.Name = "lbl_ope_A";
            this.lbl_ope_A.Size = new System.Drawing.Size(42, 18);
            this.lbl_ope_A.TabIndex = 7;
            this.lbl_ope_A.Tag = "turno";
            this.lbl_ope_A.Text = "label2";
            // 
            // lbl_turno_B
            // 
            this.lbl_turno_B.AutoSize = true;
            this.lbl_turno_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.lbl_turno_B.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_turno_B.Location = new System.Drawing.Point(363, 204);
            this.lbl_turno_B.Name = "lbl_turno_B";
            this.lbl_turno_B.Size = new System.Drawing.Size(0, 18);
            this.lbl_turno_B.TabIndex = 8;
            this.lbl_turno_B.Tag = "turno";
            // 
            // lbl_op_C
            // 
            this.lbl_op_C.AutoSize = true;
            this.lbl_op_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lbl_op_C.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_op_C.Location = new System.Drawing.Point(13, 4);
            this.lbl_op_C.Name = "lbl_op_C";
            this.lbl_op_C.Size = new System.Drawing.Size(42, 18);
            this.lbl_op_C.TabIndex = 11;
            this.lbl_op_C.Tag = "turno";
            this.lbl_op_C.Text = "label4";
            // 
            // lbl_turno_C
            // 
            this.lbl_turno_C.AutoSize = true;
            this.lbl_turno_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.lbl_turno_C.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_turno_C.Location = new System.Drawing.Point(363, 388);
            this.lbl_turno_C.Name = "lbl_turno_C";
            this.lbl_turno_C.Size = new System.Drawing.Size(0, 18);
            this.lbl_turno_C.TabIndex = 10;
            this.lbl_turno_C.Tag = "turno";
            // 
            // lbl_op_B
            // 
            this.lbl_op_B.AutoSize = true;
            this.lbl_op_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.lbl_op_B.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_op_B.Location = new System.Drawing.Point(13, 4);
            this.lbl_op_B.Name = "lbl_op_B";
            this.lbl_op_B.Size = new System.Drawing.Size(42, 18);
            this.lbl_op_B.TabIndex = 9;
            this.lbl_op_B.Tag = "turno";
            this.lbl_op_B.Text = "label6";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtA.Location = new System.Drawing.Point(12, 31);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.ShowSelectionMargin = true;
            this.txtA.Size = new System.Drawing.Size(437, 131);
            this.txtA.TabIndex = 12;
            this.txtA.Text = "";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtB.Location = new System.Drawing.Point(12, 30);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.ShowSelectionMargin = true;
            this.txtB.Size = new System.Drawing.Size(437, 134);
            this.txtB.TabIndex = 13;
            this.txtB.Text = "";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtC.Location = new System.Drawing.Point(12, 30);
            this.txtC.Margin = new System.Windows.Forms.Padding(2);
            this.txtC.Name = "txtC";
            this.txtC.ShowSelectionMargin = true;
            this.txtC.Size = new System.Drawing.Size(430, 132);
            this.txtC.TabIndex = 14;
            this.txtC.Text = "";
            // 
            // Lbl_search
            // 
            this.Lbl_search.AutoSize = true;
            this.Lbl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.Lbl_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_search.Location = new System.Drawing.Point(19, 56);
            this.Lbl_search.Name = "Lbl_search";
            this.Lbl_search.Size = new System.Drawing.Size(125, 18);
            this.Lbl_search.TabIndex = 15;
            this.Lbl_search.Text = "Selecione uma data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Relatório Diario ";
            // 
            // conteine_truno_C
            // 
            this.conteine_truno_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.conteine_truno_C.BorderRadius = 10;
            this.conteine_truno_C.Controls.Add(this.txtC);
            this.conteine_truno_C.Controls.Add(this.lbl_op_C);
            this.conteine_truno_C.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.conteine_truno_C.Location = new System.Drawing.Point(383, 383);
            this.conteine_truno_C.Name = "conteine_truno_C";
            this.conteine_truno_C.Size = new System.Drawing.Size(460, 174);
            this.conteine_truno_C.TabIndex = 17;
            this.conteine_truno_C.Text = "guna2ContainerControl1";
            // 
            // guna_msg
            // 
            this.guna_msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna_msg.Caption = "Aviso!";
            this.guna_msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna_msg.Parent = this;
            this.guna_msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna_msg.Text = null;
            // 
            // conteine_truno_B
            // 
            this.conteine_truno_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.conteine_truno_B.BorderRadius = 10;
            this.conteine_truno_B.Controls.Add(this.txtB);
            this.conteine_truno_B.Controls.Add(this.lbl_op_B);
            this.conteine_truno_B.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.conteine_truno_B.Location = new System.Drawing.Point(383, 200);
            this.conteine_truno_B.Name = "conteine_truno_B";
            this.conteine_truno_B.Size = new System.Drawing.Size(460, 171);
            this.conteine_truno_B.TabIndex = 18;
            this.conteine_truno_B.Text = "guna2ContainerControl1";
            // 
            // conteine_turno_A
            // 
            this.conteine_turno_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.conteine_turno_A.BorderRadius = 10;
            this.conteine_turno_A.Controls.Add(this.txtA);
            this.conteine_turno_A.Controls.Add(this.lbl_ope_A);
            this.conteine_turno_A.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.conteine_turno_A.Location = new System.Drawing.Point(383, 17);
            this.conteine_turno_A.Name = "conteine_turno_A";
            this.conteine_turno_A.Size = new System.Drawing.Size(460, 171);
            this.conteine_turno_A.TabIndex = 19;
            this.conteine_turno_A.Text = "guna2ContainerControl2";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.data_admin);
            this.guna2Panel1.Controls.Add(this.Lbl_search);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 17);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(237, 540);
            this.guna2Panel1.TabIndex = 20;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(882, 566);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbl_turno_C);
            this.Controls.Add(this.lbl_turno_B);
            this.Controls.Add(this.lbl_turno_A);
            this.Controls.Add(this.conteine_turno_A);
            this.Controls.Add(this.conteine_truno_B);
            this.Controls.Add(this.conteine_truno_C);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.conteine_truno_C.ResumeLayout(false);
            this.conteine_truno_C.PerformLayout();
            this.conteine_truno_B.ResumeLayout(false);
            this.conteine_truno_B.PerformLayout();
            this.conteine_turno_A.ResumeLayout(false);
            this.conteine_turno_A.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.Label lbl_op_C;
        private System.Windows.Forms.Label lbl_turno_C;
        private System.Windows.Forms.Label lbl_op_B;
        private System.Windows.Forms.Label lbl_turno_B;
        private System.Windows.Forms.Label lbl_ope_A;
        private System.Windows.Forms.Label lbl_turno_A;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_search;
        private Guna.UI2.WinForms.Guna2ContainerControl conteine_turno_A;
        private Guna.UI2.WinForms.Guna2ContainerControl conteine_truno_B;
        private Guna.UI2.WinForms.Guna2ContainerControl conteine_truno_C;
        public Guna.UI2.WinForms.Guna2MessageDialog guna_msg;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker data_admin;
    }
}