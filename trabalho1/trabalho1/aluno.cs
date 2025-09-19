using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho1
{
    internal class aluno
    {

        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string genero { get; set; }
        public List<string> matriculas { get; set; }
        public DateTime DataCadastro { get; set; }


        public aluno(string nome, DateTime dataNascimento, string genero, List<string> matriculas, DateTime dataCadastro)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.genero = genero;
            this.matriculas = matriculas;
            this.DataCadastro = dataCadastro;
        }

    }
}
