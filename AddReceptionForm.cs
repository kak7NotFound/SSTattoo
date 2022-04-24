using System;
using System.Collections.Generic;
using System.Linq;
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

            using (var reader = Program.database.GetReader("select title from Tattoos"))
            {
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

                this.comboBox1.Items.AddRange(list.Cast<object>().ToArray());
            }
            
            using (var reader = Program.database.GetReader("select name from Workers"))
            {
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

                this.comboBox3.Items.AddRange(list.Cast<object>().ToArray());
            }

            refreshComboBox2();
        }

        private void refreshComboBox2()
        {
            comboBox2.ResetText();
            comboBox2.Items.Clear();
            textBox2.Clear();


            using (var reader = Program.database.GetReader("select name from Customers"))
            {
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }

                this.comboBox2.Items.AddRange(list.Cast<object>().ToArray());
            }
        }

        private void AddReceptionForm_Load(object sender, EventArgs e)
        {
        }

        private void AddReceptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (var reader =
                   Program.database.GetReader($"select price from Tattoos where title = '{comboBox1.Text}'"))
            {
                reader.Read();
                textBox1.ResetText();
                textBox1.Text = reader.GetInt32(0) + "";
                textBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.database.ExecuteNonQuery(
                $"insert into Customers (name, phoneNumber) values ('{comboBox2.Text}', '{textBox2.Text}')");
            refreshComboBox2();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var reader =
                   Program.database.GetReader($"select phoneNumber from Customers where name = '{comboBox2.Text}'"))
            {
                reader.Read();
                textBox2.ResetText();
                textBox2.Text = reader.GetString(0) + "";
                textBox2.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.database.ExecuteNonQuery($"delete from Customers where name = '{comboBox2.Text}'");
            comboBox2.ResetText();
            textBox2.ResetText();
            refreshComboBox2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dt = dateTimePicker1.Value;
            Program.database.ExecuteNonQuery(
                $"insert into Receptions (date, customer, workerName, tattoo) values ('{comboBox4.Text} {dt.Day}.{dt.Month}.{dt.Year}','{comboBox2.Text}','{comboBox3.Text}', '{comboBox1.Text}')");
        }
        
    }
}