using DemoSwagger.FromQueryJson;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddMvcCore();

builder.Services.AddOpenApiDocument(options =>
{
    options.AddJsonQuerySupport();
});
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.UseOpenApi(); // serve OpenAPI/Swagger documents
app.UseSwaggerUi3(); // serve Swagger UI

app.Run();