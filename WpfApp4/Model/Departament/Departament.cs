using System.Collections.Generic;

namespace WpfApp4.Model.Departament
{
    internal class Departament
    {
        /// <summary>
        /// название отдела
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// интерфейс для создания списка сотрудников
        /// </summary>
        public IList<Employee> Employees { get; set; }
    }
}
