using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor do peso e da distância em KG e KM: ");
    Frete lindo = new Frete(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor do frete é: R$ {lindo.CalcFrete():0.00}");
    Console.WriteLine(lindo.ToString());
  }
}
class Frete{
  private double peso;
  private double distancia;
  public Frete(double peso, double distancia){
    this.peso = peso;
    this.distancia = distancia;
  }
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
    return ((0.01 * peso) * distancia);
  }
  public override string ToString(){
    return $"O peso do produto é {peso} e a distância é {distancia}";
  }
}