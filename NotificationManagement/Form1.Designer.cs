namespace NotificationManagement
{
    partial class frmNotificationManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubscriber = new Button();
            btnPublisher = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSubscriber
            // 
            btnSubscriber.Font = new Font("Segoe UI", 11F);
            btnSubscriber.Location = new Point(70, 104);
            btnSubscriber.Name = "btnSubscriber";
            btnSubscriber.Size = new Size(237, 86);
            btnSubscriber.TabIndex = 0;
            btnSubscriber.Text = "Manage Subscription";
            btnSubscriber.UseVisualStyleBackColor = true;
            btnSubscriber.Click += btnSubscriber_Click;
            // 
            // btnPublisher
            // 
            btnPublisher.Enabled = false;
            btnPublisher.Font = new Font("Segoe UI", 11F);
            btnPublisher.Location = new Point(361, 104);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(243, 86);
            btnPublisher.TabIndex = 1;
            btnPublisher.Text = "Publish Notification";
            btnPublisher.UseVisualStyleBackColor = true;
            btnPublisher.Click += btnPublisher_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.Location = new Point(659, 104);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 86);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmNotificationManager
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 288);
            Controls.Add(btnExit);
            Controls.Add(btnPublisher);
            Controls.Add(btnSubscriber);
            Font = new Font("Segoe UI", 10F);
            Name = "frmNotificationManager";
            Text = "Notification Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubscriber;
        private Button btnPublisher;
        private Button btnExit;
    }
}
