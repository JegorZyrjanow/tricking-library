const string AllCors = "All";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(options => 
  options.AddPolicy(AllCors, build => 
    build.AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod()));

var app = builder.Build();

app.UseCors(AllCors);
app.UseRouting();
app.UseEndpoints(endpoints =>
{
  endpoints.MapDefaultControllerRoute();
});

app.Run();
