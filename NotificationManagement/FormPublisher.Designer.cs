namespace NotificationManagement
{
    partial class Publisher
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
            lblNotificationContent = new Label();
            txtNotificationContent = new TextBox();
            btnPublish = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblNotificationContent
            // 
            lblNotificationContent.AutoSize = true;
            lblNotificationContent.Location = new Point(75, 67);
            lblNotificationContent.Name = "lblNotificationContent";
            lblNotificationContent.Size = new Size(166, 23);
            lblNotificationContent.TabIndex = 0;
            lblNotificationContent.Text = "Notification Content";
            // 
            // txtNotificationContent
            // 
            txtNotificationContent.Location = new Point(263, 63);
            txtNotificationContent.Name = "txtNotificationContent";
            txtNotificationContent.Size = new Size(319, 30);
            txtNotificationContent.TabIndex = 1;
            // 
            // btnPublish
            // 
            btnPublish.Location = new Point(149, 154);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(122, 47);
            btnPublish.TabIndex = 2;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(369, 154);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmPublisher
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 260);
            Controls.Add(btnExit);
            Controls.Add(btnPublish);
            Controls.Add(txtNotificationContent);
            Controls.Add(lblNotificationContent);
            Font = new Font("Segoe UI", 10F);
            Name = "frmPublisher";
            Text = "Publish Notification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNotificationContent;
        private TextBox txtNotificationContent;
        private Button btnPublish;
        private Button btnExit;
    }
}