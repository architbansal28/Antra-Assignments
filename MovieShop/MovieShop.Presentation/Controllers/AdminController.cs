using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Presentation.Controllers;

public class AdminController : Controller
{
    private readonly IAdminService _adminService;
    
    public AdminController(IAdminService adminService)
    {
        _adminService = adminService;
    }
}