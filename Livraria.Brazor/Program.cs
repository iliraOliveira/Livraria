using Livraria.Brazor.Components;
using Livraria.CrossCutting.DependenciesApp;
using Livraria.Infrastructure.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDependenciesApp(builder.Configuration);

var app = builder.Build();

CreateDbIfNotExists(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static void CreateDbIfNotExists(WebApplication app)
{
    var scope = app.Services.CreateScope();
    var dataService = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dataService?.Database.EnsureCreated();
}