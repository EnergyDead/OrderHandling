using EntityFramework;
using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Service;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.

builder.Services.AddDbContext<ApplicationContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmployee, EmployeeService>();
builder.Services.AddScoped<IOrder, OrderService>();
builder.Services.AddScoped<ISubdivision, SubdivisionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( !app.Environment.IsDevelopment() )
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}" );

app.MapFallbackToFile( "index.html" ); ;

app.Run();
