using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;
using EventEase.Services; 

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register services
builder.Services.AddSingleton<UserSessionService>(); // Existing service
builder.Services.AddSingleton<AttendanceTracker>();  // Add this line


await builder.Build().RunAsync();
