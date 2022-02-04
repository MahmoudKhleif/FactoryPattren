using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren
{
    internal class BankFactory : IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456": return new BankA ();
                case "222222": return new BankB();
                case "333333": return new BankC();

            }
            return null;
        }
    }
}
