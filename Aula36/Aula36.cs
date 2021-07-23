// Membros Protected - Curso Programação Completo C# - Aula 36

using System;


class Veiculo{ // Base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getligado(){
        return ligado;
    }

    public int getVelMax(){
        return velMax;
    }

}

class Carro : Veiculo{
    public string nome;
    public Carro(string nome , int vm) :base(vm){ // Derivada de véiculos
      
        this.nome = nome;
        ligado = true ;

    }
}
class Aula36{
    static void Main(){
        Carro carro = new Carro("Bonitão",120);

        Console.WriteLine("Nome:............. {0}",carro.nome);
        Console.WriteLine("Vwl.Máxima .............. : {0}",carro.getVelMax());
        Console.WriteLine("Ligado ............:{0}",carro.getligado());
    }
}