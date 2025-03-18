using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {

        }
        public double DepositarPoupança(double BotarValorP)
        {
            return Depositar(BotarValorP * 1.005);
        }
    }
}
