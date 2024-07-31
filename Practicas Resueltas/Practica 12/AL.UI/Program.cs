using AL.UI.Components;

 //agregamos estas directivas using
 using AL.Repositorios;
 using AL.Aplicacion.UseCases;
 using AL.Aplicacion.Interfaces;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

 //agregamos estos servicios al contenedor DI
 builder.Services.AddTransient<AgregarClienteUseCase>();
 builder.Services.AddTransient<ListarClientesUseCase>();
 builder.Services.AddTransient<EliminarClienteUseCase>();
 builder.Services.AddTransient<ModificarClienteUseCase>();
 builder.Services.AddTransient<ObtenerClienteUseCase>();
 builder.Services.AddScoped<IRepositorioCliente, RepositorioClienteMock>();
 builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
