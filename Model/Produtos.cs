namespace Model;

public class Produto()
{
    public int CodigoProduto { get; set; }
    public string DescricaoProduto { get; set; } = null!;
    public int Estoque { get; set; } = 0;
}