using System; 
public class Program {
  public static void Main(string[] args) {
    string a = Console.ReadLine();
    Console.WriteLine(Vogais(a));
  }
  public static string Vogais(string s){
    int i = 0;
    string v = "";
    int z = s.Length;
    while(i < z){
      if(s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u' || s[i]=='A' || s[i]=='E' || s[i]=='I' || s[i]=='O' || s[i]=='U' || s[i]==' '){
        v += s[i];
      }
    i++;
    }
    return v;
  }
}