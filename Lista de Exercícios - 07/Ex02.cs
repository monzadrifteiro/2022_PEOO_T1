using System; 
public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine(Maior(a, b, c));
  }
  public static double Maior(double x, double y, double z){
    double j = Math.Max(x, y);
    double k = Math.Max(z, j);
    return k;
  }
}