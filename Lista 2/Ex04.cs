using System; 
public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor da base:");
    string s = Console.ReadLine();
    double b = double.Parse(s);

    Console.WriteLine("Digite o valor da altura:");
    string r = Console.ReadLine();
    double h = double.Parse(r);

    double area = b * h;
    Console.WriteLine($"Área = {area:0.00}");

    double perimetro = (b * 2) + (h * 2);
    Console.WriteLine($"Perimetro = {perimetro:0.00}");

    double diagonal= Math.Sqrt(Math.Pow(b,2) + Math.Pow(h,2));
    Console.WriteLine($"Diagonal = {diagonal:0.00}");
  }
}