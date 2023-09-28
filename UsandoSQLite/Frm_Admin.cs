using System;
using System.Windows.Forms;

namespace UsandoSQLite
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();

            foreach (Control ct in this.Controls)
            {
                if (ct is Guna.UI2.WinForms.Guna2ContainerControl)
                {
                    foreach (Control item in ct.Controls)
                    {
                        if (item is Label)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            this.data_admin.Value = DateTime.Today;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Conexao_banco cn = new Conexao_banco();

            //limpando as label de cada operadores
            lbl_ope_A.Text = string.Empty; lbl_op_B.Text = string.Empty; lbl_op_C.Text = string.Empty;

            //limpar as label dos turnos
            lbl_turno_A.Text = string.Empty; lbl_turno_B.Text = string.Empty; lbl_turno_C.Text = string.Empty;

            //limpando os textos antigos das textbox
            txtA.Clear(); txtB.Clear(); txtC.Clear();

            if (this.data_admin.Text == "")
            {
                guna_msg.Text = "Selecione uma data!";
                guna_msg.Show();
                return;
            }

            try
            {
                string sql = "SELECT Assunto, Operador, Turno FROM tb_livro WHERE Data ='" + this.data_admin.Text + "'";
                cn.Buscar_admin(sql);

                if (cn.operador != null)
                {
                    lbl_ope_A.Text = cn.operador.ToString();
                    lbl_turno_A.Text = cn.turno.ToString();
                    txtA.Text = cn.assunto.ToString();
                }

                if (cn.operador1 != null)
                {
                    lbl_op_B.Text = cn.operador1.ToString();
                    lbl_turno_B.Text = cn.turno1.ToString();
                    txtB.Text = cn.assunto1.ToString();
                }

                if (cn.operador2 != null)
                {
                    lbl_op_C.Text = cn.operador2.ToString();
                    lbl_turno_C.Text = cn.turno2.ToString();
                    txtC.Text = cn.assunto2.ToString();
                }

            }
            catch (Exception ex)
            {
                guna_msg.Text = ex.Message;
                guna_msg.Show();
            }
            finally
            {
                cn.desconectar();
            }

        }

    }
}
