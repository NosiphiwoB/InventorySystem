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
app.MapPost("/register-warehouse", async context =>
{
    StreamReader reader = new StreamReader(context.Request.Body);
    var data = await reader.ReadToEndAsync();
    WarehouseController controller = new WarehouseController();
    Warehouse warehouse = JsonSerializer.Deserialize<Warehouse>(data);
    var created = controller.addWarehouse(warehouse);

});

app.MapGet("/list-warehouses", () => "All warehouses");
app.MapGet("/get-warehouse/:id", () => "Get one warehouse");
app.MapPost("/remove-warehouse", () => "Add warehouse");

app.Run();

