// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Data.OleDb;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Windows.Forms;
//
// namespace A1
// {
//
//     public partial class Form1 : Form
//
//
//     {
//         public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=a.mdb;";
//         private OleDbConnection myConnection;
//
//         public Form1()
//         {
//
//             myConnection = new OleDbConnection(connectString);
//
//             myConnection.Open();
//
//             InitializeComponent();
//         }
//
//
//
//
//
//         private void Form1_Load(object sender, EventArgs e)
//         {
//
//         }
//
//         private void button1_Click(object sender, EventArgs e)
//         {
//             string query = "SELECT w_name FROM Worker WHERE w_id = 1";
//
//             OleDbCommand command = new OleDbCommand(query, myConnection);
//
//             textBox1.Text = command.ExecuteScalar().ToString();
//
//             Console.WriteLine(textBox1.Text);
//
//         }
//
//         private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//         {
//             myConnection.Close();
//         }
//
//         private void button2_Click(object sender, EventArgs e)
//         {
//             string query = "SELECT w_name, w_position, w_salary FROM Worker ORDER BY w_salary";
//
//             OleDbCommand command = new OleDbCommand(query, myConnection);
//
//             OleDbDataReader reader = command.ExecuteReader();
//
//             listBox1.Items.Clear();
//
//             while (reader.Read())
//             {
//                 listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
//             }
//
//             reader.Close();
//
//         }
//
//         private void button3_Click(object sender, EventArgs e)
//         {
//             string query = "INSERT INTO Worker (w_name, w_position, w_salary) VALUES ('Михаил', 'Водитель', 20000)";
//
//             OleDbCommand command = new OleDbCommand(query, myConnection);
//             command.ExecuteNonQuery();
//
//         }
//
//         private void button4_Click(object sender, EventArgs e)
//         {
//             string query = "UPDATE Worker SET w_salary = 123456 WHERE w_id = 3";
//
//             OleDbCommand command = new OleDbCommand(query, myConnection);
//             command.ExecuteNonQuery();
//
//         }
//
//         private void button5_Click(object sender, EventArgs e)
//         {
//             string query = "DELETE FROM Worker WHERE w_id < 3";
//
//             OleDbCommand command = new OleDbCommand(query, myConnection);
//             command.ExecuteNonQuery();
//
//         }
//     }
// }
