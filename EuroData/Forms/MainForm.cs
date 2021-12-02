using System;
using System.Data;
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
                dbCon.Open();

                dbCommand = dbCon.CreateCommand();
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = "SELECT * FROM mitarbeiter";
                MySqlDataReader reader = dbCommand.ExecuteReader();
            
                while (reader.Read())
                {
                    debugBox.Text += $"{reader.GetString( "Vorname")} {reader.GetString( "Name")}\r\n";

                }
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