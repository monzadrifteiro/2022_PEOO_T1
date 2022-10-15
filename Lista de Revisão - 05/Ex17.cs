using System;
public class Program {
  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(MMC(a, b));
  }
  public static int MMC(int x, int y) {
    int m = 1;
    while (!(m % x == 0 && m % y == 0)){
      m++;
    } 
    return m;
  }
}