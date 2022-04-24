using System;
using System.Windows.Forms;

namespace SSTattoo
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddTattooForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddWorkerForm().Show();
        }
    }
}