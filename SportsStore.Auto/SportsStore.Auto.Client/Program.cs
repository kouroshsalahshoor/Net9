using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthenticationStateDeserialization();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7228/api/") });
//builder.Services.AddScoped(sp =>
//    new HttpClient
//    {
//        BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ?? "https://localhost:7228/api/")
//    });

await builder.Build().RunAsync();
