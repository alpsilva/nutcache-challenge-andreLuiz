﻿using System;
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
            addPopup.FormClosed += addPopup_FormClosed;
            addPopup.ShowDialog();
        }
        private void addPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadEmployees();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                            row[0] = emp.Name;
                            row[1] = emp.Email;
                            row[2] = emp.StartDate.ToString();
                            row[3] = emp.Team;
                            employeeDataGrid.Rows.Add(row);
                        }
                             
                    }
                }
            }
        }

        private async void deleteEmployee(int id)
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

    }
}