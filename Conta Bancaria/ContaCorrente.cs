using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
            Taxa = 5;
        }
        public double SacarCorrente(double SaqueCorrente)
        {
            if (TemValor())
            {
                return Sacar(SaqueCorrente + 5);
            }
            else
            {
                Console.WriteLine("Saque indisponível.");
                return 0;
            }
        }
    }
}
