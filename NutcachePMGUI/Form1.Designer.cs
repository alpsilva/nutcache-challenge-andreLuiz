
namespace NutcachePMGUI
{
    partial class Form1
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
            System.Windows.Forms.ColumnHeader ch_name;
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.registeredEmployeesLabel = new System.Windows.Forms.Label();
            this.ch_email = new System.Windows.Forms.ColumnHeader();
            this.ch_startDate = new System.Windows.Forms.ColumnHeader();
            this.ch_team = new System.Windows.Forms.ColumnHeader();
            this.ch_edit = new System.Windows.Forms.ColumnHeader();
            this.ch_delete = new System.Windows.Forms.ColumnHeader();
            ch_name = new System.Windows.Forms.ColumnHeader();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ch_name,
            this.ch_email,
            this.ch_startDate,
            this.ch_team,
            this.ch_edit,
            this.ch_delete});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 378);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // ch_name
            // 
            ch_name.Text = "Name";
            // 
            // ch_email
            // 
            this.ch_email.Text = "Email";
            // 
            // ch_startDate
            // 
            this.ch_startDate.Text = "Start Date";
            // 
            // ch_team
            // 
            this.ch_team.Text = "Team";
            // 
            // ch_edit
            // 
            this.ch_edit.Text = "Edit";
            // 
            // ch_delete
            // 
            this.ch_delete.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registeredEmployeesLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addNewEmployeeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewEmployeeButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_email;
        private System.Windows.Forms.ColumnHeader ch_startDate;
        private System.Windows.Forms.ColumnHeader ch_team;
        private System.Windows.Forms.ColumnHeader ch_edit;
        private System.Windows.Forms.ColumnHeader ch_delete;
        private System.Windows.Forms.Label registeredEmployeesLabel;
    }
}

