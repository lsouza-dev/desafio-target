using Model;

namespace Data;
public static class Data
{
    public static List<Vendas> Vendas = new List<Vendas>
    {
        new() { Vendedor = "João Silva", Valor = 1200.50 },
        new() { Vendedor = "João Silva", Valor = 950.75 },
        new() { Vendedor = "João Silva", Valor = 1800.00 },
        new() { Vendedor = "João Silva", Valor = 1400.30 },
        new() { Vendedor = "João Silva", Valor = 1100.90 },
        new() { Vendedor = "João Silva", Valor = 1550.00 },
        new() { Vendedor = "João Silva", Valor = 1700.80 },
        new() { Vendedor = "João Silva", Valor = 250.30 },
        new() { Vendedor = "João Silva", Valor = 480.75 },
        new() { Vendedor = "João Silva", Valor = 320.40 },

        new() { Vendedor = "Maria Souza", Valor = 2100.40 },
        new() { Vendedor = "Maria Souza", Valor = 1350.60 },
        new() { Vendedor = "Maria Souza", Valor = 950.20 },
        new() { Vendedor = "Maria Souza", Valor = 1600.75 },
        new() { Vendedor = "Maria Souza", Valor = 1750.00 },
        new() { Vendedor = "Maria Souza", Valor = 1450.90 },
        new() { Vendedor = "Maria Souza", Valor = 400.50 },
        new() { Vendedor = "Maria Souza", Valor = 180.20 },
        new() { Vendedor = "Maria Souza", Valor = 90.75 },

        new() { Vendedor = "Carlos Oliveira", Valor = 800.50 },
        new() { Vendedor = "Carlos Oliveira", Valor = 1200.00 },
        new() { Vendedor = "Carlos Oliveira", Valor = 1950.30 },
        new() { Vendedor = "Carlos Oliveira", Valor = 1750.80 },
        new() { Vendedor = "Carlos Oliveira", Valor = 1300.60 },
        new() { Vendedor = "Carlos Oliveira", Valor = 300.40 },
        new() { Vendedor = "Carlos Oliveira", Valor = 500.00 },
        new() { Vendedor = "Carlos Oliveira", Valor = 125.75 },

        new() { Vendedor = "Ana Lima", Valor = 1000.00 },
        new() { Vendedor = "Ana Lima", Valor = 1100.50 },
        new() { Vendedor = "Ana Lima", Valor = 1250.75 },
        new() { Vendedor = "Ana Lima", Valor = 1400.20 },
        new() { Vendedor = "Ana Lima", Valor = 1550.90 },
        new() { Vendedor = "Ana Lima", Valor = 1650.00 },
        new() { Vendedor = "Ana Lima", Valor = 75.30 },
        new() { Vendedor = "Ana Lima", Valor = 420.90 },
        new() { Vendedor = "Ana Lima", Valor = 315.40 }
    };

    public static List<Produto> Produtos = new List<Produto>
    {
        new(){CodigoProduto = 101, DescricaoProduto = "Caneta Azul",Estoque = 150},  
        new(){CodigoProduto = 102, DescricaoProduto = "Caneta Azul",Estoque = 75},  
        new(){CodigoProduto = 103, DescricaoProduto = "Caderno Univeritário",Estoque = 200},  
        new(){CodigoProduto = 104, DescricaoProduto = "Borracha Branca",Estoque = 320},  
        new(){CodigoProduto = 105, DescricaoProduto = "Lápis Preto HB",Estoque = 90},  
    };

}