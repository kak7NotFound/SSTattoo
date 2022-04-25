using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace SSTattoo
{
    public class DataBase : DbContext
    {
        private SqliteConnection connection =
            new SqliteConnection("Data Source=C:\\Users\\kak7\\Documents\\GitHub\\SSTattoo\\mainDatabase.sqlite");

        public DataBase()
        {
            connection.Open();
        }

        public SqliteDataReader GetReader(string cmdText)
        {
            var command = connection.CreateCommand();
            command.CommandText = cmdText;

            return command.ExecuteReader();
        }

        public void ExecuteNonQuery(string cmdText)
        {
            var command = connection.CreateCommand();
            command.CommandText = cmdText;
            command.ExecuteNonQuery();
        }
    }
}