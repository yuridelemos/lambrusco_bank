namespace LambruscoBank.Context
{
  public abstract class Banco
  {
    public Banco()
    {
      NomeDoBanco = "LambruscoBank";
      CodigoDoBanco = "369";
    }
    public string NomeDoBanco { get; private set; }
    public string CodigoDoBanco { get; private set; }
  }
}