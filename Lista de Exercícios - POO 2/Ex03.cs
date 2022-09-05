using System;
public class Program {
  public static void Main(string[] args) {
    Viagem linda = new Viagem();
    Console.WriteLine("Digite a distância em km: ");
    linda.SetDistancia(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o tempo gasto em horas e minutos: ");
    linda.SetTempo(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A velocidade média é de: {linda.VelocidadeMedia()}");
  }
  class Viagem{
    private double distancia;
    private double tempo;
    public void SetDistancia (double t){
      if(t > 0){distancia = t;}
    }
    public void SetTempo (double t){
      if(t > 0){tempo = t;}
    }
    public double GetDistancia(){
      return distancia;
    }
    public double GetTempo(){
      return tempo;
    }
    public double VelocidadeMedia(){
      double vm = distancia / tempo;
      return vm;
    }
  }
}