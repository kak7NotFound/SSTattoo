using System;
using System.Windows.Forms;

namespace SSTattoo;

public partial class AddWorkerForm : Form
{
    public AddWorkerForm()
    {
        InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Program.database.ExecuteNonQuery(
            $"insert into Workers (name, phoneNumber, position, salary) VALUES ('{this.textBox1.Text}', '{this.textBox3.Text}', '{this.textBox2.Text}', {this.numericUpDown1.Value})");
    }
}