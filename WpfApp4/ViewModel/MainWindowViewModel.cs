using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp4.Model;

namespace WpfApp4.ViewModel
{
    internal class MainWindowViewModel : ViewModel
    {
        // фио
        string nameSurnamePatronimyc;
        public string NameSurnamePatronimyc
        {
            get => nameSurnamePatronimyc;
            set => Set(ref nameSurnamePatronimyc, value);
        }
        // номер телефона
        string numberPhone;
        public string NumberPhone
        {
            get => numberPhone;
            set => Set(ref numberPhone, value);
        }
        // должность
        string jobTitle;
        public string JobTitle
        {
            get => jobTitle;
            set => Set(ref jobTitle, value);
        }
        // отдел
        string departament;
        public string Departament
        {
            get => departament;
            set => Set(ref departament, value);
        }
        // логин
        string login;
        public string Login
        {
            get => login;
            set => Set(ref login, value);
        }
        // пароль
        string password;
        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }
        // e-mail
        string email;
        public string Email
        {
            get => email;
            set => Set(ref email, value);
        }
        // поиск
        string searchText;
        public string SearchText
        {
            get => searchText;
            set => Set(ref searchText, value);
        }

        //public List<Employee> Employees { get; set; }

        public void SearchLogin()
        {
            foreach (var item in EmployeeDB.Context.Employees)
            {
                if (item.Login == SearchText)
                {
                    MessageBox.Show(item.Login);
                }
            }
        }
    }
}
