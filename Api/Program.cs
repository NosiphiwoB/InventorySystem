using System.Net;
using Api.Controllers;
using Api.Models;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
//User

app.MapPost("/addUser", async context =>
{
    StreamReader reader = new StreamReader(context.Request.Body);
    var details = await reader.ReadToEndAsync();
    UserController controller = new UserController();
    User user = JsonSerializer.Deserialize<User>(details);
    var created = controller.addUser(user);


});
//Warehouse
app.MapGet("/get-warehouse/:id", () => "Get one warehouse");
app.MapGet("/list-warehouses", () => "All warehouses");
app.MapPost("/register-warehouse", () => "Add warehouse");
app.MapPost("/remove-warehouse", () => "Add warehouse");

app.Run();

