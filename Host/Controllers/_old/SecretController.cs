// using System.Text.Json;
// using InertiaCore;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;

// namespace Server.Controllers;

// [Authorize]
// public class SecretController : Controller
// {
//     private readonly ILogger<SecretController> _logger;
//     private string _componentName = "TheHomePage";
//     public SecretController(ILogger<SecretController> logger)
//     {
//         _logger = logger;

//         _logger.LogInformation("Secret user", JsonSerializer.Serialize(User));
//     }

//     [Authorize]
//     public IActionResult Index()
//     {
//         var auth = User.Identity?.Name;
//         // var allClaims = User.Claims.ToArray();
//         Inertia.Share("TestShared", "shared-prop-value");
//         Inertia.Share("Name", auth);
//         _componentName = "TheSecretPage";
//         var data = new { Id = 1 };

//         return Inertia.Render(_componentName, data);
//     }
// }
