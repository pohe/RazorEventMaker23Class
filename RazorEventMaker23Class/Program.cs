using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<IEventRepository, EventRepository>();
builder.Services.AddTransient<IEventRepository, JsonEventRepository>();
builder.Services.AddSingleton<IHotelRepository, HotelRepository>();
builder.Services.AddTransient<ICountryRepository, JsonCountryRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IHotelBookingRepository, JsonHotelBookingRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
