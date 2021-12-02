using System;
using MySql.Data.MySqlClient;

namespace EuroData.Classes.Helper
{
    public class DatabaseHelper
    {
        private string connectionString = "server=localhost;uid=root;" +
                                          "password=root;database=db_euro_data";

        private MySqlConnection dbCon;
        private MySqlCommand dbCommand;
        
        public DatabaseHelper(string connectionString = null)
        {
            if (connectionString != null)
            {
                this.connectionString = connectionString;
            }
            dbCon = new MySqlConnection(connectionString);
            dbCommand = dbCon.CreateCommand();
        }
    }
}