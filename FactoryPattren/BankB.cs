﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren
{
  public class BankB:IBank
    {
        public string Withdraw()
        {
           return "Your requset is handeling by BankB";
        }

    }
}
