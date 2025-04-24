using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagement
{
    internal class SendViaSMS
    {
        private string phoneNumber;

        public SendViaSMS(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void SendSMS(string notification)
        {
            //TBD - Send SMS to phoneNumber
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.pubNotificationDel += SendSMS;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.pubNotificationDel -= SendSMS;
        }
    }
}
