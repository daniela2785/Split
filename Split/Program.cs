using System;
using System.Globalization;

namespace exemplo // Definir o pacote do sistema  
{
    class Program // Nome do projeto ou pasta  
    {
        static void Main(string[] args)  // Definindo a função principal 
        {
            string frase = Console.ReadLine(); // recebe uma entrada do usuário  
            String x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: "); // imprime a saída  
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }

}