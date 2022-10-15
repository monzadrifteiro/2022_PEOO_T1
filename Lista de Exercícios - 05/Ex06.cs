using System; 

public class Program {

  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    
    int maq1= (a*0 + b*2 + c*4);
    int maq2= (a*2 + b*0 + c*2);
    int maq3= (a*4 + b*2 + c*0);

    int resultado = 0;
      
    if (maq1 < maq2){
      resultado = maq1;
    }
    else{
      resultado= maq2;
    }
    if (resultado > maq3){
      resultado = maq3;
    }
    Console.WriteLine(resultado);
  }
}