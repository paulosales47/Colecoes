using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a";
            string b = "b";
            string c = "c";

            var lista = new List<string>() { a, b, c };


            //Imprimir(lista);

            Console.WriteLine("Primeiro elemento: "+ lista[0]);
            Console.WriteLine("Primeiro elemento: " + lista.First());

            Console.WriteLine("Ultimo elemento: " + lista[2]);
            Console.WriteLine("Ultimo elemento: " + lista.Last());



        }

        public static void Imprimir(List<string> lista)
        {
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            //foreach(var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            lista.ForEach(item =>
            {
                Console.WriteLine(item);
            });

        }

    }
}
