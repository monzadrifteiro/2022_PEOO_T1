using System;
public class Program {
  public static void Main(string[] args) {
    Notas a = new Notas();
    Console.WriteLine("Digite o nome da disciplina: ");
    a.disciplina = Console.ReadLine();
    Console.WriteLine("Digite a primeira nota: ");
    a.n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    a.n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a terceira nota: ");
    a.n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quarta nota: ");
    a.n4 = int.Parse(Console.ReadLine());
    Console.WriteLine(a.disciplina);
    Console.WriteLine("A média parcial é: " + a.MediaParcial());
    if(a.MediaParcial() < 60){
      Console.WriteLine("Digite a nota da prova final: ");
      a.nf = int.Parse(Console.ReadLine());
      Console.WriteLine("A média final é: " + a.MediaFinal());
    }
  } 
} 
public class Notas {
  public string disciplina;
  public int n1;
  public int n2;
  public int n3;
  public int n4;
  public int nf;
  public int MediaParcial() {
    int parcial = (n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3) / (2 + 2 + 3 + 3);
    return parcial; 
  }
  public int MediaFinal() {
    int mediatotal = (MediaParcial() + nf) / 2;
    return mediatotal;
  }
}