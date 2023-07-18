using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int a =int.Parse(Console.ReadLine());
    int b =int.Parse(Console.ReadLine());
    int c =int.Parse(Console.ReadLine());
    int d =int.Parse(Console.ReadLine());

    if (a == b || a == c || a == d || b == c || b == d || c == d){Console.WriteLine("ERRO: NÚMEROS IGUAIS");}
    else{

    int maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    if (d > maior) maior = d;
    Console.WriteLine("Maior valor = " + maior);

    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    if (d < menor) menor = d;
    Console.WriteLine("Menor valor = " + menor);

    int sm1 = 0;
    int sm2 = 0;
    
    if (a != menor && a != maior)sm1 = a;
    if (b != menor && b != maior)sm1 = b;
    if (c != menor && c != maior)sm1 = c;
    if (d != menor && d != maior)sm1 = d;

    if (a != menor && a != maior && a != sm1)sm2 = a;
    if (b != menor && b != maior && b != sm1)sm2 = b;
    if (c != menor && c != maior && c != sm1)sm2 = c;
    if (d != menor && d != maior && d != sm1)sm2 = d;

    int soma = (sm1 + sm2);
    Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + soma);
    }
  }
}