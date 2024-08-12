using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PratikAbstraction
{
    public interface IEmployee
    {
        void Position();
    }
    public abstract class Employee : IEmployee
    {
        public string Name{ get; set; }
        public string Surname { get; set; }
        public string Departmant { get; set; }

        public Employee(string name, string surname, string departmant)
        {
            Name = name;
            Surname = surname;
            Departmant = departmant;
        }

        public abstract void Position();

    }

    public class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string name, string surname, string departmant)
            : base(name, surname, departmant)
        { }
        public override void Position()
        {
            Console.WriteLine($"{Name} {Surname} Yazılım Geliştiricisi olarak çalışıyorum.");
        }


    }

    public class ProjectManager : Employee
    {
        public ProjectManager(string name, string surname, string departmant)
            : base(name, surname, departmant) { }

        public override void Position()
        {
            Console.WriteLine($"{Name} {Surname} Proje Yöneticisi olarak çalışıyorum.");
        }
    }
    public class SalesRepresentative : Employee
    {
        public SalesRepresentative(string name, string surname, string departmant) : base(name, surname, departmant) { }
        public override void Position()
        {
            Console.WriteLine($"{Name} {Surname} Satış Temsilcisi olarak çalışıyorum.");
        }
    }
}

