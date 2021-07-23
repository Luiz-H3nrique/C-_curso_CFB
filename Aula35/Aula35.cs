// Cadeia de herança e Construtor da classe base - Curso Programação Completo C# - Aula 35
using System;

class veiculo{ // classe Base

    public int rodas;
    public int velMax;
    public bool ligado;

    public void  Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }

    public string getligado(){
        return (ligado?"sim":"Não");
   

}
    public  int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas ){
        if(rodas <0){
            this.rodas = 0;
        } else if(rodas >40){
            this.rodas = 40;
        }else
        {
            this.rodas = rodas;
        }
    }
}


class Carro:veiculo{

    public string nome ;
    public string cor;
    public Carro(string nome , string cor):base(){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
        
    }
}

class CarroCombate : Carro{
    public int municao ;
    public CarroCombate(): base ("Carro de combate" , "Verde"){
        municao = 100;
        setRodas(6);
    }
}
class Aula35{
    static void Main(){
        Carro c1 = new Carro("rapidão","Vermelho");
        CarroCombate cc1 = new CarroCombate();

        c1.ligar();

        Console.WriteLine("Cor ............. : {0}",c1.cor);
         Console.WriteLine("Nome ........... : {0}",c1.nome);
          Console.WriteLine("Rodas ......... : {0}",c1.getRodas());
          Console.WriteLine("Vel.Maxima.......... : {0}",c1.velMax);
         Console.WriteLine("Ligado ........:{0}",c1.getligado());
        Console.WriteLine("--------------------------------------------------------------------------");

         Console.WriteLine("Cor ............. : {0}",cc1.cor);
         Console.WriteLine("Nome ........... : {0}",cc1.nome);
          Console.WriteLine("Rodas ......... : {0}",cc1.getRodas());
          Console.WriteLine("Vel.Maxima.......... : {0}",cc1.velMax);
         Console.WriteLine("Ligado ........:{0}",cc1.getligado());
         Console.WriteLine("Munição ........: {0}",cc1.municao);




        

    }
}