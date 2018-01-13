using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public class Curso
    {
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }


        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        //PROPIEDADE CALCULADA
        public int TempoTotal
        {
            get
             {
                //int total = 0;
                //foreach (var item in aulas)
                //{
                //    total += item.Tempo;
                //}
                //return total;

                return aulas.Sum(aula => aula.Tempo);
             }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo total: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        internal Aluno buscaMatriculado(int numeroMatricula)
        {
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);

            return aluno;
        }

        internal void substituiAluno(Aluno sub)
        {
            this.dicionarioAlunos[sub.NumeroMatricula] = sub;
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
        
        
    }
}
