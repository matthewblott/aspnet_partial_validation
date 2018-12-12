using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace aspnet_html5_validation
{
  [HtmlTargetElement("user-groups", Attributes = "asp-for")]
  public class UserGroupsTagHelper : TagHelper
  {
    private readonly IHtmlHelper _helper;
    private readonly HtmlEncoder _encoder;
    
    [HtmlAttributeName("asp-for")]
    public ModelExpression For { get; set; }

    public UserGroupsTagHelper(IHtmlHelper helper, HtmlEncoder encoder)
    {
      _helper = helper as HtmlHelper;
      _encoder = encoder;
    }
      
    [ViewContext]
    public ViewContext ViewContext
    {
      set => (_helper as IViewContextAware)?.Contextualize(value);
    }
    
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      
      output.TagName = null;

      var partialView = await _helper.PartialAsync("~/Views/Shared/_UserGroupsTagHelper.cshtml", For);

      var writer = new StringWriter();
      partialView.WriteTo(writer, _encoder);

      output.Content.SetHtmlContent(writer.ToString());

    }
    
  }
  
}