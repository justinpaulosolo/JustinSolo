var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.JustinSolo>("justinsolo");

builder.Build().Run();
