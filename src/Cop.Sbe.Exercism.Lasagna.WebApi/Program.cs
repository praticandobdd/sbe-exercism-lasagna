using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>{
 options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Exercism: C#: Lasagna",
        Description = "Desafio de automação no .NET",
        TermsOfService = new Uri("http://www.github.com/praticandobdd"),
        Contact = new OpenApiContact
        {
            Name = "praticandobdd@gmail.com",
            Url = new Uri("https://github.com/praticandobdd/sbe-exercism-lasagna")
        }
    });
     var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});    
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }