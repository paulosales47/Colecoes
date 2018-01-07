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
            string d = "d";
            string e = "e";
            string f = "f";

            string[] letras = new string[]
            {
                a, b, c, e, d, f
            };

            Imprimir(letras);

            //PRIMEIRO ELEMENTO
            Console.WriteLine(letras[0]);

            //ULTIMO ELEMENTO
            Console.WriteLine(letras[letras.Length - 1]);

            //PRIMEIRA OCORRENCIA
            Console.WriteLine("A primeira ocorrencia da letra 'a' está no indice ", Array.IndexOf(letras, "a"));

            //ULTIMA OCORRENCIA
            Console.WriteLine("A ultima ocorrencia da letra 'a' está no indice ", Array.LastIndexOf(letras, "a"));

            //INVERSÃO
            Array.Reverse(letras);

            //REDIMENSIONAR TAMANHO
            Array.Resize(ref letras, 2);

            //ORDEM ALFABETICA (Não pode ser revertido)
            Array.Sort(letras);

            //COPIAR ELEMENTOS
            string[] copia = new string[2];
            //array origem, indice inicial na origem, array destino, indice inicial do destino, numero de elementos a ser copiados
            Array.Copy(letras, 1, copia, 0, 2);

            //CLONAR
            string[] clone = letras.Clone() as string[];

            //LIMPAR
            //indice inicial e indice final
            Array.Clear(clone, 1, 2);
            
        }


        private static void Imprimir(string[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
