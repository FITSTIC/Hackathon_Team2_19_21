using MailKit.Net.Smtp;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MimeKit;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Features.Messaging
{
    public class MessageService : IMessageService
    {
        public async Task SendEmailAsync(
            string fromDisplayName, 
            string fromEmailAddress, 
            string toName, 
            string toEmailAdrress, 
            string subject, 
            string message)
            
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(fromDisplayName, fromEmailAddress));
            email.To.Add(new MailboxAddress(toName, toEmailAdrress));
            email.Subject = subject;
            

            var body = new BodyBuilder
            {
                HtmlBody = message
            };

            email.Body = body.ToMessageBody();
            

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback =
                    (sender, certificate, certChainType, errors) => true;
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                await client.ConnectAsync("smtp.gmail.com", 587, false).ConfigureAwait(false);
                await client.AuthenticateAsync("vetricini.fabio@gmail.com", "011088Fa").ConfigureAwait(false);
                await client.SendAsync(email).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }            
        }
        
    }
}
