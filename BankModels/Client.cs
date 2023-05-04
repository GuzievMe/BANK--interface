using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BankModels
{
    internal class Client : Person
    {
        public double Crediti { get; set; }
        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }
    }
}
