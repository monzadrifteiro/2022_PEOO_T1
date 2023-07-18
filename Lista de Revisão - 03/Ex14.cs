using System;
public class Program{
  public static void Main(string[] args){
    string a = Console.ReadLine();
    Console.WriteLine(Referencia(a));
  }
  public static string Referencia(string nome){
    int i = 0;
    string[] z = nome.Split();
    int x = z.Length;
    string resultado = z[x-1].ToUpper() + ", ";
    while(i < x-1){
      resultado += z[i].Substring(0, 1).ToUpper() + ". ";
      i++;
    }
    return resultado;
  }
}