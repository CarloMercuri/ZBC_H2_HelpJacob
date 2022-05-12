using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_HelpJacob.Interfaces
{
    public interface IMessageDelivery
    {
        void SendMessage(Message message);
        void SendToAll(Message message);
    }
}
