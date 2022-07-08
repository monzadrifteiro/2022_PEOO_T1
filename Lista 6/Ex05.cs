using System; 
public class Program {
  public static void Main(string[] args) {
    
    double n = double.Parse(Console.ReadLine());
    double x = 0;
    
    while(x < n){
      string s = Console.ReadLine();
      string[] z= s.Split(' ');
      double a = double.Parse(z[0]);
      double b = double.Parse(z[1]);
      double divi = (a / b);
      if (b == 0){Console.WriteLine("divisao impossivel");}
      else{Console.WriteLine($"{divi:0.0}");}
      x = x + 1;
    }
  }
}