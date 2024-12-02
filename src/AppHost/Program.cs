var builder = DistributedApplication.CreateBuilder(args);

// Client Api
var clientApi = builder.AddProject<Projects.ClientApi>("clientapi")
    .WithExternalHttpEndpoints();

// Client
builder.AddNpmApp("client", "../Client")
    .WithReference(clientApi)
    .WaitFor(clientApi);

builder.Build().Run();
