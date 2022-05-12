using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_HelpJacob.Interfaces
{
    public class VMDelivery : IMessageDelivery
    {
        public void SendMessage(Message message)
        {
            // send with vm
        }

        public void SendToAll(Message message)
        {
            // send with vm to all
        }
    }
}
