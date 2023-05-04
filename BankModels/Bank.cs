using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BankModels
{
    //Bankin adi, budcesi filan da var ven o ozunde coxlu ishciler saclayir( Worker, Manager, CEO ve bashqalarini )
    //Ceo bir nefer ola bilir, manager de bir nefer olsa daha yaxshi olar, ama ferqi yoxdur

    internal class Bank : Interface1 
    {
        public string Name { get; set; }
        public double  Budget { get; set; }
        public double  Profit { get; set; }
        public double Calculate_Profit () =>    (Budget *= Profit / 100);

        CEO Ceo = new CEO();
        Worker[] Workers = new Worker[] {};
        Manager[] Managers = new Manager[] {};
        Client[] Clients = new Client[] { };
        public void ShowClientCredit(string fullName)
        {
            foreach(var client in Clients) 
            { 
                if (client.Name == fullName) Console .WriteLine (client.Crediti); return;
            }
        }
        public double PayCredit(Client client, double money)
        {
            return client.Crediti -= money;
        }
        public void PayCreditVoidRef(ref Client client, double money)
        {
            client.Crediti -= money;
        }
        public void ShowAllCredit ()
        {
            foreach (var client in Clients)
            {
                Console.WriteLine(client.Crediti.ToString());
            }
        }
        public override string ToString()
        {
            return Name ;
        }


    }
}
