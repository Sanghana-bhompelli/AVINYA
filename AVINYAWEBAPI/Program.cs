using AVINYALIB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AvinyaContext>(
    options => options.UseSqlServer(
       builder.Configuration.GetConnectionString("SanghanaConnectionString")
       )
    );
builder.Services.AddScoped<AccountInterface,AccountModelClass>();
builder.Services.AddScoped<TransactionInterface,TransactionModelClass>();
builder.Services.AddScoped<UserInterface,UserModelClass>();

var app = builder.Build();

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
