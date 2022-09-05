using System;
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string operacao = Console.ReadLine();
    bool soma = operacao.Contains("+");
    bool subt = operacao.Contains("-");
    bool mult = operacao.Contains("*");
    bool divi = operacao.Contains("/");
    string[] s = operacao.Split();
    int resultado = 0;
      if (soma){
        s = operacao.Split("+");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        resultado = a + b;
      }
      if (subt){
        s = operacao.Split("-");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        resultado = a - b;
      }
      if (mult){
        s = operacao.Split("*");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        resultado = a * b;
      }
      if (divi){
        s = operacao.Split("/");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        resultado = a / b;
      }
    Console.WriteLine($"O resultado da operação é {resultado}");
  }
}