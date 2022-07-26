using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores:");
    string s = Console.ReadLine();
    string[] z = s.Split(' ');
    int a = int.Parse(z[0]);
    int b = int.Parse(z[1]);
    int c = int.Parse(z[2]);
    
    if (a + b <= c || a + c <= b || c + b <= a){Console.WriteLine("Esses valores não formam um triângulo");}

    else{
      if (a == b && b == c){Console.WriteLine("Equilátero");}
      if (a == b && a != c || a == c && a != b || c == b && b !=a){Console.WriteLine("Isósceles");}
      if (a != b && a != c && b != c){Console.WriteLine("Escaleno");}
    }
  }
}