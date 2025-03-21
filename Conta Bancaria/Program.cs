using Conta_Bancaria;
using System.Diagnostics.Contracts;

class Program
{
    public static void Main(String[] args)
    {
        try
        {
            int loop = 0;
            List<ContaCorrente> contasCC = new List<ContaCorrente>();
            List<ContaPoupanca> contaCP = new List<ContaPoupanca>();

            Console.WriteLine("Digite o numero para: ");
            Console.WriteLine("1 - Conta corrente.");
            Console.WriteLine("2 - Conta Poupança");
            int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        while (loop == 0)
                        {

                            OpçoesBanco();
                            opcao = Convert.ToInt32(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine("Digite o seu nome: ");
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("Insira o valor do saldo: ");
                                    double saldo = Convert.ToDouble(Console.ReadLine());
                                    int numConta = contasCC.Count() + 1;
                                    ContaCorrente ContaCO = new ContaCorrente(numConta, nome, saldo);
                                    contasCC.Add(ContaCO);
                                    DigitarContinuar();
                                    break;

                                case 2:
                                    foreach (var conta in contasCC)
                                    {
                                        Console.WriteLine(conta.numero);
                                    }
                                    int escolha = int.Parse(Console.ReadLine());
                                    ContaCO = contasCC.FirstOrDefault(x => x.numero == escolha);
                                    if (ContaCO == null)
                                    {
                                        Console.WriteLine("Conta Invalida");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira o valor que deseja depositar: ");
                                        double DepositoCO = Convert.ToDouble(Console.ReadLine());
                                        ContaCO.Depositar(DepositoCO);
                                        DigitarContinuar();
                                    }
                                    break;
                                case 3:
                                    foreach (var conta in contasCC)
                                    {
                                        Console.WriteLine(conta.numero);
                                    }
                                    escolha = int.Parse(Console.ReadLine());
                                    ContaCO = contasCC.FirstOrDefault(x => x.numero == escolha);
                                    if (ContaCO == null)
                                    {
                                        Console.WriteLine("Conta Invalida");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira o valor que deseja sacar: ");
                                        double SacarCO = Convert.ToDouble(Console.ReadLine());
                                        ContaCO.Sacar(SacarCO);
                                        DigitarContinuar();
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Conta corrente: ");
                                    foreach (var conta in contasCC)
                                    {
                                        Console.WriteLine(conta.numero);
                                    }
                                    escolha = int.Parse(Console.ReadLine());
                                    ContaCO = contasCC.FirstOrDefault(x => x.numero == escolha);
                                    if (ContaCO == null)
                                    {
                                        Console.WriteLine("Conta Invalida");
                                    }
                                    Console.WriteLine($"Conta nª{ContaCO.numero}");

                                    Console.WriteLine($"Nome: {ContaCO.Titular}");
                                    Console.WriteLine($"Saldo : R${ContaCO.Saldo}");

                                Console.WriteLine("Digite 0 para continuar");
                                loop = Convert.ToInt32(Console.ReadLine());
                                    DigitarContinuar();
                                    break;
                                default:
                                    Console.WriteLine("Numero invalido.");
                                    DigitarContinuar();
                                    break;
                            }
                        }

                        break;





                    case 2:
                        while (loop == 0)
                        {
                            OpçoesBanco();
                            opcao = Convert.ToInt32(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine("Digite o seu nome: ");
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("Insira o valor do saldo: ");
                                    double saldo = Convert.ToDouble(Console.ReadLine());
                                    int numConta = contaCP.Count() + 1;
                                    ContaPoupanca ContaPO = new ContaPoupanca(numConta, nome, saldo);
                                    contaCP.Add(ContaPO);
                                    DigitarContinuar();
                                    break;
                                case 2:
                                    foreach (var conta in contaCP)
                                    {
                                        Console.WriteLine(conta.numero);
                                    }
                                    int escolha = Convert.ToInt32(Console.ReadLine());
                                    ContaPO = contaCP.FirstOrDefault(x => x.numero == escolha);
                                    if (ContaPO == null)
                                    {
                                        Console.WriteLine("Conta Invalida");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Digite um valor que deseja depositar: ");
                                        double DepositoPO = Convert.ToDouble(Console.ReadLine());
                                        ContaPO.Depositar(DepositoPO);
                                        DigitarContinuar();
                                    }
                                    break;
                                case 3:
                                    foreach (var conta in contaCP)
                                    {
                                        Console.WriteLine(conta.numero);
                                    }
                                    escolha = Convert.ToInt32(Console.ReadLine());
                                    ContaPO = contaCP.FirstOrDefault(x => x.numero == escolha);
                                    if (ContaPO == null)
                                    {
                                        Console.WriteLine("Conta Invalida");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insira o valor que deseja sacar: ");
                                        double SacarPO = Convert.ToDouble(Console.ReadLine());
                                        ContaPO.Sacar(SacarPO);
                                        DigitarContinuar();
                                    }
                                    break;
                                case 4:
                                    foreach (var conta in contaCP)
                                    {
                                        Console.WriteLine(conta.numero);
                                    }
                                    escolha = Convert.ToInt32(Console.ReadLine());
                                    ContaPO = contaCP.FirstOrDefault(x => x.numero == escolha);
                                    if (ContaPO == null)
                                    {
                                        Console.WriteLine("Conta Invalida");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Conta poupança: ");
                                        ContaPO.ExibirSaldo();
                                    Console.WriteLine("Digite 0 para continuar");
                                        loop = Convert.ToInt32(Console.ReadLine());
                                        DigitarContinuar();
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Numero invalido.");
                                    DigitarContinuar();
                                    break;
                            }
                        }
                        break;
                }
                Console.WriteLine("Obrigado por usar nosso serviços.");
                DigitarContinuar();
            
        }


        catch (FormatException)
        {
            Console.WriteLine("Formato indisponível.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }



         static void DigitarContinuar()
        {
            Console.WriteLine("Digite algo para continuar: ");
            Console.ReadLine();
            Console.Clear();
        }

        static void OpçoesBanco()
        {
            Console.WriteLine("Digite o numero para: ");
            Console.WriteLine("1 - Inserir uma conta");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Ver saldo");
        }
    }
}
