using System; 
public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Maior(a, b));
  }
  public static double Maior(double x, double y){
    return Math.Max(x, y);
  }
}