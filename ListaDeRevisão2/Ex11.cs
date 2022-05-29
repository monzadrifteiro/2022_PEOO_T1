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

    else{
    
    if (mes == 1){Console.WriteLine($"A data é {dia} de janeiro de {ano}");} 
    if (mes == 2){Console.WriteLine($"A data é {dia} de fevereiro de {ano}");} 
    if (mes == 3){Console.WriteLine($"A data é {dia} de março de {ano}");} 
    if (mes == 4){Console.WriteLine($"A data é {dia} de abril de {ano}");} 
    if (mes == 5){Console.WriteLine($"A data é {dia} de maio de {ano}");} 
    if (mes == 6){Console.WriteLine($"A data é {dia} de junho de {ano}");} 
    if (mes == 7){Console.WriteLine($"A data é {dia} de julho de {ano}");} 
    if (mes == 8){Console.WriteLine($"A data é {dia} de agosto de {ano}");} 
    if (mes == 9){Console.WriteLine($"A data é {dia} de setembro de {ano}");} 
    if (mes == 10){Console.WriteLine($"A data é {dia} de outubro de {ano}");} 
    if (mes == 11){Console.WriteLine($"A data é {dia} de novembro de {ano}");} 
    if (mes == 12){Console.WriteLine($"A data é {dia} de dezembro de {ano}");} 
    }
  }
}