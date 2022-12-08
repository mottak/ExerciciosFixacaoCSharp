namespace StatusAluno
{
  class Aluno {
    public string nome;
    public double nota1;
    public double nota2;
    public double nota3;

    public double NotaFinal(){
      return this.nota1 + this.nota2 + this.nota3;
    }
    public double NotaRestante()
    {
      return 100 - this.NotaFinal();
    }

    
  }
}