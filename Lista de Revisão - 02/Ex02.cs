using System; 
public class Program {
  public static void Main(string[] args) {
    int i = 10;
    while(i >= 1){
      if(i == 10){Console.Write($"Resultado:{i} ");}
      else{Console.Write($"{i} ");}
      i -= 1;
    }
  }
}