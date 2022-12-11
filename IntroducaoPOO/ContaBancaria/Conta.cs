namespace ContaBancaria
{
  class Conta {
    public double Saldo { get; private set; }
    public string NomeTitular { get; set; }
    protected int NumeroConta { get; private set; }

     public Conta (int numeroConta, string nomeTitular) {
      NumeroConta = numeroConta;
      NomeTitular = nomeTitular;
      Saldo = 0 ;
     }

    public Conta(int numeroConta, string nomeTitular, double saldo)
    {
      NumeroConta = numeroConta;
      NomeTitular = nomeTitular;
      Deposito(saldo);
    }

     public void Deposito(double valor){
      Saldo += valor;
     }

    public void Saque(double valor)
    {
      Saldo -= (valor + 5);
    }
    
    public override string ToString(){
      return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: $ {Saldo.ToString("F2")}";
    }
  }
}