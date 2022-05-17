using System; 
public class Program {
  public static void Main(string[] args) {
    string s = Console.ReadLine();
    int valora = int.Parse(s);
    int valorb = int.Parse(Console.ReadLine());
    int produto = valora * valorb;
    Console.WriteLine($"PROD = {produto}");
  }
}