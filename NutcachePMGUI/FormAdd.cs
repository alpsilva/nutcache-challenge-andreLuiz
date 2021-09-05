using Newtonsoft.Json;
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
using NutcachePeopleManagement.Models;
using System.Net.Http.Headers;

namespace NutcachePMGUI
{
    public partial class FormAdd : Form
    {
        private string url = "https://localhost:44352/api/people";

        public FormAdd()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime birthdate = BirthDatePicker.Value;
            string gender = GenderDropDown.Text;
            string email = txtEmail.Text;
            string cpf = txtCPF.Text;
            DateTime startdate = StartDatePicker.Value;
            string team = TeamDropdown.Text;

            Person employee = new Person();
            employee.Name = name;
            employee.BirthDate = birthdate;
            employee.Gender = gender;
            employee.Email = email;
            employee.CPF = cpf;
            employee.StartDate = startdate;
            employee.Team = team;

            bool result = addEmployee(employee);

            if (result)
            {
                txtName.Text = "";
                GenderDropDown.SelectedIndex = 0;
                txtEmail.Text = "";
                txtCPF.Text = "";
                TeamDropdown.SelectedIndex = 0;
                this.Close();
            }
        }

        private Boolean addEmployee(Person employee)
        {
            Boolean isEmployeeUploaded = false;

            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                bool _isEmployeeUploaded = false;
                string json = JsonConvert.SerializeObject(employee);
                var contentString = new StringContent(json, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                Task taskUpload = httpClient.PostAsync(url, contentString).ContinueWith(task =>
                {
                    if (task.Status == TaskStatus.RanToCompletion)
                    {
                        var response = task.Result;

                        if (response.IsSuccessStatusCode)
                        {
                            _isEmployeeUploaded = true;
                        }
                    }
                });

                taskUpload.Wait();
                if (_isEmployeeUploaded)
                {
                    isEmployeeUploaded = true;
                }
                httpClient.Dispose();
            }
            catch (Exception e)
            {
                isEmployeeUploaded = false;
            }

            return isEmployeeUploaded;
        }
    }
}
