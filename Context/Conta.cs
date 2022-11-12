using LambruscoBank.Interface;

namespace LambruscoBank.Context
{
  public class Conta : Banco, IConta
  {
    public Conta()
    {
      NumeroConta = "0001";
      Conta.NumeroDaContaSequencial++;
    }

    public double Saldo { get; protected set; }
    public string NumeroAgencia { get; private set; }
    public string NumeroConta { get; protected set; }
    public static int NumeroDaContaSequencial { get; private set; }
    public double ConsultaSaldo() => Saldo;

    public void Depositar(double valor) => Saldo += valor;

    public bool Sacar(double valor)
    {
      if (valor > ConsultaSaldo()) return false;

      Saldo -= valor;
      return true;
    }

    public string GetCodigoBanco() => CodigoDoBanco;
    public string GetNumeroAgencia() => NumeroAgencia;
    public string GetNumeroConta() => NumeroConta;
  }
}