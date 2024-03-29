using BanSmartPhone;
using DAO;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string mySqlConnectionStr = builder.Configuration.GetConnectionString("DefaultConnection");
string assemblyName = typeof(TienThachContext).Namespace;

var mvcViews = builder.Services.AddControllersWithViews();

mvcViews.AddRazorRuntimeCompilation();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ISiteContext, SiteContext>();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".AdventureWorks.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(600000);
    options.Cookie.IsEssential = true;
});



builder.Services.AddDbContext<TienThachContext>(options =>
{
    options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr), b => b.MigrationsAssembly(assemblyName));
});
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.Run();
