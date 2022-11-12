namespace LambruscoBank.Interface
{
  public interface IConta
  {
    void Depositar(double valor);
    bool Sacar(double valor);
    double ConsultaSaldo();
    string GetCodigoBanco();
    string GetNumeroAgencia();
    string GetNumeroConta();

  }
}