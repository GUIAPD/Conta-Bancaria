using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    public class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;
        private double _taxa;
        private double _porcentualDeposito;
        public int numero
        {
            get { return _numeroConta; }
            set { _numeroConta = value;}
        }
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        protected double Taxa
        {
            get { return _taxa; }
            set { _taxa = value; }
        }
        protected double PorcentualDeposito
        {
            get { return _porcentualDeposito; }
            set { _porcentualDeposito = value;}
        }
        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            numero = numeroConta;
            Titular = titular;
            Saldo = saldo;
            
        }
        public double Depositar(double BotarValor)
        {
            Saldo += BotarValor * (1 + PorcentualDeposito/100);
            return BotarValor;
        }
        public bool TemValor()
        {
            return Saldo > 0;
        }
        public double Sacar(double Saque)
        {
            if (TemValor() && Saque < Saldo)
            {
                Saldo -= (Saque + Taxa);
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
            Console.WriteLine($"Saldo atual: R${Saldo}");
        }
    }
}
