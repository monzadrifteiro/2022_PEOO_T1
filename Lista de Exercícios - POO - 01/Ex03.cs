using System;
public class Program {
  public static void Main(string[] args) {
    Viagem longa = new Viagem();
    Console.WriteLine("Digite a distancia em km: ");
    longa.distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o tempo em horas e minutos: ");
    longa.tempo = Console.ReadLine();
    Console.WriteLine($"A velocidade média é: {longa.VelocidadeMedia():0.00} km/h");
  }
} 
public class Viagem {
    public double distancia;
    public string tempo;
    public double VelocidadeMedia() {
    string[] aaa = tempo.Split(':');
      double horas = double.Parse(aaa[0]);
      double minutos = double.Parse(aaa[1]);
      double vm = distancia / ((horas * 60 + minutos) / 60);
      return vm;
  }
}