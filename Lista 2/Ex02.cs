using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o seu nome completo:");
    string s = Console.ReadLine();
    string[] pnome = s.Split(' ');
    string nome = pnome[0];
    Console.WriteLine("Bem vindo ao C#, " + nome);
  }
}