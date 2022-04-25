﻿using System;
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
            refreshCombobox();
        }

        public void refreshCombobox()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.database.ExecuteNonQuery($"delete from Receptions where instr(date, '{comboBox1.Text}') < 0.1 and instr(customer, '{comboBox1.Text}') < 0.1");
        }
    }
}