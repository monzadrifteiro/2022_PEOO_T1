using System; 
public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(a));
  }
  public static double VolumeEsfera(double r){
    return 4 * 3.14 * Math.Pow(r, 3) / 3;
  }
}