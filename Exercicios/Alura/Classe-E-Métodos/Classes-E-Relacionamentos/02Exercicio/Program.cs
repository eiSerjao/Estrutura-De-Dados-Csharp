/*
Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
*/

using _02Exercicio;

namespace _02Exercicio;
class Program
{
    static void Main(string[] args)
    {

        Estoque estoque = new Estoque();

        Produto notebook01 = new Produto(
            "Notebook",
            "Inspiron 15",
            "Dell",
            2598,
            100
        );
        estoque.AdicionarProduto(notebook01);
        estoque.ExibirProdutosListados();
    }
}
