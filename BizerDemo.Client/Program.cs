// See https://aka.ms/new-console-template for more information


using Bizer;
using BizerDemo.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureServices(services =>
{
    services.AddBizer(options => options.AddAssembly(typeof(IUserService).Assembly.ToString()))
        .AddDynamicHttpProxy("http://localhost:5169/");
});

var app = builder.Build();

var userService = app.Services.GetRequiredService<IUserService>();

await userService.CreateAsync(new User
{
    Name = "李四"
});