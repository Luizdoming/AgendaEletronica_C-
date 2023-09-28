using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace UsandoSQLite
{
    public partial class frm_livro : Form
    {
        public frm_livro()
        {
            InitializeComponent();
            this.txt_turno.CharacterCasing = CharacterCasing.Upper;

            /*
             * outra forma de pegar a data atual
               this.txtdata_relato.Text = DateTime.Today.ToString("dd/MM/yyyy");
            */

            txtdata_relato.Text = DateTime.Now.ToShortDateString(); //pega a data atual
            txt_assunto.CharacterCasing = CharacterCasing.Upper;
            txt_turno.Visible = false;
            txt_turno.Enabled = false;
            txtdata_relato.Visible = false;
            txtdata_relato.Enabled = false;
            btn_editar_relato.Enabled = false;
        }

        private void frm_livro_Load(object sender, EventArgs e)
        {
            if (this.Text == "Um Òtimo Trabalho para o turno 'A'")
            {
                this.txt_turno.Text = "A";
            }
            else if (this.Text == "Um Òtimo Trabalho para o turno 'B'")
            {
                this.txt_turno.Text = "B";
            }
            else
            {
                this.txt_turno.Text = "C";
            }

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            Conexao_banco cn = new Conexao_banco();
            string operador;
            string turno;
            string assunto;

            try
            {
                //verificando se os campos estão vazios
                if (txt_assunto.Text == "" || txt_operador.Text == "" || txt_turno.Text == "")
                {
                    MessageBox.Show("Os campos são obrigatórios!", "Atenção");
                    return;
                }

                //Passando os valores para nossas variavéis
                assunto = txt_assunto.Text;
                operador = txt_operador.Text;
                turno = txt_turno.Text;

                //string para adcionar os dados dentro da nossa base de dados
                string sql = "INSERT INTO tb_livro (Operador, Assunto, Turno, Data) VALUES ('" + operador + "', '" + assunto + "', '" + turno + "', '" + DateTime.Now.ToString("yyyy/MM/dd") + "')";
                cn.salvar_assunto(sql);
                MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpando os controles
                txt_operador.Clear(); txt_assunto.Clear();
            }
            catch (MySqlException ex)
            {
                // messagem de erro
                MessageBox.Show("Erro ao adiconar informação! " + ex.Message);
                cn.desconectar();
            }
            finally
            {
                // fechando a conexão com database
                cn.desconectar();
            }

        }

        private void btn_editar_relato_Click(object sender, EventArgs e)
        {
            Conexao_banco cn = new Conexao_banco();
            string data = DateTime.Now.ToString("yyyy/MM/dd");
            string turno = txt_turno.Text;

            try
            {
                // verificação do campo assunto está vazio
                if (this.txt_assunto.Text == "")
                {
                    return;
                }

                string sql = "UPDATE tb_livro SET Assunto='" + txt_assunto.Text + "'" + "WHERE Turno='" + turno + "'" + "AND Data='" + data + "'";
                cn.Update(sql);
                MessageBox.Show("Dados atualizado com sucesso!");
                txt_assunto.Clear();
                txt_operador.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar informações! " + "\n" + ex.Message);
                cn.desconectar();
            }
            finally { cn.desconectar(); }
            opt_editar.Checked = false;
        }

        private void opt_editar_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_editar.Checked == true)
            {
                string turno;
                btn_enviar.Enabled = false;
                btn_editar_relato.Enabled = true;

                if (this.Text == "Um Òtimo Trabalho para o turno 'A'")
                {
                    turno = "A";
                }
                else if (this.Text == "Um Òtimo Trabalho para o turno 'B'")
                {
                    turno = "B";
                }
                else
                {
                    turno = "C";
                }

                txtdata_relato.Text = DateTime.Now.ToString("yyyy/MM/ddSS");
                string sql = "SELECT Assunto, Operador, Turno FROM tb_livro WHERE Turno ='" + turno + "'" + " AND Data =" + "'" + txtdata_relato.Text + "'";
                Conexao_banco cn = new Conexao_banco();

                try
                {
                    cn.Buscar_assunto(sql);
                    this.txt_assunto.Text = cn.assunto;
                    this.txt_operador.Text = cn.operador;
                    this.txt_turno.Text = cn.turno;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar os dados" + ex.Message);
                    cn.desconectar();
                }
                finally
                {
                    cn.desconectar();
                    txt_turno.Text = turno;
                }
            }
            else if (opt_editar.Checked == false)
            {
                btn_enviar.Enabled = true;
                btn_editar_relato.Enabled = false;
                txt_assunto.Clear(); txt_operador.Clear();
            }


        }

        private void btn_enviar_email_Click(object sender, EventArgs e)
        {
            /*
            // vamos instaciar nossa class de email
            Enviar_email email = new Enviar_email();
            try
            {
                //verificando os campos se estão vazios
                if (this.txt_assunto.Text == "" || this.txt_operador.Text == "" || this.txt_turno.Text == "")
                {
                    MessageBox.Show("Existe campos vazios", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                email.textoBody = this.txt_assunto.Text;
                email.tituloSubject = "Você Acaba de receber o relatório referente ao turno: " + this.txt_turno.Text;

                // enviamos o email
                email.Enviar_emial();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
    }
}
