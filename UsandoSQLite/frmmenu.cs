using System;
using System.Threading;
using System.Windows.Forms;

namespace UsandoSQLite
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            timer1.Start();
            lbl_nivel.Visible = false;
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            lbl_nivel.Text = this.Text;
            guna2CircleProgressBar1.Animated = true;
            guna2CircleProgressBar2.Animated = true;
            this.lbl_turno.Visible = false;
            tempo();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.lbl_relogio.Text = DateTime.Now.ToString("dddd, dd - MMM - yyyy  HH:mm:ss tt");
            //string data = $"{DateTime.Now:F}";
            this.lbl_relogio.Text = Convert.ToString($"{DateTime.Now:F}");
            VerificarTempo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Deseja encerrar o sistema?", "Aviso!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    return;
            //}
        }

        private void tempo()
        {
            DateTime time = DateTime.Now;

            if (time.Hour >= DateTime.Parse("05:30").Hour && time.Hour < DateTime.Parse("13:50").Hour)
            {
                this.lbl_turno.Text = "Um Òtimo Trabalho para o turno 'A'";
            }
            else if (time.Hour >= DateTime.Parse("13:50").Hour && time.Hour < DateTime.Parse("22:10").Hour)
            {
                this.lbl_turno.Text = "Um Òtimo Trabalho para o turno 'B'";
            }
            else
            {
                this.lbl_turno.Text = "Um Òtimo Trabalho para o turno 'C'";
            }

        }

        private void VerificarTempo()
        {
            var tempo = TimeSpan.Parse(DateTime.Now.ToShortTimeString());

            if (this.lbl_turno.Text == "Um Òtimo Trabalho para o turno 'A'")
            {
                if (tempo >= TimeSpan.Parse("13:10"))
                {
                    this.Close();
                    Thread t = new Thread(() => Application.Run(new form_login()));
                    t.Start();
                }
            }
            else if (this.lbl_turno.Text == "Um Òtimo Trabalho para o turno 'B'")
            {
                if (tempo >= TimeSpan.Parse("22:10"))
                {
                    this.Close();
                    Thread t = new Thread(() => Application.Run(new form_login()));
                    t.Start();
                }
            }
            else if (this.lbl_turno.Text == "Um Òtimo Trabalho para o turno 'C'")
            {
                if (tempo == TimeSpan.Parse("05:30"))
                {
                    this.Close();
                    Thread t = new Thread(() => Application.Run(new form_login()));
                    t.Start();
                }
            }
        }

        private void frmmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            // para ocultar a janela do formulario Muno - usamos o comando aseguir
            // this.Hide(); não é recomendado usar este metodo - aforma adquada seria 
            // o comando aseguir - usando threading 
            // importamos o name space -> using system.threading

            string nivel = "Admin";

            if (lbl_nivel.Text != nivel)
            {
                MessageBox.Show("Permição negada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (frm_cadusuario frm = new frm_cadusuario())
                {
                    frm.ShowDialog();
                }
            }

        }

        private void tbn_relatorio_Click(object sender, EventArgs e)
        {
            if (lbl_nivel.Text != "")
            {
                frm_livro fr = new frm_livro();
                fr.Text = lbl_turno.Text;
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existe usuário logado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (this.lbl_nivel.Text != "")
            {
                if (this.lbl_nivel.Text == "Admin")
                {
                    using (Frm_Admin fr = new Frm_Admin())
                    {
                        fr.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário sem permição!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        /*
        private void Escolher_print()
        {
        //Primeiro limpamos nossa combobox
        comboprint.Items.Clear();

        //Loop para adcionar todas as impressoras instalada dentro da nossa combobox
        foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
        {
           comboprint.Items.Add(impressora);
        }
        }
        */
    }
}
