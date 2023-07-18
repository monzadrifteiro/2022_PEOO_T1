using System; 
public class Program {
  public static void Main(string[] args) {
    int i = 0;
    while(i < 10){
      i += 1;
      if(i == 1){Console.Write($"Resultado:{i} ");}
      else{Console.Write($"{i} ");}
    }
  }
}