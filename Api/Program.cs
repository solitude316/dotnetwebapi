using System.Text.Json.Serialization;
using Api.Data;
using Api.Helpers;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

{
    builder.Services.AddDbContext<PgSQLContext>();
    builder.Services.AddCors();
    builder.Services.AddControllers().AddJsonOptions( x => {
        // serialize enums as strings in api responses (e.g. Role)
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

        // ignore omitted parameters on models to enable optional params (e.g. User update)
        x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

    // builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
}


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<Data.PgSQLContext>(options => {
//     string connectionString = builder.Configuration.GetConnectionString("DefaultConneciton");
// });

var app = builder.Build();

{
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
    );

    app.UseMiddleware<ErrorHandlerMiddleware>();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
