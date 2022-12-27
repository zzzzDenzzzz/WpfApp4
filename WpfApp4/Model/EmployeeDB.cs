using System.Collections.Generic;

namespace WpfApp4.Model
{
    internal class EmployeesDB
    {
        // список сотрудников
        public List<Employee> Employees { get; set; }
        public EmployeesDB()
        {
            Employees = new List<Employee>()
            {
                new Employee("name1", "surname1", "patronymic1", "11-11-11", "jobTitle1", "departament1", "login1", "password1", "@mail_1.com"),
                new Employee("name2", "surname2", "patronymic2", "22-22-22", "jobTitle2", "departament2", "login2", "password2", "@mail_2.com"),
                new Employee("name3", "surname3", "patronymic3", "33-33-33", "jobTitle3", "departament3", "login3", "password3", "@mail_3.com"),
                new Employee("name4", "surname4", "patronymic4", "44-44-44", "jobTitle4", "departament4", "login4", "password4", "@mail_4.com"),
                new Employee("name5", "surname5", "patronymic5", "55-55-55", "jobTitle5", "departament5", "login5", "password5", "@mail_5.com"),
            };
        }
    }
}
