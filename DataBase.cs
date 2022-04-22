using System;
using System.Data.OleDb;
using Microsoft.Data.Sqlite;

namespace SSTattoo
{
    public class DataBase
    {
        public DataBase()
        {
            using (var connection = new SqliteConnection("Data Source=mainDatabase.sqlite"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    @"
        SELECT lastName
        FROM Workers
        WHERE id = 0
    ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);

                        Console.WriteLine($"Hello, {name}!");
                    }
                }
            }
        }

        public void GetResult(string cmdText)
        {
        }

        public void ExecuteQuery()
        {
        }
    }
}