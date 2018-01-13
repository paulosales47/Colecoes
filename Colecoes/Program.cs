using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            #region Lista ligada
            //LinkedList<string> dias = new LinkedList<string>();

            //var d4 = dias.AddFirst("quarta");

            //var d2 = dias.AddBefore(d4, "segunda");

            //var d3 = dias.AddAfter(d2, "terça");

            //var d7 = dias.AddAfter(d4, "sabado");

            //var d1 = dias.AddBefore(d2, "domingo");

            //var d5 = dias.AddBefore(d7, "quinta");

            //var d6 = dias.AddAfter(d5, "sexta");


            ////NÃO É EFICIENTE
            ////var quarta  = dias.Find("quarta");

            ////REMOVER
            //dias.Remove("quinta");

            //foreach (var item in dias)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion Lista ligada

            #region Pilha

            //var navegador = new Navegador();

            //navegador.Go("google");
            //navegador.Go("alura");
            //navegador.Go("adrena");
            //navegador.Go("gmail");
            //navegador.Go("youtube");
            //navegador.Go("github");

            //navegador.Before();
            //navegador.Before();
            //navegador.Before();
            //navegador.Before();

            //navegador.Next();
            //navegador.Next();

            #endregion Pilha

            #region Fila

            string veiculo = "van";
            Enfileirar(veiculo);
            //entrou: kombi
            Enfileirar("kombi");
            //entrou: guincho
            Enfileirar("guincho");
            //entrou: pickup
            Enfileirar("pickup");

            Desenfileirar();

            ImprimirFila();



            #endregion Fila


        }

        private static void ImprimirFila()
        {
            foreach (var item in pedagio)
            {
                Console.WriteLine(item);
            }
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento.");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine(veiculo);
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
        }
    }

    class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine("Pagina atual: "+atual);
        }

        public void Go(string url)
        {
            historicoAnterior.Push(url);
            atual = url;
            Console.WriteLine("Pagina atual: "+atual);
        }

        public void Next()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Pagina atual: " + atual);
            }
        }

        public void Before()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Pagina atual: "+ atual);
            }
        }

    }

}
