using dotenv.net;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using vwmsweb.Services;

DotEnv.Load();

var builder = WebApplication.CreateBuilder(args);

// Listen on any URL
// builder.WebHost.ConfigureKestrel(options =>
// {
//     options.ListenAnyIP(7199);
//     options.ListenAnyIP(5159);
// });

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<UserService>();
builder.Services.AddSession();  // default: 20 minutes

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
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();