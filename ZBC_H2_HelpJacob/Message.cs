using System;
using System.Collections.Generic;
using System.Text;
using ZBC_H2_HelpJacob.Interfaces;

namespace ZBC_H2_HelpJacob
{
    public class Message
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }


        public Message(string to, string from, string body, string subject, string cc)
        {
            this.To = to;
            this.From = from;
            this.Body = body;
            this.Subject = subject;
            this.Cc = cc;
        }

        public void ConvertBodyToHtml()
        {
            Body = "" + Body + "";
        }
    }
}
