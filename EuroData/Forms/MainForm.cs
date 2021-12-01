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
        public MainForm()
        {
            InitializeComponent();
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            MySqlConnection dbCon = new MySqlConnection(connectionString);
            try
            {
                debugBox.Text = "Connecting to database...";
                dbCon.Open();
                debugBox.Text = "Connected to database!";
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