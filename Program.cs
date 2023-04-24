using job_portal.context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<datacontext>();
// Add services to the container.

builder.Services.AddControllers();

#region Swagger

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
    app.UseSwaggerUI();
}
// swagger
#endregion


app.UseAuthorization();

app.MapControllers();

app.Run();