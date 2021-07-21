using System;

 public class Jogador{
      public int energia;
      public bool vivo ;

      public string nome;

    // contrutor 
      public Jogador(string n){
          energia = 100;
          vivo = true ;
          nome = n;
      }
      // destrutor 
 ~Jogador(){
        Console.WriteLine("Jogador {0} foi deletado",nome);
    }

 }

class Aula29{
    static void Main(){
        string nome1 ;
        Console.WriteLine("Digite o nome Do Jogador 1 :");
        nome1 = Console.ReadLine();

       Jogador j1 = new Jogador(nome1); // intancia de um objeto em c#
       Jogador j2 = new Jogador("Théo");
       

       
       Console.WriteLine("Nome do Jogador 1 : {0}", j1.nome);
       Console.WriteLine("Nome do Jogador 2 : {0}", j2.nome);
      

    }

    
   
}