using System; 
public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string s = Console.ReadLine();
    string[] z = s.Split('/');
    int dia = int.Parse(z[0]);
    int mes = int.Parse(z[1]);
    int ano = int.Parse(z[2]);

    if (ano < 1900 || ano > 2100){Console.WriteLine("A data informada não é válida");}
    
    else if (mes > 12 || mes < 1){Console.WriteLine("A data informada não é válida");}
    
    else if (dia > 31 && mes == 1 || dia > 30 && mes == 3 || dia > 30 && mes == 5 || dia > 30 && mes == 7 || dia > 30 && mes == 8 || dia > 30 && mes == 10 || dia > 30 && mes == 12){Console.WriteLine("A data informada não é válida");}
    
    else if (dia > 30 && mes == 4 || dia > 30 && mes == 6 || dia > 30 && mes == 9 || dia > 30 && mes == 11){Console.WriteLine("A data informada não é válida");}
    
    else if (dia > 28 && mes == 2){Console.WriteLine("A data informada não é válida");}
  }
}