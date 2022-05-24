using System; 

public class Program {

  public static void Main(string[] args) {
    
    string valores = Console.ReadLine();
    string[] z = valores.Split(' ');
    double valor1 = double.Parse(z[0]);
    double valor2 = double.Parse(z[1]);

    if (valor2 % valor1 == 0 || valor1 % valor2 == 0){
      Console.WriteLine("Sao Multiplos");
    }  
    else{
      Console.WriteLine("Nao sao Multiplos");
    }
  }
}