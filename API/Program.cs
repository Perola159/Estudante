using Estudante.Repository;
using Estudante.Repository.Data;
using Estudante.Repository.Repository_Interface;
using Estudante.Service;
using Estudante.Service.Service_Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
inicializadorBD.Inicializar();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


///REGISTRO DE SERVIÇO 
builder.Services.AddScoped<IAlunoService, AlunoService>();

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
