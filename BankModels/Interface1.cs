using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BankModels
{
    internal interface Interface1
    {
        public void ShowClientCredit(string fullName);

        public double PayCredit(Client client, double money);

        public void PayCreditVoidRef(ref Client client, double money);

        public void ShowAllCredit();
        
    }
}
