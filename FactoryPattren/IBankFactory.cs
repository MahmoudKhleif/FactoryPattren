using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren
{
    internal interface IBankFactory
    {
        IBank GetBank(string bankCode);
    }
}
