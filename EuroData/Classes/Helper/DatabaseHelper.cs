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
            MySqlDataReader projectReader = selectProjects.ExecuteReader();
            List<Project> result = new List<Project>();
            if(projectReader.HasRows)
            {
                while (projectReader.Read())
                {
                    result.Add(new Project(
                            projectReader.GetInt16("ProjNr"),
                            projectReader.GetString("Bezeichnung"),
                            projectReader.GetDouble("Auftragswert"),
                            projectReader.GetDouble("bezahlt"),
                            0,
                            projectReader.GetDateTime("Beginn"),
                            projectReader.GetDateTime("Ende"),
                            projectReader.GetBoolean("Storno")
                        ));

                }
            }
            MySqlCommand selectProjectWorkedTime = dbCon.CreateCommand();
            selectProjectWorkedTime.CommandType = CommandType.Text;
            selectProjectWorkedTime.CommandText = "SELECT * FROM projektmitarbeiter";
            MySqlDataReader workedTimeReader = selectProjectWorkedTime.ExecuteReader();
            if(workedTimeReader.HasRows)
            {
                while (workedTimeReader.Read())
                {
                    var index = result.FindIndex(p => p.projectNumber == workedTimeReader.GetInt16("ProjNr"));
                    result[index].addHoursWorked(workedTimeReader.GetInt16("Zeitanteil"));
                }
            }
            
            return result;
        }
    }
}