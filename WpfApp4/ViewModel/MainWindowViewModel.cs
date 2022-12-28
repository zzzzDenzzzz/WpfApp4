using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfApp4.Model.Departament;
using WpfApp4.ViewModel.Command;

namespace WpfApp4.ViewModel
{
    internal class MainWindowViewModel : ViewModel
    {
        /// <summary>
        /// список(коллекция) отделов
        /// </summary>
        public ObservableCollection<Departament> Departaments { get; }

        Departament selectedDepartament;
        /// <summary>
        /// выбранный отдел
        /// </summary>
        public Departament SelectedDepartament
        {
            get => selectedDepartament;
            set => Set(ref selectedDepartament, value);
        }

        Employee selectedEmployee;
        /// <summary>
        /// выбранный сотрудник
        /// </summary>
        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set => Set(ref selectedEmployee, value);
        }

        /////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// команда для создания отдела
        /// </summary>
        public ICommand CreateDepartamentCommand { get; }

        bool CanCreateDepartamentCommandExecute(object d) => true;

        void OnCreateDepartamentCommandExecuted(object d)
        {
            var departamentMaxIndex = Departaments.Count + 1;
            var newDepartament = new Departament
            {
                Name = $"Отдел {departamentMaxIndex}",
                Employees = new ObservableCollection<Employee> ()
            };

            Departaments.Add(newDepartament);
        }

        /// <summary>
        /// команда для удаления отдела
        /// </summary>
        public ICommand DeleteDepartamentCommand { get; }

        bool CanDeleteDepartamentCommandExecute(object d) => d is Departament departament && Departaments.Contains(departament);

        void OnDeleteDepartamentCommandExecuted(object d)
        {
            if (!(d is Departament departament))
            {
                return;
            }

            var departamentIndex = Departaments.IndexOf(departament);

            Departaments.Remove(departament);

            if (departamentIndex < Departaments.Count)
            {
                SelectedDepartament = Departaments[departamentIndex];
            }
        }

        /// <summary>
        /// команда для создания сотрудника
        /// </summary>
        public ICommand CreateEmployeeCommand { get; }

        bool CanCreateEmployeeCommandExecute(object e) => true;

        void OnCreateEmployeeCommandExecuted(object e)
        {
            MessageBox.Show("Test");
        }

        /// <summary>
        /// команда для удаления сотрудника
        /// </summary>
        public ICommand DeleteEmployeeCommand { get; }

        bool CanDeleteEmployeeCommandExecute(object e) => true;

        void OnDeleteEmployeeCommandExecuted(object e)
        {
            MessageBox.Show("Test");
        }

        ///////////////////////////////////////////////////////////////////

        public MainWindowViewModel()
        {
            // создает команды
            CreateDepartamentCommand = new LambdaCommand(OnCreateDepartamentCommandExecuted, CanCreateDepartamentCommandExecute);
            DeleteDepartamentCommand = new LambdaCommand(OnDeleteDepartamentCommandExecuted, CanDeleteDepartamentCommandExecute);

            CreateEmployeeCommand = new LambdaCommand(OnCreateEmployeeCommandExecuted, CanCreateEmployeeCommandExecute);
            DeleteEmployeeCommand = new LambdaCommand(OnDeleteEmployeeCommandExecuted, CanDeleteEmployeeCommandExecute);

            var employeeIndex = 1;
            // создает девять сотрудников
            var employees = Enumerable.Range(1, 9).Select(i => new Employee
            {
                Name = $"Name {employeeIndex}",
                Surname = $"Surname {employeeIndex}",
                Patronymic = $"Patronymic {employeeIndex}",
                PhoneNumber = $"{employeeIndex}{employeeIndex}-{employeeIndex}{employeeIndex}-{employeeIndex}{employeeIndex}",
                JobTitle = $"JobTitle {employeeIndex}",
                Login = $"Login {employeeIndex}",
                Password = $"Password {employeeIndex}",
                EMail = $"@Mail_{employeeIndex++}.com",
            });
            // создает девять отделов по девять сотрудников в каждом
            var departaments = Enumerable.Range(1, 9).Select(i => new Departament
            {
                Name = $"Отдел {i}",
                Employees = new ObservableCollection<Employee>(employees)
            });

            Departaments = new ObservableCollection<Departament>(departaments);
        }
    }
}
