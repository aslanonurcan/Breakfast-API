using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();
    builder.Services.AddSingleton<IBreakfastService, BreakfastService>();
}

var app = builder.Build();

{
    app.UseExceptionHandler("/error");
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
