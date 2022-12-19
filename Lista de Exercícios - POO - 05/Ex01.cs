using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor da base e da altura do retângulo");
    Retangulo lindo = new Retangulo {Base = double.Parse(Console.ReadLine()), Altura = double.Parse(Console.ReadLine())};
    Console.WriteLine(lindo.ToString());
    Console.WriteLine($"A área do retângulo é {lindo.Area}");
    Console.WriteLine($"A diagonal do retângulo é {lindo.Diagonal:0.00}");
  }
}
class Retangulo{
  private double b, h;
  public double Base{
    set { if(value > 0) b = value; }
    get { return b; }
  }
  public double Altura{
    set { if(value > 0) h = value; }
    get { return h; }
  }
  public double Area{
    get { return b * h; }
  }
  public double Diagonal{
    get { return Math.Sqrt(b * b + h * h); }
  }
  public override string ToString(){
    return $"A base do retângulo é {b} e a altura é {h}";
  }
}