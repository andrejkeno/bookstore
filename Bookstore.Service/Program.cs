using Rhetos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o => o.CustomSchemaIds(type => type.ToString()));

builder.Services.AddRhetosHost(ConfigureRhetosHostBuilder)
    .AddRestApi(o =>
    {
        o.BaseRoute = "rest";
        o.GroupNameMapper = (conceptInfo, controller, oldName) => "v1";
    })
    .AddAspNetCoreIdentityUser()
    .AddHostLogging();
    //.AddDashboard();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.MapRhetosDashboard();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRhetosRestApi();

//app.MapControllers();

app.Run();

void ConfigureRhetosHostBuilder(IServiceProvider serviceProvider, IRhetosHostBuilder rhetosHostBuilder)
{
    rhetosHostBuilder
        .ConfigureRhetosAppDefaults()
        .UseBuilderLogProviderFromHost(serviceProvider)
        .ConfigureConfiguration(cfg => cfg.MapNetCoreConfiguration(builder.Configuration));
}