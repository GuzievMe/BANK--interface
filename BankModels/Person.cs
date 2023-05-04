using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BankModels
{
    internal class Person
    {
        public Person() { }
        public Person (Guid guid, string name, string surname, short age, decimal salary)
        {

            Id = Id;     Name = name;  Surname = surname;    Age = age;     Salary = Salary;

        }
        public Guid Id { get; set; }
         public string Name { get; set; }
         public string Surname { get; set; }
        public short Age { get; set; }
        public double Salary { get; set; }
    }
}
