using LambruscoBank.Interface;

namespace LambruscoBank.Context
{
  public class Pessoa
  {
    public Pessoa(string nome, string cpf, string senha)
    {
      Nome = nome;
      CPF = cpf;
      Senha = senha;
    }
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public string Senha { get; private set; }
    public IConta Conta { get; set; }

    // public void SetNome(string nome) => Nome = nome;
    // public void SetCPF(string cpf) => CPF = cpf;
    // public void SetSenha(string senha) => Senha = senha;
  }
}