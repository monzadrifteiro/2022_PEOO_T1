using System; 
public class Program {
public static void Main(string[] args) {
  
  double tempo = double.Parse(Console.ReadLine());
  double velocidade = double.Parse(Console.ReadLine());

  double litros = tempo * velocidade / 12;
  Console.WriteLine($"{litros:0.000}");
  }
}