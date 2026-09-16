using Fluxor;
using Day07Demo.Services;
using Day07Demo.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddFluxor(options =>
    options.ScanAssemblies(typeof(Program).Assembly));

// ICartService is registered for future Effect use; no Effects on Day 7.
builder.Services.AddScoped<ICartService, MockCartService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
