using SalarioNoMes.Entities;
using SalarioNoMes.Entities.Enums;


namespace SalarioNoMes.Entities
{
  class Worker {
    public string Name {get; set;}
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }

    public List<HourContract> Contracts { get; set; } = new List<HourContract>();
    
    public Department Department { get; set; } 
    /* Para realizar a composição é necessario declarar uma
    propriedade com o tipo da mesma da composição
    Ou seja aqui estou associando a classe Worker e a classe Department
    */ 
  
  public Worker()
  {
  }

  /* Sempre que existir uma associação de um-muitos ela nbão é incluida no construtor*/
  public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
    Name = name;
    Level = level;
    BaseSalary = baseSalary;
    Department = department;
  }
  public void AddContract(HourContract contract){
    Contracts.Add(contract);
  }
  public void RemoveContract(HourContract contract)
  {
    Contracts.Remove(contract);
  }
  public double Income(int year, int month){
    double sum = BaseSalary;
    foreach(HourContract contract in Contracts)
    {
      if(contract.Date.Year == year && contract.Date.Month == month){
        sum += contract.TotalValue();
      }
    }
    return sum;
  }
  }
}