#pragma checksum "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002dcb87c4a89d94b1b31a8d811526892d915fe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002dcb87c4a89d94b1b31a8d811526892d915fe2", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a92b9b5633859ebe1a6722f2a5711034f0c01d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\r\n   <i class=\"icofont-user-alt-3\"></i>\r\n    Nhân viên\r\n</h2>\r\n");
            WriteLiteral("<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002dcb87c4a89d94b1b31a8d811526892d915fe25748", async() => {
                WriteLiteral("\r\n    <i class=\"bi bi-plus\"></i>Tạo nhân viên\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"mt-4\">\r\n");
#nullable restore
#line 21 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\">\r\n                <i class=\"bi bi-exclamation-triangle\"></i>\r\n                No users found!\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n");
#nullable restore
#line 31 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12\">\r\n                        <div class=\"card mb-3\">\r\n                            <div class=\"row no-gutters\">\r\n                                <div class=\"col-md-2 poster\"");
            BeginWriteAttribute("style", " style=\"", 870, "\"", 960, 4);
            WriteAttributeValue("", 878, "background-image:", 878, 17, true);
            WriteAttributeValue(" ", 895, "url(data:image\\/*;base64,", 896, 26, true);
#nullable restore
#line 36 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
WriteAttributeValue("", 921, Convert.ToBase64String(user.Poster), 921, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 959, ")", 959, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                <div class=\"col-md-10\">\r\n                                    <div class=\"card-body d-flex flex-column justify-content-between h-100\">\r\n                                        <div>\r\n");
            WriteLiteral("                                            <p>Tên: <span class=\"card-text text-justify\">");
#nullable restore
#line 41 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                                                                                     Write(
                                        user.UserName
                                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
            WriteLiteral("                                            <p>Email: <span class=\"card-text text-justify\">");
#nullable restore
#line 45 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                                                                                       Write(
                                        user.Email
                                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
            WriteLiteral("                                        </div>\r\n                                        <div class=\"d-flex justify-content-between\">\r\n");
            WriteLiteral("                                            <div>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002dcb87c4a89d94b1b31a8d811526892d915fe210472", async() => {
                WriteLiteral("\r\n                                                    <i class=\"bi bi-camera-reels\"></i>\r\n                                                    Details\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                                                                          WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "002dcb87c4a89d94b1b31a8d811526892d915fe212998", async() => {
                WriteLiteral("\r\n                                                    <i class=\"bi bi-pencil\"></i>\r\n                                                    Edit\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                                                                       WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 64 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                                                                                                            Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                    <i class=""bi bi-trash""></i>
                                                    Delete
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 75 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 77 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 79 "C:\Users\ACER\Desktop\QLNV_CRUD\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Index.cshtml"
}
else
{
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);

                bootbox.confirm({
                    message: ""Are you sure that you need to delete this movie?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/users/delete/' + btn.data('id'),
                                success: function () {
                                    var movieContainer = btn.parents('.col-12');
                                  ");
                WriteLiteral(@"  movieContainer.addClass('animate__animated animate__zoomOut');

                                    setTimeout(function () {
                                        movieContainer.remove();
                                    }, 1000);

                                    toastr.success('Movies deleted');
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                            });
                        }
                    }
                });
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
