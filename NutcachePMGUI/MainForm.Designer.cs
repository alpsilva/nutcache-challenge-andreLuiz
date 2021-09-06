
namespace NutcachePMGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.registeredEmployeesLabel = new System.Windows.Forms.Label();
            this.ListEmployeesButton = new System.Windows.Forms.Button();
            this.employeeDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ch_deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.Location = new System.Drawing.Point(12, 12);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(146, 23);
            this.addNewEmployeeButton.TabIndex = 0;
            this.addNewEmployeeButton.Text = "Add new employee";
            this.addNewEmployeeButton.UseVisualStyleBackColor = true;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // registeredEmployeesLabel
            // 
            this.registeredEmployeesLabel.AutoSize = true;
            this.registeredEmployeesLabel.Location = new System.Drawing.Point(13, 42);
            this.registeredEmployeesLabel.Name = "registeredEmployeesLabel";
            this.registeredEmployeesLabel.Size = new System.Drawing.Size(125, 15);
            this.registeredEmployeesLabel.TabIndex = 2;
            this.registeredEmployeesLabel.Text = "Registered employees:";
            // 
            // ListEmployeesButton
            // 
            this.ListEmployeesButton.Location = new System.Drawing.Point(164, 12);
            this.ListEmployeesButton.Name = "ListEmployeesButton";
            this.ListEmployeesButton.Size = new System.Drawing.Size(143, 23);
            this.ListEmployeesButton.TabIndex = 3;
            this.ListEmployeesButton.Text = "List Employees";
            this.ListEmployeesButton.UseVisualStyleBackColor = true;
            this.ListEmployeesButton.Click += new System.EventHandler(this.ListEmployeesButton_Click);
            // 
            // employeeDataGrid
            // 
            this.employeeDataGrid.AllowUserToAddRows = false;
            this.employeeDataGrid.AllowUserToDeleteRows = false;
            this.employeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_name,
            this.ch_email,
            this.ch_startDate,
            this.ch_team,
            this.ch_editButton,
            this.ch_deleteButton,
            this.ch_id});
            this.employeeDataGrid.Location = new System.Drawing.Point(12, 60);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.ReadOnly = true;
            this.employeeDataGrid.RowTemplate.Height = 25;
            this.employeeDataGrid.Size = new System.Drawing.Size(776, 378);
            this.employeeDataGrid.TabIndex = 4;
            this.employeeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGrid_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(679, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Disable Employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(564, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 24);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit  Employee";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(458, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 7;
            // 
            // ch_name
            // 
            this.ch_name.HeaderText = "Name";
            this.ch_name.Name = "ch_name";
            this.ch_name.ReadOnly = true;
            // 
            // ch_email
            // 
            this.ch_email.HeaderText = "Email";
            this.ch_email.Name = "ch_email";
            this.ch_email.ReadOnly = true;
            // 
            // ch_startDate
            // 
            this.ch_startDate.HeaderText = "Start Date";
            this.ch_startDate.Name = "ch_startDate";
            this.ch_startDate.ReadOnly = true;
            // 
            // ch_team
            // 
            this.ch_team.HeaderText = "Team";
            this.ch_team.Name = "ch_team";
            this.ch_team.ReadOnly = true;
            // 
            // ch_editButton
            // 
            this.ch_editButton.HeaderText = "Edit";
            this.ch_editButton.Name = "ch_editButton";
            this.ch_editButton.ReadOnly = true;
            // 
            // ch_deleteButton
            // 
            this.ch_deleteButton.HeaderText = "Disable";
            this.ch_deleteButton.Name = "ch_deleteButton";
            this.ch_deleteButton.ReadOnly = true;
            // 
            // ch_id
            // 
            this.ch_id.HeaderText = "id";
            this.ch_id.Name = "ch_id";
            this.ch_id.ReadOnly = true;
            this.ch_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ch_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.employeeDataGrid);
            this.Controls.Add(this.ListEmployeesButton);
            this.Controls.Add(this.registeredEmployeesLabel);
            this.Controls.Add(this.addNewEmployeeButton);
            this.Name = "MainForm";
            this.Text = "Nutcache People Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewEmployeeButton;
        private System.Windows.Forms.Label registeredEmployeesLabel;
        private System.Windows.Forms.Button ListEmployeesButton;
        private System.Windows.Forms.DataGridView employeeDataGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_team;
        private System.Windows.Forms.DataGridViewButtonColumn ch_editButton;
        private System.Windows.Forms.DataGridViewButtonColumn ch_deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_id;
    }
}

