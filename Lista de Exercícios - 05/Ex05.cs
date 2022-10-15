using System; 

public class Program {

  public static void Main(string[] args) {
    string valores = Console.ReadLine();
    string[] z = valores.Split(' ');
    
    int a = int.Parse(z[0]);
    int b = int.Parse(z[1]);

    if (a <= 432 && a >= 0 && b <= 468 && b >= 0){
      Console.WriteLine("dentro");
      }
    else{
      Console.WriteLine("fora");
      }
  }
}