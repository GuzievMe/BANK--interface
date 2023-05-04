using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BankModels
{
    internal class Credit
    {
        //client, amount, percent, month, calculatePercent, payment
        public Guid Id { get; set; }
        public Client Clent { get; set; }
        public double Amount { get; set; }
        public short Percent { get; set; }
        public short Month { get; set; }    //// Meselen 2 ilden cox muddete vere bilmerik adinda bir shey de elave yazmaq olar 
        public double calculatePercent()           ////////Ne qeder uzun muddetliyine almaq istese faizler daha yukselecey
        {
            double percent;
            if (Amount < 1000)
            {
                switch (Month)
                {
                    case 6: return 6; break;
                    case 12: return 12.5d; break;
                    default: Console.WriteLine(" 1000 aznden ashagi odenishler 1 ilden daha artiq muddete mumkun deyil ..."); break;
                }
            }
            else if (Amount < 5000)
            {
                switch (Month)
                {
                    case 6: return 7; break;
                    case 12: return 14.5d; break;
                    case 18: return 19; break;
                    case 24: return 29; break;
                    default: Console.WriteLine(" 5000 aznden ashagi odenishler 2 ilden daha artiq muddete mumkun deyil ..."); break;
                }

            }
            else if (Amount < 20000)
            {
                switch (Month)
                {
                    case 6: return 6; break;
                    case 12: return 12.5d; break;
                    case 18: return 19; break;
                    case 24: return 29; break;
                    case 36: return 36; break;
                    case 60: return 45; break;
                    default: Console.WriteLine(" Biz max 5 illik muddete kredit vere bilirik ..."); break;
                }

            }
            else { Console.WriteLine("Yeni qurulmush olan Bankimizin sermayeleri il hele ki,  20000 i ashan creditler vere bilmirik ..."); }
            return 0.0;
        } 
    }
}
