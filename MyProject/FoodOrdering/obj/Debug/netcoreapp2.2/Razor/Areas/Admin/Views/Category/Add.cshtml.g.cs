#pragma checksum "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6b4875a2ad6366dccd0628635b93c752d972d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6b4875a2ad6366dccd0628635b93c752d972d8", @"/Areas/Admin/Views/Category/Add.cshtml")]
    public class Areas_Admin_Views_Category_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodOrdering.Areas.Admin.Models.CategoryUpdateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/category/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Add.cshtml"
  
    ViewData["Title"] = "Add Category";

#line default
#line hidden
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("notification", async() => {
                BeginContext(134, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(141, 60, false);
#line 8 "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Add.cshtml"
Write(await Html.PartialAsync("_Notification", Model.Notification));

#line default
#line hidden
                EndContext();
                BeginContext(201, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(206, 428, true);
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-6"">
            <!-- general form elements -->
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Quick Example</h3>
                </div>
                <!-- /.card-header -->
                <!-- form start -->
                ");
            EndContext();
            BeginContext(634, 1008, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6b4875a2ad6366dccd0628635b93c752d972d85246", async() => {
                BeginContext(696, 499, true);
                WriteLiteral(@"
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label for=""categoryname"">Give category name</label>
                            <input type=""text"" class=""form-control"" name=""Name"" id=""categoryname"" placeholder=""category name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""categoryname2"">select products</label>

                            ");
                EndContext();
                BeginContext(1196, 153, false);
#line 30 "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Add.cshtml"
                       Write(Html.ListBoxFor(model => model.FoodItemIds, new MultiSelectList(Model.FoodList, "Id", "Name"), new { id = "multiSelectDropDown", multiple = "multiple" }));

#line default
#line hidden
                EndContext();
                BeginContext(1349, 286, true);
                WriteLiteral(@"

                        </div>
                    </div>
                    <!-- /.card-body -->

                    <div class=""card-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1642, 136, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!--/.col (left) -->\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n</div><!-- /.container-fluid -->\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1795, 316, true);
                WriteLiteral(@"

    <script>
        $(function () {
            //normal dropdown
            //$(""#normalDropDown"").chosen({
            //    disable_search_threshold : 5
            //});


            $(""#multiSelectDropDown"").chosen({
                width : ""20%""
            });
        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodOrdering.Areas.Admin.Models.CategoryUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
