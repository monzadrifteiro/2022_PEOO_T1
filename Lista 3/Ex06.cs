using System; 
public class Program {
  public static void Main(string[] args) {
    string tomadas = Console.ReadLine();
    string[] a = tomadas.Split();
    int t1 = int.Parse(a[0]);
    int t2 = int.Parse(a[1]);
    int t3 = int.Parse(a[2]);
    int t4 = int.Parse(a[3]);
    int max= (t1 + t2 + t3 + t4) - 3;
    Console.WriteLine(max);
  }
}