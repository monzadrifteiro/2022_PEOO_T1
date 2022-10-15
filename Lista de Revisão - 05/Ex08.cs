using System; 
public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(a));
  }
  public static int MenorInteiro(double x){
    int z = Convert.ToInt32(x);
    if (z < x){return z + 1;}
    else{return z;}
  }
}