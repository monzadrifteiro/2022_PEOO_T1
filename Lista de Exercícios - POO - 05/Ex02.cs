using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor da distância e o do peso");
    Frete lindo = new Frete {Distancia = double.Parse(Console.ReadLine()), Peso = double.Parse(Console.ReadLine())};
    Console.WriteLine(lindo.ToString());
    Console.WriteLine($"O valor do Frete é {lindo.ValorFrete:0.00} R$");
  }
}
class Frete{
  private double distancia, peso;
  public double Distancia{
    set { if(value > 0) distancia = value; }
    get { return distancia; }
  }
  public double Peso{
    set { if(value > 0) peso = value; }
    get { return peso; }
  }
  public double ValorFrete{
    get { return (0.01 * peso ) * distancia; }
  }
  public override string ToString(){
    return $"A distância é de {distancia} KM e o peso é de {peso} KG";
  }
}