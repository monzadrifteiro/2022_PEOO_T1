using System; 
public class Program {
public static void Main(string[] args) {
    
string tomadas = Console.ReadLine();
string[] x = tomadas.Split();
double a = double.Parse(x[0]);
double b = double.Parse(x[1]);
double c = double.Parse(x[2]);
double pi = 3.14159;

double areatri= (a * c) /2;
double areacirc= pi * (c * c);
double areatra= c * (a + b) / 2;
double areaquad= b * b;
double areareta= a * b;

Console.WriteLine($"TRIANGULO: {areatri:0.000}");
Console.WriteLine($"CIRCULO: {areacirc:0.000}");
Console.WriteLine($"TRAPEZIO: {areatra:0.000}");
Console.WriteLine($"QUADRADO: {areaquad:0.000}");
Console.WriteLine($"RETANGULO: {areareta:0.000}");
    
  }
}