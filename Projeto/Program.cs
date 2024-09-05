//Minimal APIs
// - Rest Client - Extensao do vscode
// - Postman
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Lista de Produtos
List<Produto> produtos = new List<Produto>
{
            new Produto { Nome = "Produto A", Preco = 10.99m, Quantidade = 5 },
            new Produto { Nome = "Produto B", Preco = 20.50m, Quantidade = 10 },
            new Produto { Nome = "Produto C", Preco = 15.75m, Quantidade = 7 },
            new Produto { Nome = "Produto D", Preco = 8.99m, Quantidade = 12 },
            new Produto { Nome = "Produto E", Preco = 30.00m, Quantidade = 3 },
            new Produto { Nome = "Produto F", Preco = 25.00m, Quantidade = 8 },
            new Produto { Nome = "Produto G", Preco = 12.50m, Quantidade = 6 },
            new Produto { Nome = "Produto H", Preco = 22.75m, Quantidade = 9 },
            new Produto { Nome = "Produto I", Preco = 18.00m, Quantidade = 4 },
            new Produto { Nome = "Produto J", Preco = 5.99m, Quantidade = 15 }
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
app.MapGet("/produto/cadastrar", () => 
{
    return produtos;
});


// Criar novas funcionalidades/Endpoints para receber dados.
// - Pela URL da requisição
// - Receber corpo da requisição
//guardar as informações em uma lista   

app.Run();

Produto produto = new Produto();
produto.Preco = 999;
Console.WriteLine("Preço: " + produto.preco);

