using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o nome e data de nascimento da 1 pessoa:");
    string nome1 = Console.ReadLine();
    string data1 = Console.ReadLine();
    string[] partes = data1.Split('/');
    int idade1 = 2022 - int.Parse(partes[2]);
    
    Console.WriteLine("Digite o nome e data de nascimento da 2 pessoa:");
    string nome2 = Console.ReadLine();
    string data2 = Console.ReadLine();
    string[] partes2 = data2.Split('/');
    int idade2 = 2022 - int.Parse(partes2[2]);

    if(idade1 < idade2){Console.WriteLine($"{nome1} é o(a) mais novo(a)");}
    if(idade2 < idade1){Console.WriteLine($"{nome2} é o(a) mais novo(a)");}
  }
}