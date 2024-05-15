using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studyingCsharp3.models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor, tenho {Idade} e ganho R${Salario}");
        }
    }
}