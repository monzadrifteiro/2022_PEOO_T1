using System; 
public class Program {
  public static void Main(string[] args) {
    string linha1 = Console.ReadLine();
    string[] a = linha1.Split();
    
    double x1 = double.Parse(a[0]);
    double y1 = double.Parse(a[1]);
    
    string linha2 = Console.ReadLine();
    string[] b = linha2.Split();
    
    double x2 = double.Parse(b[0]);
    double y2 = double.Parse(b[1]);
    
    double saida= Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
    Console.WriteLine($"{saida:0.0000}");
  }
}