using studyingCsharp3.Interfaces;
using studyingCsharp3.models;

//INTERFACE
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(2,9));


//ABSTRATA
Corrente c = new Corrente();
c.Creditar(2000);
c.ExibirSaldo();

//EMCAPSULAMENTO
ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

//HERANÇA
Aluno a1 = new Aluno("Eudes");
a1.Idade = 27;
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor("Amanda");
p1.Idade = 27;
p1.Salario = 2000;
p1.Apresentar();