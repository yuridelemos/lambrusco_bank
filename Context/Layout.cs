namespace LambruscoBank.Context
{
  public class Layout
  {
    public static List<Pessoa> pessoas = new List<Pessoa>();
    private static int Opcao = 0;
    public static void TelaPrincipal()
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;

      Console.Clear();

      System.Console.WriteLine("\t Digite a opção desejada");
      System.Console.WriteLine("\t==========================");
      System.Console.WriteLine("\t    1 - Criar Conta");
      System.Console.WriteLine("\t==========================");
      System.Console.WriteLine("\t2 - Entrar com CPF e Senha");
      System.Console.WriteLine("\t==========================");
      System.Console.Write("\t Escolher opção desejada: ");

      Opcao = int.Parse(System.Console.ReadLine());

      switch (Opcao)
      {
        case 1:
          TelaCriarConta();
          break;
        case 2:
          TelaLogin();
          break;
        default:
          System.Console.WriteLine("Opção inválida");
          break;
      }
    }

    private static void TelaCriarConta()
    {
      Console.Clear();

      System.Console.Write("\t Digite o seu nome: ");
      string nome = Console.ReadLine();
      System.Console.WriteLine("\t==========================");
      System.Console.Write("\t Digite o seu CPF: ");
      string CPF = Console.ReadLine();
      System.Console.WriteLine("\t==========================");
      System.Console.Write("\t Digite a sua senha: ");
      string senha = Console.ReadLine();
      System.Console.WriteLine("\t==========================");

      ContaCorrente contaCorrente = new ContaCorrente();
      Pessoa pessoa = new Pessoa(nome, CPF, senha);

      // pessoa.SetNome(nome);
      // pessoa.SetCPF(nome);
      // pessoa.SetSenha(nome);
      pessoa.Conta = contaCorrente;

      pessoas.Add(pessoa);

      Console.Clear();

      System.Console.WriteLine("\t============================");
      System.Console.Write("\tConta Cadastrada com Sucesso ");
      System.Console.WriteLine("\t============================");

      Thread.Sleep(2000);
      TelaContaLogada(pessoa);
    }

    private static void TelaLogin()
    {
      Console.Clear();
      System.Console.Write("\t Digite o seu CPF: ");
      string CPF = Console.ReadLine();
      System.Console.WriteLine("\t==========================");
      System.Console.Write("\t Digite a sua senha: ");
      string senha = Console.ReadLine();
      System.Console.WriteLine("\t==========================");

      Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == CPF && x.Senha == senha);
      if (pessoa != null)
      {
        TelaBoasVindas(pessoa);
        TelaContaLogada(pessoa);
      }
      else
      {
        Console.Clear();
        System.Console.WriteLine("\t============================");
        System.Console.Write("\t Pessoa nao cadastrada");
        System.Console.WriteLine("\t============================");

      }
    }

    private static void TelaBoasVindas(Pessoa pessoa)
    {
      string msgTelaBemVindo =
      $"{pessoa.Nome} " +
      $"| Banco: {pessoa.Conta.GetCodigoBanco()} " +
      $"| Agencia: {pessoa.Conta.GetNumeroAgencia()}" +
      $"| Conta: {pessoa.Conta.GetNumeroConta()}";
      System.Console.WriteLine($"\n\tSeja bem-vindo, {msgTelaBemVindo}");
    }

    private static void TelaContaLogada(Pessoa pessoa)
    {
      Console.Clear();
      TelaBoasVindas(pessoa);
      System.Console.WriteLine("\t============================");
      System.Console.WriteLine("\tDigite a Opcao desejada: ");
      System.Console.WriteLine("\t1- Realizar um deposito");
      System.Console.WriteLine("\t2- Realizar um saque");
      System.Console.WriteLine("\t3- Consultar o saldo");
      System.Console.WriteLine("\t4- Extrato");
      System.Console.WriteLine("\t5- Sair");
      System.Console.WriteLine("\t============================");

      Opcao = int.Parse(Console.ReadLine());
      switch (Opcao)
      {
        case 1:
          break;
        case 2:
          break;
        case 3:
          break;
        case 4:
          break;
        case 5:
          TelaPrincipal();
          break;
        default:
          Console.Clear();
          System.Console.WriteLine("Opcao inválida");
          break;
      }
    }
  }
}