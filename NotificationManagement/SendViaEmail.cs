namespace NotificationManagement
{
    internal class SendViaEmail
    {
        private string emailAddr;
        public SendViaEmail(string emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void SendEmail(string notification)
        {
            //TBD - Send Email to emailAddr

            //string emailFrom = "from@gmail.com";
            //string passwordFrom = "password";

            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            //{
            //    Credentials = new NetworkCredential(emailFrom, passwordFrom),
            //    EnableSsl = true
            //};

            //string subject = "From notification management System";
            //string body = notification;
            //MailMessage message = new MailMessage(emailFrom, emailAddr, subject, body);

            //try
            //{
            //    client.Send(message);
            //    MessageBox.Show("Email sent successfully.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error sending email: " + ex.Message);
            //}

        }

        public void Subscribe(Publisher publisher)
        {
            publisher.pubNotificationDel += SendEmail;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.pubNotificationDel -= SendEmail;
        }
    }
}
