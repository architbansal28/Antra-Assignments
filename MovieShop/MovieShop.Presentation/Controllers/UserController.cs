using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Presentation.Controllers;

public class UserController : Controller
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
}