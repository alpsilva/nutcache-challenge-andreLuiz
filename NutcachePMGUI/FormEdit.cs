using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NutcachePeopleManagement.Models;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace NutcachePMGUI
{
    public partial class FormEdit : Form
    {
        private string url = "https://localhost:44352/api/people";
        private long _id = -1;

        Person _employee = new Person();

        public FormEdit(long id)
        {
            _id = id;
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit this employee with the new information?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // proceeds to edit employee
                string name = txtName.Text;
                DateTime birthdate = BirthDatePicker.Value;
                string gender = GenderDropDown.Text;
                string email = txtEmail.Text;
                string cpf = txtCPF.Text;
                DateTime startdate = StartDatePicker.Value;
                string team = TeamDropdown.Text;

                Person edittedEmployee = new Person();
                edittedEmployee.Name = name;
                edittedEmployee.BirthDate = birthdate;
                edittedEmployee.Gender = gender;
                edittedEmployee.Email = email;
                edittedEmployee.CPF = cpf;
                edittedEmployee.StartDate = startdate;
                edittedEmployee.Team = team;
                edittedEmployee.Id = _employee.Id;

                editEmployee(edittedEmployee);
                
                
                this.Close();
            }    
        }

        private async void getOneEmployee(long id)
        {
            Person p = new Person();

            HttpClient httpClient = new HttpClient();
            var request = await httpClient.GetAsync(url + "/" + id.ToString());

            if (request.IsSuccessStatusCode)
            {
                var jsonString = await request.Content.ReadAsStringAsync();
                p = JsonConvert.DeserializeObject<Person>(jsonString);
                if (p.CPF != null)
                {
                    _employee = clonePerson(p);
                    txtName.Text = p.Name;
                    //BirthDatePicker.Value = Convert.ToDateTime(_employee.BirthDate.ToString());
                    GenderDropDown.SelectedItem = p.Gender;
                    txtEmail.Text = p.Email;
                    txtCPF.Text = p.CPF;
                    //StartDatePicker.Value = Convert.ToDateTime(_employee.StartDate.ToString());
                    TeamDropdown.SelectedItem = p.Team;
                } else
                {
                    MessageBox.Show("Employee not found.");
                    this.Close();
                }
            }
        }

        private async void editEmployee(Person ediEmp)
        {
            using (var httpClient = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(ediEmp);
                var contentString = new StringContent(json, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                string newUrl = url + "/" + ediEmp.Id.ToString();

                using (var response = await httpClient.PutAsync(newUrl, contentString))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        _employee = JsonConvert.DeserializeObject<Person>(jsonString);
                    }
                }
            }
        }

        private Person clonePerson(Person p)
        {
            Person np = new Person();
            np.Id = p.Id;
            np.Name = p.Name;
            np.Gender = p.Gender;
            np.Email = p.Email;
            np.CPF = p.CPF;
            np.StartDate = p.StartDate;
            np.Team = p.Team;

            return np;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            getOneEmployee(_id);
        }

        private void LoadEmployeeButton_Click(object sender, EventArgs e)
        {
            getOneEmployee(_id);
        }
    }
}
