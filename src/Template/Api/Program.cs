
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Template.Api.Endpoints;
using Template.Api.Extensions;
using Template.Command;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Add services to the container.
builder.Services.AddControllers();

string? connectionString = builder.Configuration.GetConnectionString("TemplateDatabase");
builder.Services.AddDbContext(connectionString!);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.ConfigureSwagger();


builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new DefaultInfrastructureModule(builder.Environment.EnvironmentName == "Development"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.MapTemplate();


app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();


//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider
//        .GetRequiredService<DataBaseContext>();

//    if (app.Environment.IsDevelopment())
//    {
//        await dbContext.Database.MigrateAsync();
//    }
//}

app.Run();
