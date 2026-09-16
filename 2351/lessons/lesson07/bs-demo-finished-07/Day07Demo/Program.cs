using Fluxor;
using Day07Demo.Services;
using Day07Demo.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ScanAssemblies reflects over this assembly at startup and auto-registers every action,
// reducer, and feature it finds — the store wires itself up, no manual registration list.
builder.Services.AddFluxor(options =>
    options.ScanAssemblies(typeof(Program).Assembly));

// MockCartService is registered but intentionally never injected — it's a worked example,
// not a wired dependency. It's the day's Result<T> (BYSResults) return-type specimen:
// students read GetCartItemsAsync here (the same Result<T> service pattern from Day 6) and
// meet it again in Lab 1's service layer. The cart itself is user-built (Add/Remove) and the
// route guard reads cart state straight from the store, so nothing actually consumes the service.
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
