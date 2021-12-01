using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EuroData.Forms
{
    public partial class MainForm : Form
    {
        // ToDo: make it configurable in a separate file (.env?)
        private string connectionString = "server=localhost;uid=root;" +
                                          "password=root;database=db_euro_data";
        private MySqlCommand dbCommand;
        private MySqlConnection dbCon;
        public MainForm()
        {
            InitializeComponent();
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            dbCon = new MySqlConnection(connectionString);
            try
            {
                debugBox.Text = "Connecting to database...";
                dbCon.Open();
                debugBox.Text = "Connected to database!";

                dbCommand = dbCon.CreateCommand();
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = $"SELECT * FROM test";
                MySqlDataReader reader = dbCommand.ExecuteReader();
                if (reader.HasRows) {
                    int count = reader.FieldCount;
                    debugBox.Text += $"\r\nFound {count.ToString()} row(s):";
                    while (reader.Read())
                    {
                        debugBox.Text += "\r\n"+reader.GetString("test_text");
                    }
                    reader.Close();
                }
                
                dbCon.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error"+ex.Message);
            }
        }
    }
}