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

app.Run();
