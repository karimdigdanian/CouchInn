using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace libcCouchin.Clases
{
    public class Correo
    {

        MailMessage  correos= new MailMessage();
        SmtpClient envios = new SmtpClient();

        public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
            correos.To.Clear();
            correos.Body = "";
            correos.Subject = "";
            correos.Body = mensaje;
            correos.Subject = asunto;
            correos.IsBodyHtml = true;
            correos.To.Add(destinatario.Trim());

            if(ruta.Equals("")==false)
            {
                System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                correos.Attachments.Add(archivo);
            }

            correos.From = new MailAddress(emisor);
            envios.Credentials = new NetworkCredential(emisor, password);

            //Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com";
            envios.Port = 587;
            envios.EnableSsl = true;

            envios.Send(correos);
            MessageBox.Show("El mensaje fue enviado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void enviarCorreo(string mensaje, string destinatario)
        {
            try
            {
                mensaje = "Hola! \n " + "Esta es tu nueva contreseña para accerder al sitio, " + mensaje + " podras modificarla cuando quieras en las opciones de tu perfil de usuario."  ;
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = "Recuperacion de contraseña";
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());

                correos.From = new MailAddress("couchinn.arg@gmail.com");
                envios.Credentials = new NetworkCredential("couchinn.arg@gmail.com", "ingenieria2016");

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                MessageBox.Show("La nueva contraseña ya se ha enviado a tu mail, verifica tu bandeja de entrada.", "Recuperacion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
