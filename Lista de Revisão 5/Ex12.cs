using System; 
public class Program {
  public static void Main(string[] args) {
    string a = Console.ReadLine();
    Console.WriteLine(Senha(a));
  }
  public static string Senha(string texto){
    string[] s = texto.Split(' ');
    int f = s.Length;
    int c = 0;
    string z = "";
    while(c < f){
      string v = s[c].Length.ToString();
      z += v;
      c++;
    }
    return z;
  }
}