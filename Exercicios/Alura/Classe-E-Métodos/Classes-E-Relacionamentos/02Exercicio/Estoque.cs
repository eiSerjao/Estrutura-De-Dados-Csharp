using _02Exercicio;

namespace _02Exercicio;

public class Estoque
{
    // Criar uma Lista Privada para listar produtos.
    private List<Produto> ListaDeProduto = new List<Produto>();

    /*Criar metodo para adicionar todos os objetos da classe produto
    na lista de produtos */
    public void AdicionarProduto(Produto produto)
    {
        ListaDeProduto.Add(produto);
        Console.WriteLine("Um novo produto foi adicionado no estoque");
    }

    public void ExibirProdutosListados()
    {
        if (!ListaDeProduto.Any())
        {
            Console.WriteLine("A Lista de Produto esta vazia no momento");
            return;
        }
        
        Console.WriteLine("📦 Produtos no estoque:\n");
        foreach (var produto in ListaDeProduto)
        {
            produto.ExibirProduto();
        }
        
    }
    
}
