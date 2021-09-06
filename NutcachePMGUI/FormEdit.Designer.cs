
namespace NutcachePMGUI
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditButton = new System.Windows.Forms.Button();
            this.TeamDropdown = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.GenderDropDown = new System.Windows.Forms.ComboBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadEmployeeButton = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(93, 244);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 29;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TeamDropdown
            // 
            this.TeamDropdown.FormattingEnabled = true;
            this.TeamDropdown.Items.AddRange(new object[] {
            "Mobile",
            "Frontend",
            "Backend"});
            this.TeamDropdown.Location = new System.Drawing.Point(93, 215);
            this.TeamDropdown.Name = "TeamDropdown";
            this.TeamDropdown.Size = new System.Drawing.Size(121, 23);
            this.TeamDropdown.TabIndex = 28;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(93, 157);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 26;
            // 
            // GenderDropDown
            // 
            this.GenderDropDown.FormattingEnabled = true;
            this.GenderDropDown.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderDropDown.Location = new System.Drawing.Point(93, 99);
            this.GenderDropDown.Name = "GenderDropDown";
            this.GenderDropDown.Size = new System.Drawing.Size(121, 23);
            this.GenderDropDown.TabIndex = 25;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(93, 186);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 23);
            this.StartDatePicker.TabIndex = 24;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(93, 70);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(200, 23);
            this.BirthDatePicker.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Birth Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // loadEmployeeButton
            // 
            this.loadEmployeeButton.Location = new System.Drawing.Point(118, 12);
            this.loadEmployeeButton.Name = "loadEmployeeButton";
            this.loadEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.loadEmployeeButton.TabIndex = 30;
            this.loadEmployeeButton.Text = "Load";
            this.loadEmployeeButton.UseVisualStyleBackColor = true;
            this.loadEmployeeButton.Click += new System.EventHandler(this.loadEmployeeButton_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 31;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 275);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.loadEmployeeButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TeamDropdown);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.GenderDropDown);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEdit";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox TeamDropdown;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox GenderDropDown;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadEmployeeButton;
        private System.Windows.Forms.TextBox txtId;
    }
}