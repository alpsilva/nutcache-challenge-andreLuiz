using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutcachePMGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowEmployees();
        }

        public void ShowEmployees()
        {
        }
        
        // add new employee button
        private void button1_Click(object sender, EventArgs e)
        {
            var addPopup = new FormAdd();
            addPopup.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
