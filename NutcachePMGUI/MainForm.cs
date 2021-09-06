using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NutcachePeopleManagement.Models;

namespace NutcachePMGUI
{
    public partial class MainForm : Form
    {
        private string url = "https://localhost:44352/api/people";

        public MainForm()
        {
            InitializeComponent();
            loadEmployees();
        }
        
        // add new employee button
        private void button1_Click(object sender, EventArgs e)
        {
            var addPopup = new FormAdd();
            addPopup.FormClosed += popup_FormClosed;
            addPopup.ShowDialog();
        }
        private void popup_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        private void ListEmployeesButton_Click(object sender, EventArgs e)
        {
            loadEmployees();
        }

        private async void loadEmployees()
        {
            List<Person> listEmployees = new List<Person>();

            int nRows = employeeDataGrid.ColumnCount;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        listEmployees = JsonConvert.DeserializeObject<Person[]>(jsonString).ToList();

                        employeeDataGrid.Rows.Clear();
                        
                        foreach (Person emp in listEmployees)
                        {
                            string[] row = new string[nRows];

                            row[0] = emp.Id.ToString();
                            row[1] = emp.Name;
                            row[2] = emp.Email;
                            row[3] = emp.StartDate.ToString();
                            row[4] = emp.Team;

                            employeeDataGrid.Rows.Add(row);
                        }
                             
                    }
                }
            }
        }

        private async void deleteEmployee(long id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync(url + "/" + id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        loadEmployees();
                    }
                }
            }
        }

        private void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeDataGrid.Columns[e.ColumnIndex].Name == "ch_editButton")
            {

            }
            if (employeeDataGrid.Columns[e.ColumnIndex].Name == "ch_deleteButton")
            {
                if (MessageBox.Show("Are you sure you wanto to delete this employee?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // proceeds to delete employee


                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // proceeds to delete employee
                long id = long.Parse(txtId.Text);
                deleteEmployee(id);
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            long id = long.Parse(txtId.Text);
            var editPopup = new FormEdit(id);
            editPopup.FormClosed += editPopup_FormClosed;
            editPopup.ShowDialog();
        }

        private void editPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Employee info updated!");
            loadEmployees();
        }
    }
}
