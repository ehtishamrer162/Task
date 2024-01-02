using System.Collections.Generic;

namespace TaskManagerApi.Server
{
    public class AppDbContext
    {
        public AppDbContext(DbContexts<AppDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
    // Startup.cs
    public void ConfigureServices(IServiceCollection services)
    {
        // ...

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "TaskManager API", Version = "v1" });
        });
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        // ...

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskManager API V1");
        });
    }

}
