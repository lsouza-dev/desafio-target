using Model;

namespace Serivce;

public class ProdutoService(List<Produto> produtos)
{
    public void ListarProdutos()
    {
        Console.Clear();
        foreach(var p in produtos)
        {
            Console.WriteLine($"ID: {p.CodigoProduto} - Produto: {p.DescricaoProduto} - Estoque: {p.Estoque}");
        }
    }

    public void ExibirMenu()
    {
        Console.WriteLine("\nEscolha a opção desejada!");
        Console.WriteLine("[1] Entrada \t [2] Saida\n[3] Listar \t [4] Sair ");
        Console.WriteLine("\nEscolha:");
    }

    public void LancarProduto()
    {
        Console.WriteLine("Insira a descrição do produto: ");
        string descricao = Console.ReadLine()!;
        Console.WriteLine("Digite a quantidade de estoque desse produto: ");
        var estoque =  Convert.ToInt32(Console.ReadLine());
        var produto = new Produto()
        {
          CodigoProduto = GetUltimoId()+1,
          DescricaoProduto = descricao,
          Estoque = estoque  
        };
        produtos.Add(produto);
        Console.WriteLine("Produto Cadastrado com sucesso!");
    }

    public void BaixarProduto()
    {
        Console.WriteLine("\nSelecione o produto que deseja baixar:");
        ListarProdutos();

        Console.WriteLine("\nID selecionado: ");
        var id =  Convert.ToInt32(Console.ReadLine());

        var produto = produtos.Find(x => x.CodigoProduto == id);
        if(produto  == null) Console.WriteLine("Produto não encontrado.");
        else
        {   
            Console.WriteLine("Quanto deseja reduzir do estoque: ");
            var quantidade =  Convert.ToInt32(Console.ReadLine());

            if(quantidade > 0 && quantidade <= produto.Estoque)
            {
                produto.Estoque -= quantidade;
                Console.WriteLine("Baixa realizada com sucesso!");
            }
            else 
                Console.WriteLine("Quantidade maior do que o estoque diponível");
        }

    }

    int GetUltimoId()
    {
        return produtos.Select(x =>  x.CodigoProduto).Max(x => x);
    }
}