using System; 
public class Program {
  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(a, b));
  }
  public static int Soma(int inicio, int fim){
    int resultado = 0;
    fim -= 1;
    while(inicio < fim){
      resultado = resultado + fim;
      fim -= 1;
    }
    return resultado;
  }
}