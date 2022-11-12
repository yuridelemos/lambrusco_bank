namespace LambruscoBank.Context
{
  public class ContaCorrente : Conta
  {
    public ContaCorrente()
    {
      NumeroConta = $"00{Conta.NumeroDaContaSequencial}";
    }
  }
}