using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite dois números inteiros:");
    int numero1 = int.Parse(Console.ReadLine());
    int numero2 = int.Parse(Console.ReadLine());
    int soma = numero1 + numero2;
    Console.WriteLine($"Soma = {soma}");
  }
}