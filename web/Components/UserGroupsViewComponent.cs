using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace aspnet_partial_validation.Components
{
  public class UserGroupsViewComponent : ViewComponent
  {
    public IViewComponentResult Invoke (ModelExpression aspFor)
    {
      var metadata = aspFor.Metadata;

      var idName = aspFor.Name;
      var prompt = metadata.Placeholder;
      var isRequired = metadata.IsRequired;
      var isReadOnly = metadata.IsReadOnly;
      
      // required
      // disabled
      // readonly
      
      var model = new UserGroupsViewModel();

      model.For = aspFor;
      
//      return View(model);

      return View(aspFor);
    }
  
  }
  
}