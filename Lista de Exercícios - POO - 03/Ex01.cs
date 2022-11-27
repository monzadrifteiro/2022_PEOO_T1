using System; 
public class Program {
  public static void Main(string[] args) {
    Retangulo lindo = new Retangulo();
    Console.WriteLine("Digite o valor da Base: ");
    lindo.SetBase(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o valor da Altura: ");
    lindo.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor da aréa é: {lindo.CalcArea()}");
    Console.WriteLine($"O valor da diagonal é: {lindo.CalcDiagonal():0.00}");
  }
}
class Retangulo{
  private double b;
  private double h;
  public void SetBase(double b){
    if(b > 0) this.b = b;
  }
  public void SetAltura(double h){
    if(h > 0) this.h = h;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    return b * h;
  }
  public double CalcDiagonal(){
    return Math.Sqrt(b * b + h * h);
  }
}