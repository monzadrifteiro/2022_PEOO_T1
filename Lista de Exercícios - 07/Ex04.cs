using System;
public class Program{
  public static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(Aprovado(a, b));
  }
  public static bool Aprovado(int nota1, int nota2){
    int notafinal = (nota1 + nota2) / 2;
    if(notafinal >= 60){return true;}
    else{return false;}
  }
}