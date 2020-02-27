#pragma checksum "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b233d8645287a5bc3e4e6837d02679e83df975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodItem_Index), @"mvc.1.0.view", @"/Views/FoodItem/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FoodItem/Index.cshtml", typeof(AspNetCore.Views_FoodItem_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\_ViewImports.cshtml"
using FoodOrdering;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\_ViewImports.cshtml"
using FoodOrdering.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b233d8645287a5bc3e4e6837d02679e83df975", @"/Views/FoodItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054f0203cd1cba085e02adb29054fb84faf40046", @"/Views/_ViewImports.cshtml")]
    public class Views_FoodItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodOrdering.Models.FoodItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FoodItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "addorder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
  
    ViewData["Title"] = " Show food";

#line default
#line hidden
            BeginContext(101, 306, true);
            WriteLiteral(@"<h1>Food Menus</h1>

<div class=""container"">
    <div class=""row pb-4"">
        <div class=""col-12"">
            <input type=""text"" name=""searchbox"" id=""searchbox"" class=""filterinput form-control"" placeholder=""Search recipe titles and tags..."">
        </div>
    </div>
</div>
<div class=""row"">
");
            EndContext();
#line 15 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(448, 165, true);
            WriteLiteral("        <div class=\"col-4\" data-role=\"recipe\" >\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(614, 9, false);
#line 20 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(623, 48, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(672, 16, false);
#line 21 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(688, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(714, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b233d8645287a5bc3e4e6837d02679e83df9756143", async() => {
                BeginContext(802, 5, true);
                WriteLiteral("order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(811, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
                      
                        var parms = new Dictionary<string, string>
                                        {
                               { "customerid","1"},
                               { "fooditemid", @item.Id.ToString()}
                        };
                    

#line default
#line hidden
            BeginContext(1121, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1141, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b233d8645287a5bc3e4e6837d02679e83df9759407", async() => {
                BeginContext(1216, 9, true);
                WriteLiteral("add order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 31 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = parms;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1229, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 35 "C:\Users\User\source\repos\MyProject\FoodOrdering\Views\FoodItem\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1300, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1329, 362, true);
                WriteLiteral(@"
    
    <script>
      $(document).ready(function() {
        $(""#searchbox"").on(""keyup"", function() {
        var value = $(this).val().toLowerCase();
        $('div[data-role=""recipe""]').filter(function() {
            $(this).toggle($(this).find('h5').text().toLowerCase().indexOf(value) > -1)
        });
      });
    }); 
    </script>
    
");
                EndContext();
            }
            );
            BeginContext(1694, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodOrdering.Models.FoodItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
