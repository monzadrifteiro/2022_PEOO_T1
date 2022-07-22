using System; 
public class Program {
  public static void Main(string[] args) {
    double massa = double.Parse(Console.ReadLine());
    double distancia= double.Parse(Console.ReadLine());
    Console.WriteLine(Frete(massa, distancia));
  }
  public static double Frete(double massa, double distancia){
    return massa * distancia / 100;
  }
}