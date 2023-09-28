namespace UsandoSQLite
{
    partial class frm_cadusuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_nivel_acesso = new System.Windows.Forms.ComboBox();
            this.list_user = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_Acesso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(225, 246);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(100, 42);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(333, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acesso";
            // 
            // cbo_nivel_acesso
            // 
            this.cbo_nivel_acesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nivel_acesso.FormattingEnabled = true;
            this.cbo_nivel_acesso.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbo_nivel_acesso.Location = new System.Drawing.Point(9, 261);
            this.cbo_nivel_acesso.Name = "cbo_nivel_acesso";
            this.cbo_nivel_acesso.Size = new System.Drawing.Size(93, 27);
            this.cbo_nivel_acesso.TabIndex = 0;
            // 
            // list_user
            // 
            this.list_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome,
            this.Senha,
            this.N_Acesso});
            this.list_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_user.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_user.FullRowSelect = true;
            this.list_user.GridLines = true;
            this.list_user.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_user.HideSelection = false;
            this.list_user.Location = new System.Drawing.Point(15, 12);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(418, 157);
            this.list_user.TabIndex = 5;
            this.list_user.UseCompatibleStateImageBehavior = false;
            this.list_user.View = System.Windows.Forms.View.Details;
            this.list_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_user_MouseClick);
            // 
            // Id
            // 
            this.Id.DisplayIndex = 3;
            this.Id.Text = "Id";
            this.Id.Width = 1;
            // 
            // Nome
            // 
            this.Nome.DisplayIndex = 0;
            this.Nome.Text = "Nome";
            this.Nome.Width = 181;
            // 
            // Senha
            // 
            this.Senha.DisplayIndex = 1;
            this.Senha.Text = "Senha";
            this.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Senha.Width = 139;
            // 
            // N_Acesso
            // 
            this.N_Acesso.DisplayIndex = 2;
            this.N_Acesso.Text = "N_Acesso";
            this.N_Acesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N_Acesso.Width = 97;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderRadius = 5;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.DefaultText = "";
            this.txt_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usuario.Location = new System.Drawing.Point(11, 201);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.PlaceholderText = "Digite nome";
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.Size = new System.Drawing.Size(209, 30);
            this.txt_usuario.TabIndex = 6;
            // 
            // txt_senha
            // 
            this.txt_senha.BorderRadius = 5;
            this.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senha.DefaultText = "";
            this.txt_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_senha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_senha.Location = new System.Drawing.Point(226, 201);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '\0';
            this.txt_senha.PlaceholderText = "Digite senha";
            this.txt_senha.SelectedText = "";
            this.txt_senha.Size = new System.Drawing.Size(207, 30);
            this.txt_senha.TabIndex = 7;
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress_1);
            // 
            // txt_chave
            // 
            this.txt_chave.Location = new System.Drawing.Point(403, 171);
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(28, 27);
            this.txt_chave.TabIndex = 8;
            // 
            // frm_cadusuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 296);
            this.Controls.Add(this.txt_chave);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.list_user);
            this.Controls.Add(this.cbo_nivel_acesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_salvar);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_cadusuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frm_cadusuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_nivel_acesso;
        private System.Windows.Forms.ListView list_user;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Senha;
        private System.Windows.Forms.ColumnHeader N_Acesso;
        private Guna.UI2.WinForms.Guna2TextBox txt_usuario;
        private Guna.UI2.WinForms.Guna2TextBox txt_senha;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.TextBox txt_chave;
    }
}

