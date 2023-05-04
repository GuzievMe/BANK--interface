using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace Bank.BankModels
{
    internal class Worker : Person
    {
        public Worker() { }
        public Worker(Guid guid, string name, string surname, short age, string position, decimal salary, TimeOnly startTime, TimeOnly endTime)
            : base(guid, name, surname, age, salary)
        {
            Position = position; StartTime = startTime; EndTime = endTime;
        }
        public string Position { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public List<string> operations = new() { };
        public void AddOperation(string op)
        {
            operations.Add(op);
        }



    }

    /// /////////////////////////////////////////////////////////

    
    /// //////////////////////////////////////////////////////////////////
    
    internal class Manager : Worker, Ifirst
    {
        public string Control { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MakeMeeting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Organize()
        {
            Console.WriteLine("Organize edir ..");
        }
        public void CalculateSalaries(ref Worker a)
        {
            a.Salary *= 1.4;     
        }
    }
    

}
