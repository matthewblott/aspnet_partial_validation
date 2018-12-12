using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace aspnet_partial_validation
{
  public class UserViewModel
  {
    [MaxLength(20)]
    [Required]
    [Editable(true)]
    public string Name { get; set; }
    
    [MaxLength(20)]
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [MaxLength(20)]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }  
    
    [MaxLength(20)]
    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "The passwords do not match")]
    [Display(Name = "Password Compare", Prompt = "Password Compare")]
    public string PasswordCompare { get; set; }

    [Required]
    [Display(Prompt = "Group")]
    public int[] GroupIds { get; set; }

    public UserGroupsViewModel Groups { get; set; }

    // public IEnumerable<GroupViewModel> Groups { get; set; }

  }
  
}