using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSTattoo
{
    public partial class ReceptionsEditorForm : Form
    {
        public Dictionary<string, string> savedData = new Dictionary<string, string>();
        public ReceptionsEditorForm()
        {
            InitializeComponent();
            refreshReception();
            fillData();
            fillSavedData();
        }


        public void fillData()
        {
            using (var reader = Program.database.GetReader("select name from Workers"))
            {
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetString(0));
                }
            }
            using (var reader = Program.database.GetReader("select title from Tattoos"))
            {
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString(0));
                }
            }
        }
        
        public void fillSavedData()
        {
            savedData.Add("customer", textBox1.Text);
            savedData.Add("workerName", comboBox3.Text);
        }

        public void refreshReception()
        {
            comboBox1.Items.Clear();
            using (var reader = Program.database.GetReader("select customer, date from Receptions"))
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var reader = Program.database.GetReader($"select * from Receptions"))
            {
                while (reader.Read())
                {
                    if (reader.GetString(1) + " " + reader.GetString(0) == comboBox1.Text)
                    {
                        textBox1.Text = reader.GetString(1);
                        comboBox3.Text = reader.GetString(2);
                        comboBox2.Text = reader.GetString(3);

                        var splitTime = reader.GetString(0).Split(' ');
                        listBox1.Text = splitTime[0];
                        var splitDate = splitTime[1].Split('.');
                        dateTimePicker1.Value = new DateTime(Int32.Parse(splitDate[2]), Int32.Parse(splitDate[1]),
                            Int32.Parse(splitDate[0]));
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = dateTimePicker1.Value;
            Program.database.ExecuteNonQuery($"update Receptions set date = '{listBox1.Text} {dt.Day}.{dt.Month}.{dt.Year}', customer = '{textBox1.Text}', workerName = '{comboBox3.Text}', tattoo = '{comboBox2.Text}' where customer = '{savedData["customer"]}' and workerName = '{savedData["workerName"]}'");
            refreshReception();
        }
    }
}