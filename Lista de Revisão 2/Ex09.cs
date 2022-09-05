using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o horário no formato hh:mm:");
    string s = Console.ReadLine();
    string[] horario = s.Split(":");
    int horas = int.Parse(horario[0]);
    int minutos = int.Parse(horario[1]);
    if(horas > 23 || horas < 0 || minutos > 60 || minutos < 0){
      Console.WriteLine("Hora Inválida");
    }
    if(minutos == 60){
      horas += 1;
    }
    if(horas == 24){
      horas = 0;
    }
    int anguloM = minutos * 6;
    int anguloH = ((horas * 60) + minutos) / 2;
    int menorangulo = anguloM - anguloH;
    if(menorangulo < 0){
      menorangulo = menorangulo * -1;
    }
    if(menorangulo > 180){
      menorangulo = (360 - menorangulo) * -1;
    }
    Console.WriteLine ($"Menor ângulo entre os ponteiros = {menorangulo} graus");
  }
}