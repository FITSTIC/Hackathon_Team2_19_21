using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Features.Messaging
{
    public interface IMessageService
    {
        Task SendEmailAsync(
                string fromDisplayName,
                string fromEmailAddress,
                string toName,
                string toEmailAddress,
                string subject,
                string message);                
    }
}
