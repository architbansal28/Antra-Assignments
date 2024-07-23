using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Interfaces.Services;

namespace MovieShop.Presentation.Controllers;

public class AccountController : Controller
{
    private readonly IAccountService _accountService;
    
    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }
}