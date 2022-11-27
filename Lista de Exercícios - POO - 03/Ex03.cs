using System; 
public class Program {
  public static void Main(string[] args) {
    Equacao linda = new Equacao();
    Console.WriteLine("Digite os valores dos elementos A, B e C da equação: ");
    linda.SetABC(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor do delta da equação é: {linda.Delta():0.00}");
    double g, h;
    if(linda.RaizesReais(out g, out h)){
      Console.WriteLine($"Os valores de X1 e X2 são: {g:0.00} e {h:0.00}");
    }
    else{
      Console.WriteLine($"Os valores de X1 e X2 não são reais.");
    }
  }
}
class Equacao{
  private double a, b, c;
  public void SetABC(double a, double b, double c){
    if (a != 0){
      this.a = a; 
      this.b = b; 
      this.c = c;
    }
  }
  public void GetABC(out double a, out double b, out double c){
    a = this.a;
    b = this.b;
    c = this.c;
  }
  public double Delta(){
    return b * b -4 * a * c;
  }
  public bool RaizesReais(out double xc, out double xd){
    xc = (-b + Math.Sqrt(Delta())) / 2 * a;
    xd = (-b +- Math.Sqrt(Delta())) / 2 * a;
    if (Delta() < 0) return false;
    return true;
  }
}