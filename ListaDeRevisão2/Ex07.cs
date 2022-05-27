using System; 
public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double r1 = 0.0;
    double r2 = 0.0;
    
    double delta = Math.Pow(b,2) - 4 * a * c;
    
    if (delta < 0 || delta == 0 || a == 0){
      Console.WriteLine("Impossivel calcular");
    }
    
     else{
        r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        r2 = (-b - Math.Sqrt(delta)) / (2 * a);
       
        Console.WriteLine($"As raízes são {r1:0} e {r2:0}");
    }
  }
}