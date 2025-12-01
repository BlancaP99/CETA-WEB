var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // Sirve index.html por defecto
app.UseStaticFiles();    // Habilita wwwroot

app.Run();
