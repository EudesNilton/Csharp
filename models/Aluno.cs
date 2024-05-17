using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studyingCsharp3.models
{
    public class Aluno : Pessoa //herança
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {

        }

        public double Nota { get; set; }

        public override void Apresentar() //sobrescreva com o override
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e sou um aluno nota {Nota}");
        }
    }
}