namespace SalarioFuncionario
{
  class Funcionario
  {
    public string? Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido(){
      return this.SalarioBruto - this.Imposto;
    }

    public void AumentarSalario(double porcentagem) {
       this.SalarioBruto *= (1 + (porcentagem/100 ));
    }
  }
}