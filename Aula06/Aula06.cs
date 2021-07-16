//Formatando a saída no console - Curso Programação Completo C# - Aula 06
using System;

class Aula06{
    static void Main(){

     /*   
    int n1, n2 , n3;
    n1 = 10; n2=20 ;  n3= 30;

    Console.Write("n1 = {0},\nn2 = {1}, \nn3 = {2}", n1,n2,n3);
    // \n = quebra de linha
    // \t = tabulação 
    */

    double valorcompra = 5.50;
    double valorVenda;
    double lucro = 0.1;
    string produto = "Pastel";
    valorVenda = valorcompra + (valorcompra *lucro);

    Console.WriteLine("Produto.......:{0,15}",produto);
    Console.WriteLine("val.compra.......:{0,15:c}",valorcompra);
    Console.WriteLine("Lucro.......:{0,15:p}",lucro);
     Console.WriteLine("Val.venda.......:{0,15:p}",valorVenda);

    }
}