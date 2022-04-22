using System;
using System.Windows.Forms;

namespace SSTattoo
{
    public partial class AddReceptionForm : Form
    {
        public static bool isOpen = false;
        public AddReceptionForm()
        {
            isOpen = true;
            InitializeComponent();
        }
        
        private void AddReceptionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddReceptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddReceptionForm.isOpen = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}