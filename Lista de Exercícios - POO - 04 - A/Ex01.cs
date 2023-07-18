using System; 
public class Program {
  public static void Main(string[] args) {
    Bingo lindo = new Bingo();
    lindo.Iniciar(10);
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    Console.WriteLine(lindo.Sortear());
    foreach(int i in lindo.Sorteados())
      Console.Write(i + " - ");
  }
}
class Bingo{
  private int numBolas;
  private int[] numeros;
  private int k;
  public void Iniciar(int numBolas) {
    if(numBolas >= 10 && numBolas <= 100)
      this.numBolas = numBolas;
    else
      this.numBolas = 50;
    numeros = new int[numBolas];
    k = 0;
  }
  public int Sortear(){
    if(k == numBolas) return -1;
    Random r = new Random();
    int n = r.Next(1, numBolas + 1);
    int pos = Array.IndexOf(numeros, n);
    while(pos != -1){
      n = r.Next(1, numBolas + 1);
      pos = Array.IndexOf(numeros, n);
    }
    numeros[k] = n;
    k++;
    return n;
  }
  public int[] Sorteados(){
    int[] vetor = new int[k];
    Array.Copy(numeros, vetor, k);
    return vetor;
  }
}