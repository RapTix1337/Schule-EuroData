using System;
using System.Collections.Generic;
using System.Data;
using EuroData.Classes.Entities;
using MySql.Data.MySqlClient;

namespace EuroData.Classes.Helper
{
    public class DatabaseHelper
    {
        private string connectionString = "server=localhost;uid=root;" +
                                          "password=root;database=db_euro_data";

        private MySqlConnection dbCon;
        
        public DatabaseHelper(string connectionString = null)
        {
            if (connectionString != null)
            {
                this.connectionString = connectionString;
            }
            dbCon = new MySqlConnection(connectionString);
        }

        public List<Project> genericGetAllProjects(string[] columns, string table)
        {
            MySqlCommand selectProjects = dbCon.CreateCommand();
            selectProjects.CommandType = CommandType.Text;
            selectProjects.CommandText = "SELECT * FROM projekt";
            MySqlDataReader reader = selectProjects.ExecuteReader();
            List<Project> result = new List<Project>();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    result.Add(new Project(
                            reader.GetInt16("ProjNr"),
                            reader.GetString("Bezeichnung"),
                            reader.GetDouble("Auftragswert"),
                            reader.GetDouble("bezahlt"),
                            0,
                            reader.GetDateTime("Beginn"),
                            reader.GetDateTime("Ende"),
                            reader.GetBoolean("Storno")
                        ));

                }
            }
            // ToDo add total hours worked
            return result;
        }
    }
}