var builder = WebApplication.CreateBuilder(args);

// 1. Aggiungi i servizi al container (MVC con supporto per le View)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. Configura la pipeline delle richieste HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Il valore HSTS predefinito è 30 giorni.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Fondamentale per caricare CSS (Bootstrap) e JS

app.UseRouting();

app.UseAuthorization();

// 3. Definizione del Routing (Indica al browser dove andare all'avvio)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();