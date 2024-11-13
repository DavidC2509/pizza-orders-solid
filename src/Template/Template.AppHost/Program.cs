using Projects;
using Template.AppHost.Extensions;

var builder = DistributedApplication.CreateBuilder(args);


#region Postbres Db

var serverPotgsres = builder.AddPostgres("login-pizza-server").WithDataVolume().WithPgAdmin(c => c.WithHostPort(5050));

var postgresDbNext = builder.ExecutionContext.IsRunMode ? serverPotgsres
    .AddDatabase("login-pizza-database") : builder.AddConnectionString("login-pizza-database");

#endregion


#region Pizza Solid
builder.AddProject<Migrate>("login-solid-migration")
    .WithReference(postgresDbNext).WaitFor(postgresDbNext);

var api = builder.AddProject<Api>("login-solid")
        .WithReference(postgresDbNext);

#endregion

builder.Build().Run();
