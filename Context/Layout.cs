namespace LambruscoBank.Context
{
  public class Layout
  {
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
    }
  }
}