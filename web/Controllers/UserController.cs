using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace aspnet_partial_validation.Controllers
{
  public class UserController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    
    public IActionResult New()
    {
      var model = new UserViewModel
      {
        Groups = new UserGroupsViewModel()
      };

      return View(model);
      
    }

    [HttpPost]
    public IActionResult Create(UserViewModel userViewModel)
    {
      return RedirectToAction(nameof(Index));

    }
    
  }
  
}