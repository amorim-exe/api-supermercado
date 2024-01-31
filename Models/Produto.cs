namespace Supermercado.Models;

public class Produto
{
    public Guid Id {get; set;}
    public string NomeProduto {get; set;}
    public int Valor { get; set;}

    public Produto(Guid id, string nomeproduto, int valor)
    {
        Id = id;
        NomeProduto = nomeproduto;
        Valor = valor;
    }
}