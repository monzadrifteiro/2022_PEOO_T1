using System; 
public class Program {
  public static void Main(string[] args) {
    int i = 1;
    while(i < 10){
      if(i == 1){Console.Write($"Resultado:{i} ");}
      else{Console.Write($"{i} ");}
      i = i * -1;
      if (i >= 0){i += 1;}
      if (i < 0){i += -1;}
    }
  }
}