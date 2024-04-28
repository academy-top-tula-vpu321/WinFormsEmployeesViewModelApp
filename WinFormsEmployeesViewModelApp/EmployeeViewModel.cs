using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsEmployeesViewModelApp
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        static int idEmployee = 0;

        string lastName = "";
        string firstName = "";
        DateTime birthDate = DateTime.Now;
        string phone = "";

        int selectedIndex = 0;

        public EmployeeViewModel()
        {
            Employees = new()
            {
                new()
                {
                    Id = ++idEmployee,
                    LastName = "Whatson",
                    FirstName = "Billy",
                    BirthDate = new DateTime(1999, 5, 10),
                    Phone = "(999) 111-22-33"
                },
                new()
                {
                    Id = ++idEmployee,
                    LastName = "Simpson",
                    FirstName = "Tommy",
                    BirthDate = new DateTime(2002, 2, 18),
                    Phone = "(900) 555-00-99"
                },
                new()
                {
                    Id = ++idEmployee,
                    LastName = "House",
                    FirstName = "Gregory",
                    BirthDate = new DateTime(1984, 7, 8),
                    Phone = "(555) 456-65-56"
                },
            };

            AddCommand = new EmployeeCommand(_ =>
            {
                if(this.LastName.Trim().Length > 0)
                {
                    Employees.Add(new Employee
                    {
                        Id = ++idEmployee,
                        LastName = this.LastName,
                        FirstName = this.FirstName,
                        BirthDate = this.BirthDate,
                        Phone = this.Phone
                    });

                    this.LastName = "";
                    this.FirstName = "";
                    this.BirthDate = DateTime.Now;
                    this.Phone = "";

                    string message = "";
                    foreach (var e in Employees)
                        message += e.ToString() + "\n";
                    MessageBox.Show(message);
                }
            });
            
            RemoveCommand = new EmployeeCommand(
                obj =>
                {
                    if(obj is int id)
                    {
                        var employee = Employees.FirstOrDefault(e => e.Id == id);
                        if(employee is not null)
                        {
                            int position = SelectedIndex;
                            Employees.Remove(employee);
                            if (position >= Employees.Count)
                                position = Employees.Count - 1;
                            SelectedIndex = position;
                        }
                    }
                },
                _ => Employees.Count > 0
            );
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged();
                }

            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (birthDate != value)
                {
                    birthDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Phone
        {
            get => phone;
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged();
                }
            }
        }
        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }

        public BindingList<Employee> Employees { get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
