//Minimal APIs
// - Rest Client - Extensao do vscode
// - Postman
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Lista de Produtos
List<Produto> produtos = new List<Produto>
{
            new Produto { Nome = "Agua", Preco = 10.99m, Quantidade = 5 },
            new Produto { Nome = "Camiseta", Preco = 20.50m, Quantidade = 10 },
            new Produto { Nome = "Pirulito", Preco = 15.75m, Quantidade = 7 },
            new Produto { Nome = "Bala", Preco = 8.99m, Quantidade = 12 },
            new Produto { Nome = "Tenis", Preco = 30.00m, Quantidade = 3 },
            new Produto { Nome = "Celular", Preco = 25.00m, Quantidade = 8 },
            new Produto { Nome = "Amoeba", Preco = 12.50m, Quantidade = 6 },
            new Produto { Nome = "Chocolate", Preco = 22.75m, Quantidade = 9 },
            new Produto { Nome = "Boné", Preco = 18.00m, Quantidade = 4 },
            new Produto { Nome = "Meia", Preco = 5.99m, Quantidade = 15 }
        };

//Endpoints - Funcionalidade
//Request/Requisição - URL e o método/verbo HTTP
app.MapGet("/", () => "API de Produtos!");

//GET: http://localhost:5122/produto/listar
app.MapGet("/produto/listar", () => 
{
    return produtos;
});

//GET: http://localhost:5122/produto/cadastrar
app.MapGet("/produto/cadastrar/{nome}", (string nome) => 
{
    Produto produto = new Produto();
    produto.Nome =nome;
    produto.Add(produto);    
    return produtos;
});


// Criar novas funcionalidades/Endpoints para receber dados.
// - Corpo da requisição
// - Receber corpo da requisição
  

app.Run();

Produto produto = new Produto();
produto.Preco = 999;
Console.WriteLine("Preço: " + produto.preco);

