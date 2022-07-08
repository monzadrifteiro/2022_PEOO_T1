using System; 
public class Program {
  public static void Main(string[] args) {
    
    int x = int.Parse(Console.ReadLine());
    
    while(x != 2002)
    {
    Console.WriteLine("Senha Invalida");
    x = int.Parse(Console.ReadLine());
    }
    
     if (x == 2002){Console.WriteLine("Acesso Permitido");}
  }
}