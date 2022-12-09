namespace ConversorMoeda
{
  class ConverteMoeda
  {
    public static double IOF = 0.06;
    
    public static double ConversaoReal(double cotacaoDolar, double qtdDolar)
    {
      double valorEmReais = cotacaoDolar * qtdDolar;
      return valorEmReais + (valorEmReais * IOF);

    }
  
  }
}