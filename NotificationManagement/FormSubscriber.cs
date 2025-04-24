using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotificationManagement.Publisher;

namespace NotificationManagement
{
    public partial class Subscriber : Form
    {
        public delegate void SubscribeEventHandler();
        public SubscribeEventHandler? subscribeEvent = null;

        private Publisher publisher;
        private Dictionary<string, SendViaEmail> listSendViaEmails;
        private Dictionary<string, SendViaSMS> listSendViaSMS;

        public Subscriber(Publisher publisher)
        {
            InitializeComponent();
            listSendViaEmails = new Dictionary<string, SendViaEmail>();
            listSendViaSMS = new Dictionary<string, SendViaSMS>();
            this.publisher = publisher;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (!chkSentByEmail.Checked && !chkSentBySMS.Checked)
            {
                MessageBox.Show("Please choose Notification by Email or/and by SMS!");
                return;
            }

            string email = txtEmail.Text.Trim();
            if (chkSentByEmail.Checked)
            {
                if (!IsValidEmail(email))
                {
                    lblEmailError.Visible = true;
                    return; // Stop processing if invalid
                }
                else
                {
                    lblEmailError.Visible = false;
                    if (listSendViaEmails.ContainsKey(email))
                    {
                        MessageBox.Show($"Failed to subscribe because {email} was already subscribed");
                        return;
                    }
                    else
                    {
                        SendViaEmail sendViaEmail = new SendViaEmail(email);
                        sendViaEmail.Subscribe(publisher);
                        listSendViaEmails.Add(email, sendViaEmail);

                        if (listSendViaSMS.Count == 0 && listSendViaEmails.Count == 1)
                        {
                            //Nofity btnPublish to change enabled property
                            subscribeEvent?.Invoke();
                        }

                        MessageBox.Show("Succesfully subscribe Email address: " + email);
                    }
                }
            }

            // If SMS checkbox is checked, validate if the Mask is fully filled
            string phone = mtbPhone.Text.Trim();
            if (chkSentBySMS.Checked)
            {
                if (!mtbPhone.MaskFull)
                {
                    lblPhoneError.Visible = true;
                    return;
                }
                else
                {
                    lblPhoneError.Visible = false;
                    if (listSendViaSMS.ContainsKey(phone))
                    {
                        MessageBox.Show($"Failed to subscribe because {phone} was already subscribed");
                        return;
                    }
                    else
                    {
                        SendViaSMS sendViaSMS = new SendViaSMS(phone);
                        sendViaSMS.Subscribe(publisher);
                        listSendViaSMS.Add(phone, sendViaSMS);

                        if (listSendViaSMS.Count == 1 && listSendViaEmails.Count == 0)
                        {
                            //Nofity btnPublish to change enabled property
                            subscribeEvent?.Invoke();
                        }

                        MessageBox.Show("Succesfully subscribe Phone number: " + phone);
                    }
                }
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            if (!chkSentByEmail.Checked && !chkSentBySMS.Checked)
            {
                MessageBox.Show("Please choose Notification by Email or/and by SMS!");
                return;
            }

            string email = txtEmail.Text.Trim();
            if (chkSentByEmail.Checked)
            {
                if (!IsValidEmail(email))
                {
                    lblEmailError.Visible = true;
                    return; // Stop processing if invalid
                }
                else
                {
                    lblEmailError.Visible = false;
                    if (!listSendViaEmails.ContainsKey(email))
                    {
                        MessageBox.Show($"Failed to Unsubscribe because {email} was Not Subscribed");
                        return;
                    }
                    else
                    {
                        SendViaEmail sendViaEmail = listSendViaEmails[email];
                        sendViaEmail.Unsubscribe(publisher);

                        listSendViaEmails.Remove(email);

                        //Nofity btnPublish to change enabled property
                        if (listSendViaSMS.Count == 0 && listSendViaEmails.Count == 0)
                        {
                            subscribeEvent?.Invoke();
                        }

                        MessageBox.Show("Succesfully Unsubscribe Email address: " + email);
                    }
                }
            }

            // If SMS checkbox is checked, validate if the Mask is fully filled
            string phone = mtbPhone.Text.Trim();
            if (chkSentBySMS.Checked)
            {
                if (!mtbPhone.MaskFull)
                {
                    lblPhoneError.Visible = true;
                    return;
                }
                else
                {
                    lblPhoneError.Visible = false;
                    if (!listSendViaSMS.ContainsKey(phone))
                    {
                        MessageBox.Show($"Failed to Unsubscribe because {phone} was Not Subscribed");
                        return;
                    }
                    else
                    {
                        SendViaSMS sendViaSMS = listSendViaSMS[phone];
                        sendViaSMS.Unsubscribe(publisher);

                        listSendViaSMS.Remove(phone);

                        //Nofity btnPublish to change enabled property
                        if (listSendViaSMS.Count == 0 && listSendViaEmails.Count == 0)
                        {
                            subscribeEvent?.Invoke();
                        }

                        MessageBox.Show("Succesfully Unsubscribe Phone number: " + phone);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chkSentByEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = chkSentByEmail.Checked;
            lblEmailError.Visible = false;
        }

        private void chkSentBySMS_CheckedChanged(object sender, EventArgs e)
        {
            mtbPhone.Enabled = chkSentBySMS.Checked;
            lblPhoneError.Visible = false;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Subscriber_Shown(object sender, EventArgs e)
        {
            lblEmailError.Visible = false;
            lblPhoneError.Visible = false;
        }
    }
}
