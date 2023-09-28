using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace UsandoSQLite
{
    class Enviar_email
    {
               
        public string emailFrom { get; set; }       // o e-email de quem vai enviar
        public string emailTo { get; set; }         // o e-mail de quem ira receber
        public string textoBody { get; set; }       // o texto que irá conter no corpo do e-mail
        public string tituloSubject { get; set; }   // o titulo do e-mail


        // Instanciar oa objetos para envio do e-mail
        public SmtpClient cliente = new SmtpClient();
        public NetworkCredential credencial = new NetworkCredential();

        public void Enviar_emial()
        {
            // Definir as configurações do cliente
            // cliente.Host = "smtp.gmail.com";
            // cliente.Host = "smtp.outlook";
            cliente.Host = "smtp.Outlook.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            // Definir as credencias do usuario
            credencial.UserName = "luiz silva";
            credencial.Password = "luiz270815";

            // Atribuir as credenciais para o cliente
            cliente.Credentials = credencial;

            // Preparar o envio do e-mail
            MailMessage email = new MailMessage();
            email.From = new MailAddress("luiz4713@outlook.com");
            email.Subject = tituloSubject;
            email.Body = textoBody;
            email.To.Add("luiz4713@outlook.com");

            // por fim enviamos o e-mail
            cliente.Send(email);

        }


    }
}
