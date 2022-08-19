using System; 
public class Program {
  public static void Main(string[] args) {
    Circulo lindo = new Circulo();
    Console.WriteLine("Digite o valor do raio:");
    lindo.raio = double.Parse(Console.ReadLine());
    Console.WriteLine("A área do círculo é: " + lindo.Area());
  }
}
public class Circulo{
  public double raio;
  public double Area() {
    double areac = Math.PI * Math.Pow(raio, 2);
    return areac;
  }
}