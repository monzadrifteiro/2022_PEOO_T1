using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores:");
    int a =int.Parse(Console.ReadLine());
    int b =int.Parse(Console.ReadLine());
    int c =int.Parse(Console.ReadLine());

    int maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;

    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
  
    int meio = 0;

    if (a != menor && a != maior)meio = a;
    if (b != menor && b != maior)meio = b;
    if (c != menor && c != maior)meio = c;

    Console.WriteLine($"{menor}, {meio}, {maior}");
  }
}