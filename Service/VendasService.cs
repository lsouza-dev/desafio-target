using Model;

namespace Serivce;
public class VendasService()
{
    public List<Vendas> CalculaComissao(List<Vendas> vendas)
    {
        foreach(var venda in vendas)
        {
            switch (venda.Valor)
            {
                case < 500:
                    venda.Comissao = venda.Valor * 0.01;
                break;
                case >= 500:
                    venda.Comissao = venda.Valor * 0.05;
                break;
                default:
                    venda.Comissao = 0;
                break;
            }
        }
        return vendas;
    }
}