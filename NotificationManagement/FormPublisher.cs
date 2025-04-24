using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagement
{
    public partial class Publisher : Form
    {
        public delegate void PublishNotificationDel(string notification);

        public PublishNotificationDel? pubNotificationDel = null;

        public Publisher()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string notification = txtNotificationContent.Text;
            if (string.IsNullOrWhiteSpace(notification))
            {
                MessageBox.Show("Please enter the effective notification content!");
                return;
            }
            PublishNotification(notification);
        }

        private void PublishNotification(string notification)
        {
            if (pubNotificationDel != null)
            {
                pubNotificationDel.Invoke(notification);
            }
        }
    }
}
