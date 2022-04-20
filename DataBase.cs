using System;
using System.Data.OleDb;

namespace SSTattoo
{
    public class DataBase
    {
        
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\kaks\\Desktop\\a.accdb;";

        public DataBase()
        {
            var myConnection = new OleDbConnection(connectString);

            myConnection.Open();
            
            string query = "SELECT * FROM Customers";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();
            command.ExecuteNonQuery();

            Console.Write(reader);
            
            reader.Close();
            
        }
    }
}