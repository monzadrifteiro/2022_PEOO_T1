using System;
public class Program{
  public static void Main(string[] args){
    string a = Console.ReadLine();
    Console.WriteLine(FormatarNome(a));
  }
  public static string FormatarNome(string nome){
    nome = nome.ToLower();
    string nomef = "";
    string[] z = nome.Split();
    int x = z.Length;
    int i = 0;
    while(i < x){
    nomef = nomef + z[i].Substring(0, 1).ToUpper() + z[i].Substring(1) + " ";
    i++;
    }
    return nomef;
  }
}