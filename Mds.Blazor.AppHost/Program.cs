var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Mds_Blazor_Web>("mds-blazor-web");

builder.Build().Run();
