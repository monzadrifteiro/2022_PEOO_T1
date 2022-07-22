using System; 
public class Program {
  public static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int a = 0;
    int b = 1;
    int c = 0;
    int i = 0;
    while(i < n){
      if (i != n - 1){Console.Write($"{a} ");}
      else{Console.WriteLine($"{a}");}
      c = a + b;
      a = b;
      b = c;
      i += 1;
    }
  }
}