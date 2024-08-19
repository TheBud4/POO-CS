using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using WebAppBiblioteca;
using WebAppBiblioteca.DataBase;
using WebAppBiblioteca.DataBase.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddDbContext<BibliotecaDbContext>(options =>
    options.UseSqlite("Data Source=DataBase.db"));

builder.Services.AddSingleton<LivroService>();

await builder.Build().RunAsync();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
