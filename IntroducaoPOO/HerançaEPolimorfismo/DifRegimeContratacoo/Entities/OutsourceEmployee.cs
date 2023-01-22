using DifRegimeContratacao.Entities;

namespace DifRegimeContratacao.Entities
{
  class OutSourcedEmployee : Employee
  {
   double AdicionalCharge { get; set; }
    public OutSourcedEmployee()
    {
    }

    public OutSourcedEmployee(string name, int hours, double valuePerHour, double adicionalCharge) : base(name, hours, valuePerHour)
    {
      adicionalCharge = AdicionalCharge;
    }

    public double Payment()
    {
      double regularPayment = base.Payment();
      return regularPayment + (AdicionalCharge * 1.1);
    }
  }
}