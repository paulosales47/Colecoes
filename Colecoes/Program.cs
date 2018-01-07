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
            //string a = "a 1";
            //string b = "b";
            //string c = "c";
            //string d = "d";
            //string e = "gg";
            //string aa = "a 2";

            //var lista = new List<string>() { a, b, c, d, e, aa };


            ////Imprimir(lista);

            //Console.WriteLine("Primeiro elemento: " + lista[0]);
            //Console.WriteLine("Primeiro elemento: " + lista.First());

            //Console.WriteLine("Ultimo elemento: " + lista[2]);
            //Console.WriteLine("Ultimo elemento: " + lista.Last());

            ////BUSCAS
            //Console.WriteLine("O primeiro item 'A' é:" + lista.FirstOrDefault(item => item.Contains("a")));

            //Console.WriteLine("O último item 'A' é:" + lista.LastOrDefault(item => item.Contains("a")));

            //Console.WriteLine("O primeiro item 'G' é:" + lista.FirstOrDefault(item => item.Contains("g")));

            ////Console.WriteLine("O primeiro item 'G' é:" + lista.First(item => item.Contains("H")));

            ////REVERSÃO DOS ITENS DA LISTA
            //lista.Reverse();
            //Imprimir(lista);

            ////VOLTANDO AO ESTADO ORIGINAL
            //lista.Reverse();

            ////REMOVENDO O ULTIMO ELEMENTO DA LISTA
            //lista.RemoveAt(lista.Count - 1);
            //Imprimir(lista);

            ////ADICIONANDO ELEMENTOS NA LISTA
            //lista.Add("h");

            ////ORDENAÇÃO ALFABÉTICA
            //lista.Sort();

            ////COPIA
            ////indice de onde a cópia irá iniciar / quantidade de elementos a serem copiados
            //var copia = lista.GetRange(lista.Count - 2, 2);

            ////CLONE
            ////para clonar é passada uma lista no construtor
            //var clone = new List<string>(lista);

            ////REMOVENDO FAIXA ESPECIFICA DE ITENS
            //clone.RemoveRange(clone.Count - 2, 1);
            //Imprimir(clone);

            //LISTA DE OBJETOS

            //var aula1 = new Aula("Introdução", 20);
            //var aula2 = new Aula("Modelando", 30);
            //var aula3 = new Aula("Inciando Trabalhando", 15);

            //var aulas = new List<Aula>() { aula1, aula2, aula3 };
            //Imprimir(aulas);

            ////UTILIZANDO METODO DE ORDENAÇÃO REESCRITO NA CLASSE AULA
            //aulas.Sort();
            //Imprimir(aulas);

            //aulas.Sort((aulaA, aulaB) => aulaA.Tempo.CompareTo(aulaB.Tempo));
            //Imprimir(aulas);
            Curso csharpColecoes = new Curso("C# Collections", "Paulo Sampaio");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 20));
            csharpColecoes.Adiciona(new Aula("Git", 90));
            Imprimir(csharpColecoes.Aulas);//LISTA SOMENTE LEITURA

            Console.WriteLine(csharpColecoes.TempoTotal);
            Console.WriteLine(csharpColecoes.ToString()); 

        }

        public static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
                
            
        }
        
        public static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();

            aulas.ForEach(aula => {
                Console.WriteLine(aula);
            });
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
