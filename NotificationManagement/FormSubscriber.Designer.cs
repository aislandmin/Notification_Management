namespace NotificationManagement
{
    partial class Subscriber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkSentByEmail = new CheckBox();
            chkSentBySMS = new CheckBox();
            txtEmail = new TextBox();
            btnSubscribe = new Button();
            btnUnsubscribe = new Button();
            btnCancel = new Button();
            mtbPhone = new MaskedTextBox();
            lblEmailError = new Label();
            lblPhoneError = new Label();
            SuspendLayout();
            // 
            // chkSentByEmail
            // 
            chkSentByEmail.AutoSize = true;
            chkSentByEmail.Checked = true;
            chkSentByEmail.CheckState = CheckState.Checked;
            chkSentByEmail.Location = new Point(105, 65);
            chkSentByEmail.Name = "chkSentByEmail";
            chkSentByEmail.Size = new Size(229, 27);
            chkSentByEmail.TabIndex = 0;
            chkSentByEmail.Text = "Notification Sent by Email";
            chkSentByEmail.UseVisualStyleBackColor = true;
            chkSentByEmail.CheckedChanged += chkSentByEmail_CheckedChanged;
            // 
            // chkSentBySMS
            // 
            chkSentBySMS.AutoSize = true;
            chkSentBySMS.Location = new Point(105, 151);
            chkSentBySMS.Name = "chkSentBySMS";
            chkSentBySMS.Size = new Size(221, 27);
            chkSentBySMS.TabIndex = 1;
            chkSentBySMS.Text = "Notification Sent by SMS";
            chkSentBySMS.UseVisualStyleBackColor = true;
            chkSentBySMS.CheckedChanged += chkSentBySMS_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(357, 61);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 30);
            txtEmail.TabIndex = 2;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(138, 257);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(122, 41);
            btnSubscribe.TabIndex = 4;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(292, 257);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(122, 41);
            btnUnsubscribe.TabIndex = 5;
            btnUnsubscribe.Text = "Unsubscribe";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubscribe_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(448, 257);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 41);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // mtbPhone
            // 
            mtbPhone.Enabled = false;
            mtbPhone.Location = new Point(356, 148);
            mtbPhone.Mask = "000-000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.PromptChar = 'x';
            mtbPhone.Size = new Size(254, 30);
            mtbPhone.TabIndex = 7;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(356, 110);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(171, 23);
            lblEmailError.TabIndex = 8;
            lblEmailError.Text = "Invalid Email Address";
            lblEmailError.Visible = false;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(356, 197);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(182, 23);
            lblPhoneError.TabIndex = 9;
            lblPhoneError.Text = "Invalid Phone Number";
            lblPhoneError.Visible = false;
            // 
            // Subscriber
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 364);
            Controls.Add(lblPhoneError);
            Controls.Add(lblEmailError);
            Controls.Add(mtbPhone);
            Controls.Add(btnCancel);
            Controls.Add(btnUnsubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(txtEmail);
            Controls.Add(chkSentBySMS);
            Controls.Add(chkSentByEmail);
            Font = new Font("Segoe UI", 10F);
            Name = "Subscriber";
            Text = "Manage Subscription";
            Shown += Subscriber_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSentByEmail;
        private CheckBox chkSentBySMS;
        private TextBox txtEmail;
        private Button btnSubscribe;
        private Button btnUnsubscribe;
        private Button btnCancel;
        private MaskedTextBox mtbPhone;
        private Label lblEmailError;
        private Label lblPhoneError;
    }
}