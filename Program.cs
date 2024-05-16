using studyingCsharp3.models;

//EMCAPSULAMENTO
ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

//HERANÇA
Aluno a1 = new Aluno();
a1.Nome = "Eudes";
a1.Idade = 27;
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Eudes";
p1.Idade = 27;
p1.Salario = 2000;
p1.Apresentar();