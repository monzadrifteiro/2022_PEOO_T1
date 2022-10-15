using System; 
public class Program {
  public static void Main(string[] args) {
    int quant = int.Parse(Console.ReadLine());
    int x = 0;
    double coelho = 0;
    double sapo = 0;
    double rato = 0;

    while(x < quant){
      string s = Console.ReadLine();
      string[] z = s.Split(' ');
      int a = int.Parse(z[0]);
      string especime = z[1];
      if (especime == "C"){coelho += a;}
      if (especime == "S"){sapo += a;}
      if (especime == "R"){rato += a;}
      x += 1;
    }
    double soma = (coelho + sapo + rato);
    double perc = (coelho / soma) * 100;
    double perr = (rato / soma) * 100;
    double pers = (sapo / soma) * 100;
    Console.WriteLine($"Total: {soma} cobaias");
    Console.WriteLine($"Total de coelhos: {coelho}");
    Console.WriteLine($"Total de ratos: {rato}");
    Console.WriteLine($"Total de sapos: {sapo}");
    Console.WriteLine($"Percentual de coelhos: {perc:00.00} %");
    Console.WriteLine($"Percentual de ratos: {perr:00.00} %");
    Console.WriteLine($"Percentual de sapos: {pers:00.00} %");
  }
}