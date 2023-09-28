using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace UsandoSQLite
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            guna_txtnome.CharacterCasing = CharacterCasing.Upper;
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            this.guna_txtsenha.PasswordChar = Convert.ToChar(42);
        }

        private void guna_btnLogin_Click(object sender, EventArgs e)
        {
            string sql;
            MySqlDataReader dr = null;
            Conexao_banco con = new Conexao_banco();

            if (guna_txtnome.Text == "" || guna_txtsenha.Text == "")
            {
                MessageBox.Show("Os campos são obrigatórios...");
                return;
            }

            try
            {
                con.conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con.conexao;
                sql = "SELECT Nome, Senha, NiveAcesso FROM User";
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                cmd.Dispose();

                while (dr.Read())
                {
                    if (guna_txtnome.Text == dr.GetString(0) && guna_txtsenha.Text == dr.GetString(1))
                    {
                        this.Hide();
                        con.desconectar();
                        frmmenu obj = new frmmenu();
                        obj.Text = dr.GetString(2);
                        obj.Show();
                        //Thread t = new Thread(() => Application.Run(new frmmenu()));
                        //t.Start();
                        return;
                    }
                }

                MessageBox.Show("Usuário não encontrado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao fazer login... " + ex);
                con.desconectar();
            }

        }

        private void guna_btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.check_senha.Checked == true)
            {
                this.guna_txtsenha.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                this.guna_txtsenha.PasswordChar = Convert.ToChar(42);
            }
        }
    }
}
