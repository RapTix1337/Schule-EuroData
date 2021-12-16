using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EuroData.Classes.Entities;
using EuroData.Classes.Helper;

namespace EuroData.Forms
{
    public partial class MainForm : Form
    {
        private List<Project> projects;
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public MainForm()
        {
            InitializeComponent();
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            try
            {
                projects = dbHelper.getAllProjects();
                debugBox.Text = "Project: paid amount / total hours worked";
                foreach (var project in projects)
                {
                    debugBox.Text += "\r\n "+project.title+": "+project.paidAmount + "/" + project.totalHoursWorked;
                }

                var sortedProjects = projects.OrderByDescending(p => p.getProjectValue());
                Project mostValuebleProject = sortedProjects.First();
                MessageBox.Show("Most valueble project: "+mostValuebleProject.title);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error "+ex.Message);
            }
        }
    }
}