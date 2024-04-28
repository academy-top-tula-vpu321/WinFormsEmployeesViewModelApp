namespace WinFormsEmployeesViewModelApp
{
    partial class EmployeeForm
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
            groupBoxEmployeesList = new GroupBox();
            listEmployees = new ListBox();
            groupBoxEmployeeInfo = new GroupBox();
            pickerBirthDate = new DateTimePicker();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblPhone = new Label();
            lblBirthDate = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            groupBoxControls = new GroupBox();
            btnAdd = new Button();
            btnRemove = new Button();
            groupBoxEmployeesList.SuspendLayout();
            groupBoxEmployeeInfo.SuspendLayout();
            groupBoxControls.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxEmployeesList
            // 
            groupBoxEmployeesList.Controls.Add(listEmployees);
            groupBoxEmployeesList.Font = new Font("Segoe UI", 16F);
            groupBoxEmployeesList.Location = new Point(12, 12);
            groupBoxEmployeesList.Name = "groupBoxEmployeesList";
            groupBoxEmployeesList.Size = new Size(458, 607);
            groupBoxEmployeesList.TabIndex = 0;
            groupBoxEmployeesList.TabStop = false;
            groupBoxEmployeesList.Text = "Employees List";
            // 
            // listEmployees
            // 
            listEmployees.Dock = DockStyle.Fill;
            listEmployees.FormattingEnabled = true;
            listEmployees.ItemHeight = 30;
            listEmployees.Location = new Point(3, 32);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(452, 572);
            listEmployees.TabIndex = 0;
            // 
            // groupBoxEmployeeInfo
            // 
            groupBoxEmployeeInfo.Controls.Add(pickerBirthDate);
            groupBoxEmployeeInfo.Controls.Add(txtPhone);
            groupBoxEmployeeInfo.Controls.Add(txtFirstName);
            groupBoxEmployeeInfo.Controls.Add(txtLastName);
            groupBoxEmployeeInfo.Controls.Add(lblPhone);
            groupBoxEmployeeInfo.Controls.Add(lblBirthDate);
            groupBoxEmployeeInfo.Controls.Add(lblFirstName);
            groupBoxEmployeeInfo.Controls.Add(lblLastName);
            groupBoxEmployeeInfo.Font = new Font("Segoe UI", 16F);
            groupBoxEmployeeInfo.Location = new Point(487, 12);
            groupBoxEmployeeInfo.Name = "groupBoxEmployeeInfo";
            groupBoxEmployeeInfo.Size = new Size(446, 413);
            groupBoxEmployeeInfo.TabIndex = 0;
            groupBoxEmployeeInfo.TabStop = false;
            groupBoxEmployeeInfo.Text = "Employee Info";
            // 
            // pickerBirthDate
            // 
            pickerBirthDate.Location = new Point(6, 260);
            pickerBirthDate.Name = "pickerBirthDate";
            pickerBirthDate.Size = new Size(434, 36);
            pickerBirthDate.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(6, 352);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(434, 36);
            txtPhone.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 170);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(434, 36);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(6, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(434, 36);
            txtLastName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(0, 319);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(74, 30);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(0, 225);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(109, 30);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Birth Date";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(6, 137);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(117, 30);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(6, 45);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(114, 30);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(btnRemove);
            groupBoxControls.Controls.Add(btnAdd);
            groupBoxControls.Font = new Font("Segoe UI", 16F);
            groupBoxControls.Location = new Point(487, 443);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(446, 176);
            groupBoxControls.TabIndex = 1;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Employees Controls";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 73);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(152, 60);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(124, 73);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 631);
            Controls.Add(groupBoxControls);
            Controls.Add(groupBoxEmployeeInfo);
            Controls.Add(groupBoxEmployeesList);
            Name = "EmployeeForm";
            Text = "Employees Editor";
            groupBoxEmployeesList.ResumeLayout(false);
            groupBoxEmployeeInfo.ResumeLayout(false);
            groupBoxEmployeeInfo.PerformLayout();
            groupBoxControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEmployeesList;
        private GroupBox groupBoxEmployeeInfo;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblPhone;
        private Label lblBirthDate;
        private Label lblFirstName;
        private Label lblLastName;
        private GroupBox groupBoxControls;
        private Button btnAdd;
        private ListBox listEmployees;
        private DateTimePicker pickerBirthDate;
        private Button btnRemove;
    }
}
