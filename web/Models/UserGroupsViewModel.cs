using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace aspnet_partial_validation
{
  public class UserGroupsViewModel
  {
//    [Required]
//    [Display(Name = "Group")]
//    public int[] GroupIds { get; set; }
    
    private readonly MultiSelectList _list;

    public MultiSelectList MultiSelectList => _list;

    public ModelExpression For { get; set; }
    
    public UserGroupsViewModel()
    {
      var groups = new List<GroupViewModel>
      {
        new GroupViewModel {Id = 1, Name = "admins"},
        new GroupViewModel {Id = 2, Name = "superusers"},
        new GroupViewModel {Id = 3, Name = "users"},
      };
      
      _list = new MultiSelectList(groups, nameof(GroupViewModel.Id), nameof(GroupViewModel.Name));

    }

  }
  
}