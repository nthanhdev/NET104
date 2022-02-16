
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
namespace ASMMAIN.Services { 


    public class MailSettings { 
        
        public string Mail { get; set;} // email của bạn 
        
        public string DisPlayName {get; set;} // tên hiển thị 

        public string Password {get ;set; } // mật khẩu email 

        public string Host { get; set;} // host của email 

        public int Port { get;set; } // port của email 
    }


    public class SendMailServices : IEmailSender{
        public SendMailServices(IOptions<MailSettings> mailSettings)
        {
            this.mailSettings = mailSettings.Value;
        }

        public MailSettings mailSettings {set;get;}

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.Sender = new MailboxAddress(mailSettings.DisPlayName , mailSettings.Mail);
            message.From.Add(new MailboxAddress(mailSettings.DisPlayName , mailSettings.Mail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = subject;
             BodyBuilder builder = new BodyBuilder(){
                HtmlBody = htmlMessage

            };
            message.Body = builder.ToMessageBody();

            try{
             using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(mailSettings.Host , mailSettings.Port , MailKit.Security.SecureSocketOptions.StartTls); 
            await smtp.AuthenticateAsync(mailSettings.Mail , mailSettings.Password);
            await smtp.SendAsync(message);
            smtp.Disconnect(true);
          
            }catch(Exception e){ 
                Console.WriteLine(e.Message);
                
            }
         
        }


        
    }

}