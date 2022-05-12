using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_HelpJacob.Interfaces
{
    public class SMTPDelivery : IMessageDelivery
    {
        public void SendMessage(Message message)
        {
            // Send with SMTP
        }

        public void SendToAll(Message message)
        {
            // Send with SMTP to all
        }
    }
}
