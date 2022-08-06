using System;
public class Program{
  public static void Main(string[] args){
    string a = Console.ReadLine();
    Console.WriteLine(Iniciais(a));
  }
  public static string Iniciais(string nome){
    int i = 0;
    string[] z = nome.Split();
    int x = z.Length;
    string resultado = "";
    while(i < x){
      resultado += z[i].Substring(0, 1).ToUpper() + " ";
      i++;
    }
    return resultado;
  }
}