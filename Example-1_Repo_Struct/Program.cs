using Ex_BAL.Implemenatation;
using Ex_BAL.Interface;
using Ex_DAL.Interface;
using Ex_DL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CompanyDBContext>(x => x.UseSqlServer("Data Source=RSPLLT423\\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True"));
builder.Services.AddTransient<CompanyDBContext>();
builder.Services.AddTransient<IEmployee, Ex_DAL.Implementation.Employee>();
builder.Services.AddTransient<IEmployeeBL, EmployeBO>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
