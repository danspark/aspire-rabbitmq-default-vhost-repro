var builder = DistributedApplication.CreateBuilder(args);

builder.AddRabbitMQ("rabbitmq")
    .WithEnvironment("RABBITMQ_DEFAULT_VHOST", "boom");

builder.Build().Run();
