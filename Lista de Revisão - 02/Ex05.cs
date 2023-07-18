using System; 
public class Program {
  public static void Main(string[] args) {
    int i = 1;
    int j = 1;
    while(i + j <= 46){
      Console.Write(i + j + " ");
      j = j + i;
      i = i + 1;
    }
  }
}