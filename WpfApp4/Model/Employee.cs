namespace WpfApp4.Model
{
    internal class Employee
    {
        // имя
        public string Name { get; set; }
        // фамилия
        public string Surname { get; set; }
        // отчество
        public string Patronymic { get; set; }
        // телефонный номер
        public string PhoneNumber { get; set; }
        // должность
        public string JobTitle { get; set; }
        // отдел
        public string Department { get; set; }
        // логин
        public string Login { get; set; }
        // пароль
        public string Password { get; set; }
        // e-mail
        public string EMail { get; set; }

        public Employee(string name, string surname, string patronymic, string phoneNumber, string jobTitle, string department, string login, string password, string eMail)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            JobTitle = jobTitle;
            Department = department;
            Login = login;
            Password = password;
            EMail = eMail;
        }
    }
}
