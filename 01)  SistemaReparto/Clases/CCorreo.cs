using System;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Windows.Forms;
namespace SistemaReparto.Clases
{
    internal class CCorreo
    {
        private const string CORREO = "norteksolutions.gt@gmail.com";
        private const string PASSWORD = "huzd axno zwzp swif";
        private const string REMITENTE = "Nortek Solutions";

        public bool EnviarCorreo(string destino, string asunto, string mensaje)
        {
            try
            {
                MimeMessage correo = new MimeMessage();

                correo.From.Add(new MailboxAddress(REMITENTE, CORREO));
                correo.To.Add(MailboxAddress.Parse(destino));

                correo.Subject = asunto;

                correo.Body = new TextPart("plain")
                {
                    Text = mensaje
                };

                using (SmtpClient cliente = new SmtpClient())
                {
                    cliente.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    cliente.Authenticate(CORREO, PASSWORD);

                    cliente.Send(correo);

                    cliente.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo.\n\n" + ex.Message);

                return false;
            }
        }
    }
}