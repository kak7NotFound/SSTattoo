using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSTattoo
{
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            if (AddReceptionForm.isOpen) return;
            var a = new AddReceptionForm();
            a.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ReceptionCloseForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ReceptionsEditorForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }
    }
}