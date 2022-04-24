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
            List<string> nameList = new List<string>();

            using (var reader = Program.database.GetReader("select customer and date from Receptions"))
            {
                while (reader.Read())
                {
                    nameList.Add(reader.GetString(0));
                }
            }
            
            this.comboBox1.Items.AddRange(nameList.Cast<object>().ToArray());

            
        }
    }
}