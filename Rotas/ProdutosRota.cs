using Supermercado.Models;

namespace Supermercado.Rotas;

public static class ProdutosRotas
{
    public static List<Produto> Produtos = new()
    {
        new (Guid.NewGuid(), "Arroz", 20),
        new (Guid.NewGuid(), "Feijao", 15),
        new (Guid.NewGuid(), "Batata", 12),
        new (Guid.NewGuid(), "Macarrão", 10),
        new (Guid.NewGuid(), "Cenoura", 8),
        new (Guid.NewGuid(), "Tomate", 25),
        new (Guid.NewGuid(), "Ovos", 18),
        new (Guid.NewGuid(), "Leite", 30),
        new (Guid.NewGuid(), "Pão", 15),
        new (Guid.NewGuid(), "Carne", 40)

    };

    public static void MapProdutosRotas(this WebApplication app)
    {
        app.MapGet("/produtos", () => Produtos);    

        app.MapGet("/produtos/{nomeproduto}",
            (string nomeproduto) => Produtos.Find(x => x.NomeProduto == nomeproduto));

        app.MapPost("/produtos", (Produto produtos) => 
        {
            Produtos.Add(produtos);
            return produtos;
        });

        app.MapPut("/produtos/{id}/{nomeproduto}/{valor}", (Guid id, string nomeproduto, int valor, Produto produtos) => {
            var encontrado = Produtos.Find(x => x.Id == id);

            if (encontrado == null)
                return Results.NotFound();

            encontrado.NomeProduto = produtos.NomeProduto;

            return Results.Ok(encontrado);
        });

        app.MapDelete("/produtos/{id}", (Guid id) => 
        {
            var produtoParaExcluir = Produtos.Find(x => x.Id == id);

            if (produtoParaExcluir == null)
                return Results.NotFound();

            Produtos.Remove(produtoParaExcluir);

            return Results.Ok();
        });
    }
}