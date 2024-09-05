//Minimal APIs
// - Rest Client - Extensao do vscode
// - Postman
// - Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Endpoints - Funcionalidade
//Request/Requisição - URL e o método/verbo HTTP
app.MapGet("/", () => "Hello World!");

app.MapGet("/segunda funcionalidade", () => "Segunda Funcionalidade");

app.MapGet("/retornar endereco", () =>
{
    dynamic endereco = new
    {
        rua = "Praça Osório",
        numero = 125
    };
    return endereco;
});

// Criar novas funcionalidades/Endpoints para receber dados.
// - Pela URL da requisição
// - Receber corpo da requisição
//guardar as informações em uma lista   

app.Run();

Produto produto = new Produto();
produto.Preco = 999;
Console.WriteLine("Preço: " + produto.preco);

