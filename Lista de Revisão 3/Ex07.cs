using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase:");
    string frases = Console.ReadLine();
    string[] palavras = frases.Split();
    int quantidade = palavras.Length;
    int contador1 = 0;
    int contador2 = 0;
    while(contador1 < quantidade){
      while(contador2 < quantidade){
        Console.Write(palavras[contador2] + " ");
          contador2 += 1;
      }
      Console.WriteLine();
      contador1 += 1;
      contador2 = contador1;
    }
  }
}