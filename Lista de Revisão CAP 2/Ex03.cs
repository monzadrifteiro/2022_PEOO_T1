using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite sua data de nascimento:");
    string data = Console.ReadLine();
    string[] partes = data.Split('/');
    int mes = int.Parse(partes[1]);
    switch(mes){
      case 01: Console.WriteLine("Você nasceu em janeiro"); break;
      case 02: Console.WriteLine("Você nasceu em fevereiro"); break;
      case 03: Console.WriteLine("Você nasceu em março"); break;
      case 04: Console.WriteLine("Você nasceu em abril"); break;
      case 05: Console.WriteLine("Você nasceu em maio"); break;
      case 06: Console.WriteLine("Você nasceu em junho"); break;
      case 07: Console.WriteLine("Você nasceu em julho"); break;
      case 08: Console.WriteLine("Você nasceu em agosto"); break;
      case 09: Console.WriteLine("Você nasceu em setembro"); break;
      case 10: Console.WriteLine("Você nasceu em outubro"); break;
      case 11: Console.WriteLine("Você nasceu em novembro"); break;
      case 12: Console.WriteLine("Você nasceu em dezembro"); break;
    }
  }
}