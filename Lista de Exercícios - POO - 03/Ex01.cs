using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor da Base e da Altura: ");
    Retangulo lindo = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor da aréa é: {lindo.CalcArea()}");
    Console.WriteLine($"O valor da diagonal é: {lindo.CalcDiagonal():0.00}");
    Console.WriteLine(lindo.ToString());
  }
}
class Retangulo{
  private double b;
  private double h;
  public Retangulo(double b, double h){
    this.b = b;
    this.h = h;
  }
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
  public override string ToString(){
    return $"A base do retângulo é {b} e a altura é {h}";
  }
}