using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
//using System.Data.SQLite;

namespace UsandoSQLite
{
    public partial class frm_cadusuario : Form
    {
        public frm_cadusuario()
        {
            InitializeComponent();
        }

        //Evento Load ->> quando o formulario carrega
        private void frm_cadusuario_Load(object sender, EventArgs e)
        {
            this.txt_usuario.CharacterCasing = CharacterCasing.Upper;
            this.txt_chave.Visible = false;
            cbo_nivel_acesso.SelectedIndex = 0;
            AddListview();
        }

        //Botão cadastrar Usuários
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nome = txt_usuario.Text;
            string senha = txt_senha.Text;
            string acesso = cbo_nivel_acesso.Text;
            string sql;
            Conexao_banco cn = new Conexao_banco();

            //--------------------------------------------------------------------------------
            if (nome == "" || senha == "" || acesso == "")
            {
                MessageBox.Show("Campos são obrigatórios!", "Aviso!", MessageBoxButtons.OK);
                return;
            }

            if (txt_senha.Text.Length < 8)
            {
                MessageBox.Show("O campo deve conter no minimo 8 caracter.", "Aviso!", MessageBoxButtons.OK);
                txt_senha.Focus();
                return;
            }
            //---------------------------------------------------------------------------------
            try
            {
                sql = "INSERT INTO User (Nome, Senha, NiveAcesso) VALUES ('" + nome + "', '" + senha + "', '" + acesso + "')";
                cn.Salvar(sql);
                MessageBox.Show("sucesso!", "Salvo", MessageBoxButtons.OK);

                //Maneira básica e mais usada para limpar controles
                txt_usuario.Text = "";
                txt_senha.Text = "";
                cbo_nivel_acesso.Text = String.Empty;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro encontrado" + ex.Message);
            }
            finally
            {
                cn.desconectar();
            }
            AddListview();
        }

        //Adcionar os usuarios cadastrados dentro da combobox
        // private void AddUser_comboUser()
        //{
        //    string sql = null;
        //    SQLiteCommand cmd = new SQLiteCommand();
        //    SQLiteDataReader dr = null;


        //    try
        //    {
        //        Conexao_banco.conectar();
        //        cmd.Connection = Conexao_banco.conexao;
        //        sql = "SELECT NOME FROM User";
        //        cmd.CommandText = sql;
        //        dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            this.cbo_usuario.Items.Add(dr.GetString(0));
        //        }

        //    }
        //    catch (SQLiteException ex)
        //    {
        //        MessageBox.Show("Erro encontrado" + ex);
        //        Conexao_banco.desconectar();
        //    }
        //    finally
        //    {
        //        Conexao_banco.desconectar();
        //    }

        //}

        private void AddListview()
        {
            ListViewItem item = new ListViewItem();
            string sql;
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr = null;
            Conexao_banco con = new Conexao_banco();

            try
            {
                con.conectar();
                sql = "SELECT id , Nome, Senha, NiveAcesso FROM User";
                cmd.Connection = con.conexao;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                //Limpando os items da Listview
                this.list_user.Items.Clear();

                while (dr.Read())
                {
                    item = this.list_user.Items.Add(dr["id"].ToString());
                    for (int i = 1; i <= 3; i++)
                        item.SubItems.Add(dr.GetString(i));
                }

                //this.Text = Convert.ToString(this.list_user.Items.Count);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao adcionar os dados dentro da Listview." + ex.Message);
            }
            finally
            {
                con.desconectar();
                cmd.Dispose();
            }
        }

        private void txt_senha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar > 47 && e.KeyChar < 58)
            //{
            //    //txt_senha.Clear();
            //    e.KeyChar = (char)0; //esta é a forma mais eficinte para resetar um valor

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao_banco con = new Conexao_banco();
            if (this.txt_chave.Text == string.Empty)
            {
                return;
            }

            try
            {
                if (MessageBox.Show("Deseja deletar esse usuário ? ", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string chave = this.txt_chave.Text;
                    string sql;

                    sql = "DELETE FROM User WHERE Id=" + chave;
                    con.deletar(sql);
                    MessageBox.Show("Usuário deletado com sucesso", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.txt_chave.Text = string.Empty;
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar usuário..." + ex);
            }
            finally
            {
                con.desconectar();
            }
            AddListview();
            this.txt_chave.Text = string.Empty;
        }

        private void list_user_MouseClick(object sender, MouseEventArgs e)
        {
            this.txt_chave.Text = this.list_user.SelectedItems[0].SubItems[0].Text;
        }
    }
}


