using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace aspnet_partial_validation.Components
{
  public class UserGroupsViewComponent : ViewComponent
  {
    public IViewComponentResult Invoke (ModelExpression aspFor)
    {
      var metadata = aspFor.ModelExplorer.Metadata.ValidatorMetadata;
      
      for (var i = 0; i < metadata.Count; i++)
      {
        if (metadata[i] is RequiredAttribute attribute)
        {
          break;
        }
        
      }
      
      var model = new UserGroupsViewModel();
      
      return View(model);
      
    }
  
  }
  
}