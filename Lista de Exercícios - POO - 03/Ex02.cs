using System; 
public class Program {
  public static void Main(string[] args) {
    Frete lindo = new Frete();
    Console.WriteLine("Digite o valor do peso em KG: ");
    lindo.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o valor da distância em KM: ");
    lindo.SetDistancia(double.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor do frete é: R$ {lindo.CalcFrete():0.00}");
  }
}
class Frete{
  private double distancia;
  private double peso;
  public void SetDistancia(double d){
    if(d > 0) distancia = d;
  }
  public void SetPeso(double p){
    if(p > 0) peso = p;
  }
  public double GetDistancia(){
    return distancia;
  }
  public double GetPeso(){
    return peso;
  }
  public double CalcFrete(){
    return peso * distancia / 100;
  }
}