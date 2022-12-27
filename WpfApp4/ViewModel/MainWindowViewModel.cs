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
        // имя
        string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        // фамилия
        string surname;
        public string Surname
        {
            get => surname;
            set => Set(ref surname, value);
        }
        // отчество
        string patronimyc;
        public string Patronimyc
        {
            get => patronimyc;
            set => Set(ref patronimyc, value);
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
    }
}
