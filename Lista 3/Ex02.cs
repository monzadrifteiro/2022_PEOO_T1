using System; 
public class Program {
  public static void Main(string[] args) {
    
    double valor1 = double.Parse(Console.ReadLine());
    double valor2 = double.Parse(Console.ReadLine());
    
    double media = (valor1 * 3.5 + valor2 * 7.5)/11;
    Console.WriteLine($"MEDIA = {media:0.00000}");
  }
}