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

            ////ISET E HEADSET
            //ISet<string> alunos = new HashSet<string>();
            //alunos.Add("Vanessa Tonini");
            //alunos.Add("Ana Losnak");
            //alunos.Add("Rafael Nercessian");
            //alunos.Add("Priscila Stuani");
            //alunos.Add("Rafael Rollo");
            //alunos.Add("Fabio Gushiken");

            ////remover ana, adicionando marcelo
            //alunos.Remove("Ana Losnak");
            //alunos.Add("Marcelo Oliveira");

            //Console.WriteLine(string.Join(",", alunos));

            ////ordenando: sort
            ////alunos.Sort();
            ////copiando: alunosEmLista
            //List<string> alunosEmLista = new List<string>(alunos);
            ////ordenando cópia
            //alunosEmLista.Sort();
            ////imprimindo cópia
            //Console.WriteLine(string.Join(",", alunosEmLista));

            Curso curso = new Curso("C#", "Paulo");
            curso.Adiciona(new Aula("Introdução", 50));
            curso.Adiciona(new Aula("Listas", 35));
            curso.Adiciona(new Aula("Iset", 40));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            curso.Matricula(a1);
            curso.Matricula(a2);
            curso.Matricula(a3);

            foreach (var item in curso.Alunos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(curso.Alunos.Contains(new Aluno("Vanessa Tonini", 34672)));

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
