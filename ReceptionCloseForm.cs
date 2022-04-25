using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SSTattoo
{
    public partial class ReceptionCloseForm : Form
    {
        public ReceptionCloseForm()
        {
            InitializeComponent();
            refreshComboBox1();
        }

        private void refreshComboBox1()
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Refresh();
            
            List<string> nameList = new List<string>();

            using (var reader = Program.database.GetReader("select customer, Receptions.date from Receptions"))
            {
                while (reader.Read())
                {
                    nameList.Add(reader.GetString(0) + " " + reader.GetString(1));
                }
            }
            
            comboBox1.Items.AddRange(nameList.Cast<object>().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.database.ExecuteNonQuery($"delete from Receptions where instr('{comboBox1.Text}', date) > 0.9");
            refreshComboBox1();
        }
        
    }
}