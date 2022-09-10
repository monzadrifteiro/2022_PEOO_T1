using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite três números inteiros:");
    int numero1 = int.Parse(Console.ReadLine());
    int numero2 = int.Parse(Console.ReadLine());
    int numero3 = int.Parse(Console.ReadLine());
    int soma = numero1 + numero2 + numero3;
    int menor = Math.Min(numero1, numero2);
    int menorreal= Math.Min(numero3, menor);
    soma = soma - menorreal;
    Console.WriteLine($"Soma dos dois maiores = {soma}");
  }
}