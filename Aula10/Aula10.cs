//Enumeradores (enum) - Curso Programação Completo C# - Aula 10

using System;
class Aula10{
    enum DiaSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){
        
        DiaSemana ds = (DiaSemana)0;
        int ds2 = (int)DiaSemana.Sexta;

        Console.WriteLine(ds);
        Console.WriteLine(ds2);
        
    }
}