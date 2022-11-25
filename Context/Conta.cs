using LambruscoBank.Interface;

namespace LambruscoBank.Context
{
  public class Conta : Banco, IConta
  {
    public Conta()
    {
      NumeroAgencia = "0001";
      Conta.NumeroDaContaSequencial++;
      Movimentacoes = new List<Extrato>();
    }

    public double Saldo { get; protected set; }
    public string NumeroAgencia { get; private set; }
    public string NumeroConta { get; protected set; }
    public static int NumeroDaContaSequencial { get; private set; }
    private List<Extrato> Movimentacoes;
    public double ConsultaSaldo() => Saldo;

    public void Depositar(double valor)
    {
      Movimentacoes.Add(new Extrato(DateTime.Now, "Depósito", valor));
      Saldo += valor;
    }

    public bool Sacar(double valor)
    {
      if (valor > ConsultaSaldo()) return false;

      Movimentacoes.Add(new Extrato(DateTime.Now, "Saque", -valor));

      Saldo -= valor;
      return true;
    }

    public string GetCodigoBanco() => CodigoDoBanco;
    public string GetNumeroAgencia() => NumeroAgencia;
    public string GetNumeroConta() => NumeroConta;

    public List<Extrato> Extrato()
    {
      return Movimentacoes;
    }
  }
}