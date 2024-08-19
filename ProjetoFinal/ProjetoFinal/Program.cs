using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Components;
using ProjetoFinal.DataBase;
using ProjetoFinal.DataBase.Services;

var builder = WebApplication.CreateBuilder(args);

//Configuring the database
builder.Services.AddDbContext<BibliotecaDbContext>(options =>
    options.UseSqlite("Data Source=DataBase/DataBase.db"));

// Adding services to the container.
builder.Services.AddScoped<LivroService>();


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();