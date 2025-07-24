using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KiemTraMvc.Models;


namespace KiemTraMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult Index(Hieu ps)
    {
        string Output = "xin chao" + ps.UserName + "và " + ps.PassWord;
        ViewBag.Message = Output;
        return View();
    }


}
