using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite a quantidade de alunos:");
    int alunos = int.Parse(Console.ReadLine());
    int soma = 0;
    Console.WriteLine("Digite as notas dos alunos:");
    for(int i = 0; i < alunos; i++){
      soma += int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Média das notas = {soma / alunos}");
  }
}