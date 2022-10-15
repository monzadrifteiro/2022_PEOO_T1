using System;
public class Program {
  public static void Main(string[] args) {
    Circulo lindo = new Circulo();
    Console.WriteLine("Digite o valor do raio:");
    double aaa = double.Parse(Console.ReadLine());
    lindo.SetRaio(aaa);
    Console.WriteLine($"A área do círculo é: {lindo.CalcArea()}");
    Console.WriteLine($"A circunferência do círculo é: {lindo.CalcCircunferencia()}");
  }
  class Circulo{
    private double raio;
    public void SetRaio (double t){
      if(t > 0){raio = t;}
    }
    public double GetRaio(){
      return raio;
    }
    public double CalcArea(){
      double pi = 3.14;
      double area = pi * Math.Pow(raio, 2);
      return area;
    }
    public double CalcCircunferencia(){
      double pi = 3.14;
      double circunferencia = 2 * pi * raio;
      return circunferencia;
    }
  }
}