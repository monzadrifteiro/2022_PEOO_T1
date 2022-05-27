using System; 
public class Program {
  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] z = s.Split(':');
    int hora = int.Parse(z[0]);
    int minuto = int.Parse(z[1]);

    string c = Console.ReadLine();
    string[] x = c.Split(':');
    int hora2 = int.Parse(x[0]);
    int minuto2 = int.Parse(x[1]);

    int horatotal = (hora + hora2);
    int minutototal = (minuto + minuto2);

    if (minutototal >= 60){
      minutototal = minutototal - 60;
      horatotal = horatotal + 1;
    }
    Console.WriteLine($"Total de horas = {horatotal:00}:{minutototal:00}");
  }
}