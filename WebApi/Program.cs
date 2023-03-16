using Application.Services.Abstractions;
using Application.Services.Implementations;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstractions;
using Infrastructure.Repositories.Implementations;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using System.Reflection;
using Infrastructure.Core.Paginations.Abstractions;
using Infrastructure.Core.Paginations.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

//DataBase context
builder.Services.AddDbContext<ApplicationDbContext>();

//DI
// builder.Services.AddScoped<IEditorialRepository, EditorialRepository>();

// builder.Services.AddScoped<IEditorialService, EditorialService>();

// builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IPaginator<>), typeof(Paginator<>));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(options =>
    {
        options.RegisterAssemblyTypes(Assembly.Load("Infrastructure"))
        .Where(t => t.Name.EndsWith("Repository"))
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();

        options.RegisterAssemblyTypes(Assembly.Load("Application"))
        .Where(t => t.Name.EndsWith("Service"))
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();
    });

builder.Services.AddAutoMapper(Assembly.Load("Application"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
