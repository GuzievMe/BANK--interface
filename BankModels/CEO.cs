using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BankModels
{
    internal class CEO : Worker, Ifirst
    {
        public CEO() { }
        public CEO(Guid guid, string name, string surname, short age, string position, decimal salary, TimeOnly startTime, TimeOnly endTime) :
            base(guid, name, surname, age, position, salary, startTime, endTime)
        {

        }

        public List<string> Control = new() { };
        public int _percent = 12;
        public List<string> GetControl { get { return Control; } }

        public string SetControl { set { Control.Add(value); } }
        public string MakeMeeting { get; set; }
        string Ifirst.Control { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int DecreasePersentage(int percent)
        {
            if (percent < 0) throw new ArgumentOutOfRangeException("percent yalnishtir");
            _percent = percent;
            return _percent;
        }

    }

}
