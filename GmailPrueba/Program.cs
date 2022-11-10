using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GmailPrieba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui van los gmail de origen y destinos y el de origen con sus credenciales
            string EmailOrigen = "lt0895032020@unab.edu.sv";
            string Contraseña = "alvarounab1";
            string EmailDestino = "alvaro25lopez03@gmail.com";
            string usuario = "Alvaro";
            string titulo = "Hola "+ usuario+ "Este es un correo de prueba";
            
            
            //Este es el mensaje que se enviara
            MailMessage mailMessagea = new MailMessage(EmailOrigen, EmailDestino, titulo, "Prube");
            //En caso de que el mensaje lleve formato html esto lo habilita
            mailMessagea.IsBodyHtml = true;
            //Coneccion al servicio smtp de gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //Conexion a dicho servicio y habilitacion con credenciales
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);
            //mandar el mensaje
            smtpClient.Send(mailMessagea);
            //cerrar 
            smtpClient.Dispose();

        }
    }
}
