using ApiKeyAuth.FakeDatabase;
using ApiKeyAuth.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IFakeDatabase, FakeDatabase>();
builder.Services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();
builder.Services.AddScoped<ApiKeyAuthorizationFilter>();

builder.Services.AddControllers();
//builder.Services.AddAuthorization();

var app = builder.Build();

//app.UseAuthorization();
app.MapControllers();

app.Run();
