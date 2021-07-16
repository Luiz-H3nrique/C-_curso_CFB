// Primeiro programa no padrão c# .net - Curso Programação Completo C# - Aula 02

using System;

namespace Aula02
{
    class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("CFC Cursos");
            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
            
        }
    }
}
