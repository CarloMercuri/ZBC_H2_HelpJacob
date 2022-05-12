using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_HelpJacob.Interfaces;

namespace ZBC_H2_HelpJacob
{
    public class MessageControl
    {
        public Message CreateMessage(string to, string from, string body, string subject, string cc)
        {
            return new Message(to, from, body, subject, cc);     
        }

        public void SendMessageSmtp(Message m, bool isHTML)
        {
            SendMessage(new SMTPDelivery(), m, isHTML);
        }

        public void SendMessageToAllSmtp(Message m, bool isHTML)
        {
            SendMessageToAll(new SMTPDelivery(), m, isHTML);
        }

        public void SendMessageVM(Message m, bool isHTML)
        {
            SendMessage(new VMDelivery(), m, isHTML);
        }

        public void SendMessageToAllVM(Message m, bool isHTML)
        {
            SendMessageToAll(new VMDelivery(), m, isHTML);
        }

        private void SendMessage(IMessageDelivery delivery, Message m, bool isHTML)
        {
            if (isHTML) m.ConvertBodyToHtml();

            delivery.SendMessage(m);
        }

        private void SendMessageToAll(IMessageDelivery delivery, Message m, bool isHTML)
        {
            if (isHTML) m.ConvertBodyToHtml();

            delivery.SendToAll(m);
        }
    }
}
