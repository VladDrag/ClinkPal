using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<cryptoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("cryptoContext") ?? throw new InvalidOperationException("Connection string 'cryptoContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

if (app.Environment.IsDevelopment())
{
    app.UseCors(opt =>
        opt.SetIsOriginAllowed(origin => true));
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();