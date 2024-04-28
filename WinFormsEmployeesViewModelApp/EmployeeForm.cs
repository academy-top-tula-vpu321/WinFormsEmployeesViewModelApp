namespace WinFormsEmployeesViewModelApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            this.DataContext = new EmployeeViewModel();

            listEmployees.DataBindings.Add(new Binding("DataSource",
                                                        DataContext,
                                                        "Employees",
                                                        true,
                                                        DataSourceUpdateMode.OnPropertyChanged));
            
            listEmployees.DisplayMember = "LastName";
            listEmployees.ValueMember = "Id";

            txtLastName.DataBindings.Add(new Binding("Text",
                                                      DataContext,
                                                      "LastName",
                                                      true,
                                                      DataSourceUpdateMode.OnPropertyChanged));
            txtFirstName.DataBindings.Add(new Binding("Text",
                                                      DataContext,
                                                      "FirstName",
                                                      true,
                                                      DataSourceUpdateMode.OnPropertyChanged));
            pickerBirthDate.DataBindings.Add(new Binding("Value",
                                                      DataContext,
                                                      "BirthDate",
                                                      true,
                                                      DataSourceUpdateMode.OnPropertyChanged));
            txtPhone.DataBindings.Add(new Binding("Text",
                                                    DataContext,
                                                    "Phone",
                                                    true,
                                                    DataSourceUpdateMode.OnPropertyChanged));

            btnAdd.DataBindings.Add(new Binding("Command",
                                                 DataContext,
                                                 "AddCommand",
                                                 true));

            btnRemove.DataBindings.Add(new Binding("Command",
                                                     DataContext,
                                                     "RemoveCommand",
                                                     true));
            btnRemove.DataBindings.Add(new Binding("CommandParameter",
                                                    listEmployees,
                                                    "SelectedValue",
                                                    true,
                                                    DataSourceUpdateMode.OnPropertyChanged));

            listEmployees.DataBindings.Add(new Binding("SelectedIndex",
                                                        DataContext,
                                                        "SelectedIndex",
                                                        true,
                                                        DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
