using System.Windows.Forms;

namespace NotificationManagement
{
    public partial class frmNotificationManager : Form
    {
        private Publisher? publisher;
        private Subscriber? subscriber;

        public frmNotificationManager()
        {
            InitializeComponent();
            publisher = new Publisher();
            subscriber = new Subscriber(publisher);
            subscriber.subscribeEvent += HandleSubscribe;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubscriber_Click(object sender, EventArgs e)
        {
            subscriber!.ShowDialog();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            publisher!.ShowDialog();
        }

        public void HandleSubscribe()
        {
            btnPublisher.Enabled = !btnPublisher.Enabled;
        }
    }
}
