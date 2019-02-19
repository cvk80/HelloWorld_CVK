using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using HelloWorldWebApp.Controllers;

namespace HelloWorld_CVK
{
    class HelloWorld
    {
        static void Main(string[] args)
        {

            String writeLocation = ConfigReader.ReadSetting("WriteLocation");

            switch (writeLocation)
            {
                case "Console":
                    Console.WriteLine("Hello World!");
                    break;
                case "Database":
                    WriteToDatabase(ConfigReader.ReadSetting("DbConnection"), "INSERT INTO [TABLE_NAME] (COLUMN1, COLUMN2, COLUMN3) VALUES (VALUE1, VALUE2, VALUE3);");
                    break;
                default:
                    break;

            }
            
        }

        static void WriteToDatabase(String connectionString, String sqlStatement)
        {

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(sqlStatement, connection);
                connection.Open();
  
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
            }
        }
    }
}
