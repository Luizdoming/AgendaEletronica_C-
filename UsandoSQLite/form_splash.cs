using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsandoSQLite
{
    public partial class form_splash : Form
    {
        public form_splash()
        {
            InitializeComponent();
            time_splash.Enabled = true;
        }

        //int progrees = 0;
        private void form_splash_Load(object sender, EventArgs e)
        {
            //timer1.Start(); // iniciar o timer 
        }

        private void time_splash_Tick(object sender, EventArgs e)
        {
            guna_progres.Increment(1);// incrementando o valor da ciclobar de 1 em 1
            int valor = 0;
            valor += guna_progres.Value;

            label1.Text = "Iniciando o sistema..." + " " + valor + " %";

            if (guna_progres.Value == 100) // se o valor for maior que 100
            {
                this.Close();
                //form_login fr = new form_login();
                Thread t = new Thread(() => Application.Run(new form_login()));
                time_splash.Stop();
                time_splash.Enabled = false;
                t.Start();
                //this.Hide();
                //fr.Show();
            }
        }
    }
}
