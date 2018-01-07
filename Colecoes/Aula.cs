using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public class Aula : IComparable
    {
        private string titulo;

        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.Titulo = titulo;
            this.Tempo = tempo;
        }

        public int Tempo { get => tempo; set => tempo = value; }

        public string Titulo { get => titulo; set => titulo = value; }

        public int CompareTo(object obj)
        {
            Aula aula = obj as Aula;
            return this.Titulo.CompareTo(aula.titulo);
        }

        public override string ToString()
        {
            return $"[titulo {titulo}, tempo: {tempo} minutos]";
        }
    }
}
