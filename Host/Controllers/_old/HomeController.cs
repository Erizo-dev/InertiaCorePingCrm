// using System.Diagnostics;
// using System.Security.Claims;
// using System.Text.Json;
// using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Authentication.Cookies;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using PingCrm.Host.Models;
// using InertiaCore;

// namespace PingCrm.Host.Controllers;

// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;
//     private string _componentName = "TheHomePage";
//     private readonly IHttpClientFactory _httpClientFactory;
//     public HomeController(ILogger<HomeController> logger,
//     IHttpClientFactory httpClientFactory)
//     {
//         _logger = logger;

//         _httpClientFactory = httpClientFactory;
//     }

//     public IActionResult Index()
//     {
//         _componentName = "TheHomePage";
//         var data = new { Id = 1 };

//         return Inertia.Render(_componentName, data);
//     }

//     [HttpPost("Users")]
//     public IActionResult AddUser([FromForm] UserModel user)
//     {
//         _logger.LogInformation("Received user {}", JsonSerializer.Serialize(user));
//         return RedirectToAction(nameof(Index));
//     }

//     [HttpPost("login")]
//     public async Task<IActionResult> Login([FromBody] LoginModel login)
//     {
//         _logger.LogInformation("Received login request {}", JsonSerializer.Serialize(login));
//         await SignInUser(login.Name);
//         return RedirectToAction(nameof(Index));
//     }

//     [Authorize]
//     [HttpGet("About")]
//     public IActionResult About()
//     {
//         _componentName = "TheAboutPage";
//         var data = new { Id = 1 };
//         return Inertia.Render(_componentName, data);
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }


//     private async Task SignInUser(string username = "empty")
//     {
//         _logger.LogInformation("SignInUser {}", username);
//         var claims = new List<Claim>
//             {
//                 new Claim(ClaimTypes.Name, username),
//             };

//         var claimsIdentity = new ClaimsIdentity(
//             claims, CookieAuthenticationDefaults.AuthenticationScheme);

//         await HttpContext.SignInAsync(
//             CookieAuthenticationDefaults.AuthenticationScheme,
//             new ClaimsPrincipal(claimsIdentity));
//     }
// }
