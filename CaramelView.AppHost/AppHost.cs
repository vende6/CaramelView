var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CaramelView>("caramelview");

builder.Build().Run();
