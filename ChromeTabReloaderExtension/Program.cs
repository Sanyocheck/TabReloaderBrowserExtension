using Blazored.LocalStorage;
using ChromeTabReloaderExtension;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebExtensions.Net;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IWebExtensionsApi, WebExtensionsApi>();

builder.Services.AddBrowserExtensionServices();

//builder.Services.AddTimerService<ReloadTabsTimerService>(x => x.Delay = TimeSpan.FromSeconds(5));

await builder.Build().RunAsync();
