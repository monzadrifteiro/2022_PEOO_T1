using System; 

public class Program {

  public static void Main(string[] args) {
    
    string filo = Console.ReadLine();
    string classe = Console.ReadLine();
    string grupo = Console.ReadLine();

    if (grupo == "carnivoro"){
      Console.WriteLine("aguia");
    }
    if (classe == "ave" && grupo == "onivoro"){
      Console.WriteLine("pomba");
    }
    if (classe == "mamifero" && grupo == "onivoro"){
      Console.WriteLine("homem");
    }
    if (classe == "mamifero" && grupo == "herbivoro"){
      Console.WriteLine("vaca");
    }
    if (classe == "inseto" && grupo == "hematofago"){
      Console.WriteLine("pulga");
    }
    if (classe == "inseto" && grupo == "herbivoro"){
      Console.WriteLine("lagarta");
    }
    if (classe == "anelideo" && grupo == "hematofago"){
      Console.WriteLine("sanguessuga");
    }
    if (classe == "anelideo" && grupo == "onivoro"){
      Console.WriteLine("minhoca");
    }
  }
}