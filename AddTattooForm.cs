using System;
using System.Threading;
using System.Windows.Forms;

namespace SSTattoo;

public partial class AddTattooForm : Form
{
    public AddTattooForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Program.database.ExecuteNonQuery(
            $"insert into Tattoos (title, price) VALUES ('{this.textBox1.Text}', {this.numericUpDown1.Value})");
    }

}