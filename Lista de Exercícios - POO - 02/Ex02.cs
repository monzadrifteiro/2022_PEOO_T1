using System;
public class Program {
  public static void Main(string[] args) {
    Disciplina linda = new Disciplina();
    Console.WriteLine("Digite o nome da disciplina: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a nota do primeiro bimestre: ");
    linda.SetNota1(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a nota do segundo bimestre: ");
    linda.SetNota2(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a nota do terceiro bimestre: ");
    linda.SetNota3(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a nota do quarto bimestre: ");
    linda.SetNota4(int.Parse(Console.ReadLine()));
    Console.WriteLine($"A média parcial em {nome} foi: {linda.CalcMediaParcial()}");
      if(linda.CalcMediaParcial() < 60){
        Console.WriteLine("Digite a nota da prova final: ");
        linda.SetNotaFinal(int.Parse(Console.ReadLine()));
        if(linda.CalcMediaFinal() >= 60){Console.WriteLine($"A média final em {nome} foi: {linda.CalcMediaFinal()}");}
        else{
          Console.WriteLine($"A média final em {nome} foi: {linda.CalcMediaFinal()}. VOCÊ FOI REPROVADO!!!");
        }
      }
    linda.SetMateria(nome);
  }
  class Disciplina{
    private string materia;
    private int nota1;
    private int nota2;
    private int nota3;
    private int nota4;
    private int notaFinal;
    public void SetMateria (string s){
      if(s != ""){materia = s;}
    }
    public void SetNota1 (int t){
      if(t >= 0 && t <= 100){nota1 = t;}
    }
    public void SetNota2 (int t){
      if(t >= 0 && t <= 100){nota2 = t;}
    }
    public void SetNota3 (int t){
      if(t >= 0 && t <= 100){nota3 = t;}
    }
    public void SetNota4 (int t){
      if(t >= 0 && t <= 100){nota4 = t;}
    }
    public void SetNotaFinal (int t){
      if(t >= 0 && t <= 100){notaFinal = t;}
    }
    public string GetMateria(){
      return materia;
    }
    public int GetNota1(){
      return nota1;
    }
    public int GetNota2(){
      return nota2;
    }
    public int GetNota3(){
      return nota3;
    }
    public int GetNota4(){
      return nota4;
    }
    public int GetNotaFinal(){
      return notaFinal;
    }
    public int CalcMediaParcial(){
      int parcial = ((nota1 * 2) + (nota2 * 2) + (nota3 * 3) + (nota4 * 3)) / 10;
        return parcial;
    }
    public int CalcMediaFinal(){
      int final = (CalcMediaParcial() + notaFinal) / 2;
        return final;
    }
  }
}