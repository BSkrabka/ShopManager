var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//builder.Services.Configure<AppSettings>(builder.Configuration);

//builder.Services.AddDataCollection();
//builder.Services.AddCoreCollection();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger(); // Add this line
//    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1")); // Add this line
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
