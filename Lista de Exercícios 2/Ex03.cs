using System; 
public class Program {
public static void Main(string[] args) {
  
Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
string nota1= Console.ReadLine();
Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
string nota2= Console.ReadLine();
    
int n1 =int.Parse(nota1);
int n2 =int.Parse(nota2);
    
int notaf= (n1 * 2 + n2 * 3) / 5;
Console.WriteLine("Média Parcial = " + notaf);
    
  }
}