using System.Globalization;
using Serivce;

bool movimentandoEstoque = true;
VendasService vendasService = new();
ProdutoService produtoService = new(Data.Data.Produtos);

var vendas = Data.Data.Vendas;
var vendasAtualizadas = vendasService.CalculaComissao(vendas);

Console.WriteLine("=================== VENDAS =================== ");
vendasAtualizadas.ForEach(v => Console.WriteLine($"Vendedor: {v.Vendedor} - Valor: {v.Valor.ToString("C")} - Comissão: {v.Comissao.ToString("C")}"));

Console.WriteLine("============================================== ");

Console.WriteLine("\n\n=================== Movimentação de Estoque =================== ");
while (movimentandoEstoque)
{
    produtoService.ExibirMenu();
    try
    {    
        var opcao = Convert.ToInt32(Console.ReadLine());
        switch (opcao)
        {
        case 1:
            produtoService.LancarProduto();
        break; 
        case 2:
            produtoService.BaixarProduto();
        break;  
        case 3:
            produtoService.ListarProdutos();
        break;   
        default:
            movimentandoEstoque = false;
        break;
        };

        if (movimentandoEstoque)
        {
            Console.WriteLine("\nDeseja realizar outra operação?");
            Console.WriteLine("[1] Sim [2] Não");
            Console.WriteLine("\nEscolha: ");
            if(Convert.ToInt32(Console.ReadLine()) != 1)
            {
                movimentandoEstoque = false;
            }
            Console.Clear();   
        }
        Console.WriteLine("============================================== ");
    }
    catch(Exception e)
    {
        throw new Exception(e.Message);
    }

}

Console.WriteLine("==================== Calculadora de Juros ====================");

Console.WriteLine("\nDigite o valor: ");
decimal valor = decimal.Parse(Console.ReadLine()!, CultureInfo.GetCultureInfo("pt-BR"));

Console.WriteLine("Digite a data de vencimento (dd/MM/yyyy): ");
DateTime dataVencimento = DateTime.ParseExact(
    Console.ReadLine()!,
    "dd/MM/yyyy",
    CultureInfo.GetCultureInfo("pt-BR"));

int diasAtraso = Math.Max(0, (DateTime.Today - dataVencimento.Date).Days);
decimal valorJuros = valor * 0.025m * diasAtraso;

Console.WriteLine($"Dias de atraso: {diasAtraso}");
Console.WriteLine($"Valor dos juros: {valorJuros.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
Console.WriteLine($"Valor total: {(valor + valorJuros).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");