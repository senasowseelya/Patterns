using RepositoryPattern;
using RepositoryPattern.Repositories;
using RepositoryPattern.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddScoped<IStudentRepository,EFStudentRepository>();
builder.Services.AddScoped<IDepartmentRepository,EFDepartmentRepository>();
builder.Services.AddScoped<IDepartmentContract,DepartmentService>();
builder.Services.AddScoped<IStudentContract,StudentService>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
