using System;
public class Program{
  public static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(Primo(a));
  }
  public static bool Primo(int n){
    int i = 2;
    while(i < n){
      if(n % i == 0){return false;}    
      i++;
    }
    return true;
  }
}