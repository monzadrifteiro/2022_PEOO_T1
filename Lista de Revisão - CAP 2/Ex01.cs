using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite a sua data de nascimento:");
    string data = Console.ReadLine();
    string[] partes = data.Split('/');
    int idade = 2022 - int.Parse(partes[2]);
    Console.WriteLine($"No final de 2022, você terá {idade} anos");
  }
}