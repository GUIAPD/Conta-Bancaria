using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class ContaBancaria
    {
        private int _numeroConta { get; set; }
        private string _titular { get; set; }
        private double _saldo { get; set; }

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldo;
            
        }
        public double Depositar(double BotarValor)
        {
            _saldo += BotarValor;
            return BotarValor;
        }
        public bool TemValor()
        {
            return _saldo > 0;
        }
        public double Sacar(double Saque)
        {
            if (TemValor() && Saque < _saldo)
            {
                _saldo -= Saque;
                return Saque;
            }
            else
            {
               Console.WriteLine("Saque indisponível.");
                return 0;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine(_titular);
            Console.WriteLine($"Saldo atual: R${_saldo}");
        }
    }
}
