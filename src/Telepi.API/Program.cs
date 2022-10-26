using Telepi.Application.Commons.DBContext;
using Telepi.Application.Commons.Mediator;
using Telepi.Application.Entities.Pedidos.Commands;
using Telepi.Application.Entities.Pedidos.Handlers;
using Telepi.Infrastructure.Mediator.Command;
using Telepi.Infrastructure.Mediator.Event;
using Telepi.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

    // Cada capa gestione sus propias Servicios
    builder.Services.AddDbContext<MiDBContext>(); // Inyectamos eL DbContext para cuando se requiera
    builder.Services.AddSingleton<IMediadorEventos, MediadorEventos>();             // Inyectamo el Mediador de Eventos
    builder.Services.AddSingleton<IMediadorComandos, MediadorComandos>();           // Inyectamo el Mediador de Comandos
    builder.Services.AddScoped<IRepositorio, Repositorio>();                        // Inyectamo el Mediador de Comandos
    builder.Services.AddScoped<IPedidosHandler, PedidosHandler>();                  // Inyectamo el Mediador de Comandos
                                                                                    // El PedidosHandler,NuevoPedidoCommand
    //subscribeToComand<PedidosHandler, NuevoPedidoCommand>();
//Registro el la instancia en el mediador

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

// Singleton:       1 única instancia para todo el ciclo de vida de la aplciación. Por qué?
// Scoped           1 única instancia para todo el ciclo de vida de un request. Si abro varios hilos?
// Transient        1 única instancia para cada llamada