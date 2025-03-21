using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class NumeroConta
    {
        public static implicit operator NumeroConta(ContaCorrente v)
        {
            throw new NotImplementedException();
        }
    }
}
