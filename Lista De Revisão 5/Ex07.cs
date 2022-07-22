using System; 
public class Program {
  public static void Main(string[] args) {
    int x = int.Parse(Console.ReadLine());
    int antecessor = 0;
    int sucessor = 0;
    AntecessorSucessor(x, out antecessor, out sucessor);
    Console.WriteLine(antecessor);
    Console.WriteLine(sucessor);
  }
  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor){
    antecessor = x -1;
    sucessor = x + 1;
  }
}