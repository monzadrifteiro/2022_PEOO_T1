using System; 

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] z = s.Split(' ');
    double a = double.Parse(z[0]);
    double b = double.Parse(z[1]);
    double c = double.Parse(z[2]);
    double r1 = 0.0;
    double r2 = 0.0;
    
    double delta = Math.Pow(b,2) - 4 * a * c;
    if (delta < 0 || delta == 0 || a == 0){
      Console.WriteLine("Impossivel calcular");
    }
    
     else
     {
        r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        r2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"R1 = {r1:0.00000}");
        Console.WriteLine($"R2 = {r2:0.00000}");
    }
  }
}