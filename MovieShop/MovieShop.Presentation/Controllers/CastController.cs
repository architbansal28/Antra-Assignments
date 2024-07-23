using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Presentation.Controllers;

public class CastController : Controller
{
    private readonly ICastService _castService;
    
    public CastController(ICastService castService)
    {
        _castService = castService;
    }
    
    public IActionResult Index(int id)
    {
        var cast = _castService.GetCastDetails(id);
        return View(cast);
    }
}