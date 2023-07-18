using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int a =int.Parse(Console.ReadLine());
    int b =int.Parse(Console.ReadLine());
    int c =int.Parse(Console.ReadLine());
    int d =int.Parse(Console.ReadLine());

    int numerosp = 0;
    int numerosi = 0;

    if (a % 2 == 0){numerosp = numerosp + a;}
    else{numerosi = numerosi + a;}

    if (b % 2 == 0){numerosp = numerosp + b;}
    else{numerosi = numerosi + b;}

    if (c % 2 == 0){numerosp = numerosp + c;}
    else{numerosi = numerosi + c;}

    if (d % 2 == 0){numerosp = numerosp + d;}
    else{numerosi = numerosi + d;}

    Console.WriteLine("Soma dos pares = " + numerosp);
    Console.WriteLine("Soma dos ímpares = " + numerosi);
  }
}