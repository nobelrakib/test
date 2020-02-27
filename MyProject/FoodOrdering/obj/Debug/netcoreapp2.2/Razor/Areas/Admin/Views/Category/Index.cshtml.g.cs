#pragma checksum "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a68879f375fc4e715cf359e24354e27f66cdb87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a68879f375fc4e715cf359e24354e27f66cdb87a", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category";

#line default
#line hidden
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("style", async() => {
                BeginContext(65, 125, true);
                WriteLiteral("\r\n    <!-- DataTables -->\r\n    <link rel=\"stylesheet\" href=\"/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.css\">\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(193, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(214, 2315, true);
                WriteLiteral(@"
    <!-- DataTables -->
    <script src=""/admin/plugins/datatables/jquery.dataTables.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.js""></script>
    <!-- page script -->
    <script>
         $(function () {
            $('#example1').DataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""ajax"": ""/Admin/Category/GetCategories"",
                ""columnDefs"": [
                    {
                        ""orderable"": false,
                        ""targets"": 0,
                        ""render"": function (data, type, row) {
                            return `<input type='checkbox' value='${data}'/>`;
                        }
                    },
                     {
                        ""orderable"": false,
                        ""targets"": 2,
                        ""render"": function (data, type, row) {
                            return `<button type=""submit"" class=""btn btn-info btn-sm"" onc");
                WriteLiteral(@"lick=""window.location.href='/admin/category/edit/${data}'"" value='${data}'>
                                    <i class=""fas fa-pencil-alt"">
                                    </i>
                                    Approve
                                </button>
                                <button type=""submit"" class=""btn btn-danger btn-sm show-bs-modal"" href=""#"" data-id='${data}' value='${data}'>
                                    <i class=""fas fa-trash"">
                                    </i>
                                    Delete
                                </button>`;
                        }
                    }
                ]
            });
         });
         $('#example1').on('click', '.show-bs-modal', function (event) {
                var id = $(this).data(""id"");
                var modal = $(""#modal-default"");
                modal.find('.modal-body p').text('Are you sure you want to delete this record?')
                //$(""#deleteForm"").attr(""actio");
                WriteLiteral(@"n"", ""/admin/category/delete/"" + id );
                $(""#deleteId"").val(id);
                modal.modal('show');
            });

            $(""#deleteButton"").click(function(){
                $(""#deleteForm"").submit();
            });
    </script>


");
                EndContext();
            }
            );
            BeginContext(2532, 1646, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">DataTable with minimal features & hover style</h3>
            </div>
           
        </div>
        <!-- /.card -->

        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">DataTable with default features</h3>
            </div>
            <!-- /.card-header -->
            <div class=""card-body"">
                <table id=""example1"" class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th><input type=""checkbox"" /></th>
                            <th>Name</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <!-- /.card-body -->
        </div>
        <!-- /.card -->
    </div>
    <!-- /.col -->
<");
            WriteLiteral(@"/div>
<!-- /.row -->
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Delete</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
                <form id=""deleteForm"" action=""/admin/category/delete"" method=""post"">
                    ");
            EndContext();
            BeginContext(4179, 23, false);
#line 113 "C:\Users\User\source\repos\MyProject\FoodOrdering\Areas\Admin\Views\Category\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(4202, 508, true);
            WriteLiteral(@"
                    <input type=""hidden"" id=""deleteId"" value="""" name=""id"" />
                </form>
            </div>
            <div class=""modal-footer justify-content-between"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" id=""deleteButton"" class=""btn btn-danger"">Yes, Delete!</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
