using Conta_Bancaria;

class Program
{
    public static void Main(String[] args)
    {
        try
        {
            int senha = 0;
            string Nome = "";
            double saldo = 0;
            ContaCorrente ContaCO = new ContaCorrente(senha, Nome, saldo);
            ContaPoupanca ContaPO = new ContaPoupanca(senha, Nome, saldo);
            int loop = 0;
            Console.WriteLine("Digite o numero para: ");
            Console.WriteLine("1 - Conta corrente.");
            Console.WriteLine("2 - Conta Poupança");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    while(loop == 0)
                    {
                        OpçoesBanco();
                        opcao = Convert.ToInt32(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.WriteLine("Digite o seu nome: ");
                                Nome = Console.ReadLine();
                                Console.WriteLine($"Usuário {Nome} inserido com sucesso.");
                                DigitarContinuar();
                                break;
                            case 2:
                                Console.WriteLine("Digite uma senha: ");
                                senha = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Senha inserida com sucesso.");
                                DigitarContinuar();
                                break;
                            case 3:

                                Console.WriteLine("Insira o valor do saldo: ");
                                saldo = Convert.ToDouble(Console.ReadLine());
                                ContaCO = new ContaCorrente(senha, Nome, saldo);
                                Console.WriteLine($"O valor {saldo} foi inserido com sucesso.");
                                DigitarContinuar();
                                break;
                            case 4:
                                Console.WriteLine("Digite a senha: ");
                                int senha2 = Convert.ToInt32(Console.ReadLine());
                                if (senha2 == senha)
                                {
                                    Console.WriteLine("Senha inserida com sucesso");
                                    Console.WriteLine("Insira o valor que deseja depositar: ");
                                    double DepositoCO = Convert.ToDouble(Console.ReadLine());
                                    ContaCO.Depositar(DepositoCO);
                                    DigitarContinuar();
                                }
                                else
                                {
                                    Console.WriteLine("Senha errada.");
                                    DigitarContinuar();
                                }
                                break;
                            case 5:
                                Console.WriteLine("Digite a senha: ");
                                senha2 = Convert.ToInt32(Console.ReadLine());
                                if (senha2 == senha)
                                {
                                    Console.WriteLine("Senha inserida com sucesso");
                                    Console.WriteLine("Insira o valor que deseja sacar: ");
                                    double SacarCO = Convert.ToDouble(Console.ReadLine());
                                    ContaCO.SacarCorrente(SacarCO);
                                    DigitarContinuar();
                                }
                                else
                                {
                                    Console.WriteLine("Senha errada");
                                    DigitarContinuar();
                                }
                                break;
                            case 6:
                                Console.WriteLine("Conta corrente: ");
                                ContaCO.ExibirSaldo();
                                Console.WriteLine("Digite 0 para continuar ou qualquer outro numero para sair");
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
                                Nome = Console.ReadLine();
                                Console.WriteLine($"Usuário {Nome} inserido com sucesso.");
                                DigitarContinuar();
                                break;
                            case 2:
                                Console.WriteLine("Digite uma senha: ");
                                senha = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Senha inserida com sucesso.");
                                DigitarContinuar();
                                break;
                            case 3:
                                Console.WriteLine("Insira o valor do saldo: ");
                                saldo = Convert.ToDouble(Console.ReadLine());
                                ContaPO = new ContaPoupanca(senha, Nome, saldo);
                                Console.WriteLine($"O valor {saldo} foi inserido com sucesso.");
                                DigitarContinuar();
                                break;
                            case 4:
                                Console.WriteLine("Digite a senha: ");
                                int senha2 = Convert.ToInt32(Console.ReadLine());
                                if (senha2 == senha)
                                {
                                    Console.WriteLine("Senha inserida com sucesso");
                                    Console.WriteLine("Digite um valor que deseja depositar: ");
                                    double DepositoPO = Convert.ToDouble(Console.ReadLine());
                                    ContaPO.DepositarPoupança(DepositoPO);
                                    DigitarContinuar();
                                }
                                else
                                {
                                    Console.WriteLine("Senha errada.");
                                    DigitarContinuar();
                                }
                                break;
                            case 5:
                                Console.WriteLine("Digite a senha: ");
                                senha2 = Convert.ToInt32(Console.ReadLine());
                                if (senha2 == senha)
                                {
                                    Console.WriteLine("Senha inserida com sucesso");
                                    Console.WriteLine("Insira o valor que deseja sacar: ");
                                    double SacarPO = Convert.ToDouble(Console.ReadLine());
                                    ContaPO.Sacar(SacarPO);
                                    DigitarContinuar();
                                }
                                else
                                {
                                    Console.WriteLine("Senha errada.");
                                }
                                break;
                            case 6:
                                Console.WriteLine("Conta poupança: ");
                                ContaPO.ExibirSaldo();
                                Console.WriteLine("Digite 0 para continuar ou qualquer outro numero para sair");
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
    }

    private static void DigitarContinuar()
    {
        Console.WriteLine("Digite algo para continuar: ");
        Console.ReadLine();
        Console.Clear();
    }

    private static void OpçoesBanco()
    {
        Console.WriteLine("Digite o numero para: ");
        Console.WriteLine("1 - Inserir nome");
        Console.WriteLine("2 - Inserir senha");
        Console.WriteLine("3 - Inserir saldo");
        Console.WriteLine("4 - Depositar");
        Console.WriteLine("5 - Sacar");
        Console.WriteLine("6 - Ver saldo.");
    }
}