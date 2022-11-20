var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("", () => "\\C:\\Beet_lessons\\Shop\\Views\\Cars\\List.cshtml");

app.Run();
