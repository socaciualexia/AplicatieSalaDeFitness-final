using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AplicatieSalaDeFitness.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/Abonamente");
    options.Conventions.AllowAnonymousToPage("/Abonamente/Index");
    options.Conventions.AllowAnonymousToPage("/Abonamente/Details");
});

// Add DbContext for your application
builder.Services.AddDbContext<AplicatieSalaDeFitnessContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AplicatieSalaDeFitnessContext") ?? throw new InvalidOperationException("Connection string 'AplicatieSalaDeFitnessContext' not found.")));

// Add DbContext and Identity services
builder.Services.AddDbContext<LibraryIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AplicatieSalaDeFitnessContext") ?? throw new InvalidOperationException("Connection string 'AplicatieSalaDeFitnessContext' not found.")));

// Add Identity services and specify the DbContext to use for Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<LibraryIdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
