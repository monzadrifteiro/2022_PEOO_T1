using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int n1 =int.Parse(Console.ReadLine());
    int n2 =int.Parse(Console.ReadLine());
    int n3 =int.Parse(Console.ReadLine());
    int n4 =int.Parse(Console.ReadLine());

    int notaf= (n1 + n2 + n3 + n4) / 4;
    Console.WriteLine("Média = " + notaf);
    
    Console.WriteLine("Números menores que a média");
    if (n1 < notaf) {Console.WriteLine(n1);}
    if (n2 < notaf) {Console.WriteLine(n2);}
    if (n3 < notaf) {Console.WriteLine(n3);}
    if (n4 < notaf) {Console.WriteLine(n4);}

    Console.WriteLine("Números maiores que a média");
    if (n1 > notaf) {Console.WriteLine(n1);}
    if (n2 > notaf) {Console.WriteLine(n2);}
    if (n3 > notaf) {Console.WriteLine(n3);}
    if (n4 > notaf) {Console.WriteLine(n4);}
  }
}