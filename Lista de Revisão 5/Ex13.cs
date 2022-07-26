using System; 
public class Program {
  public static void Main(string[] args) {
    string a = Console.ReadLine();
    Console.WriteLine(RemoverEspacos(a));
  }
  public static string RemoverEspacos(string texto){
    texto = texto.Replace("  "," ");
      return texto;
  }
}