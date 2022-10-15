using System; 
public class Program {
  public static void Main(string[] args) {
    
    int maior = int.Parse(Console.ReadLine());
    int pos = 0;
    
    for(int i = 1; i < 100; i++){
      int entrada = int.Parse(Console.ReadLine());
      
      if(entrada > maior){
        maior = entrada;
        pos = i + 1;
      } 
    }
  Console.WriteLine(maior);
  Console.WriteLine(pos);
  }
}