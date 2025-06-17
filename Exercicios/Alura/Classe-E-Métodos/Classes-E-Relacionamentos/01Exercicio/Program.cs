using _01Exercicio;

/*
Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
*/

Titular titular01 = new Titular(
    "João da Silva",
    "123.456.789-00",
    "Rua das Flores, 123"
);

Conta conta01 = new Conta(
    titular01,
    "Agência Central",
    "12345-6",
    1000.00m,
    500.00m
);

conta01.ExibirInformacoes();