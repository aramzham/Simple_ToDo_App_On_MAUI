using Microsoft.EntityFrameworkCore;
using ToDoApp.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

var app = builder.Build();

// app.UseHttpsRedirection();

app.MapGet("api/todo", async (AppDbContext dbContext) =>
{
    var items = await dbContext.ToDos.ToListAsync();
    return Results.Ok(items);
});

app.Run();