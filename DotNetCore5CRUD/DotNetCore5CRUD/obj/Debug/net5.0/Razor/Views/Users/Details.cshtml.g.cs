#pragma checksum "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "551420bb17e89a5553ceceeef53daa5c1b4132d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\_ViewImports.cshtml"
using DotNetCore5CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551420bb17e89a5553ceceeef53daa5c1b4132d7", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a92b9b5633859ebe1a6722f2a5711034f0c01d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Thông tin chi tiết nhân viên:</h4>\r\n<div class=\"row justify-content-between mt-60-px\">\r\n    <div class=\"col-md-5\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 194, "\"", 259, 2);
            WriteAttributeValue("", 200, "data:image/*;base64,", 200, 20, true);
#nullable restore
#line 10 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
WriteAttributeValue("", 220, Convert.ToBase64String(Model.Poster), 220, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 282, "\"", 300, 1);
#nullable restore
#line 10 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
WriteAttributeValue("", 288, Model.Title, 288, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-md-7\">\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h6>Mô tả : ");
#nullable restore
#line 14 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h6>Tên : ");
#nullable restore
#line 18 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
                 Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h6>Email : ");
#nullable restore
#line 22 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h6>Địa chỉ : ");
#nullable restore
#line 26 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
                     Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h6>Số điện thoại : ");
#nullable restore
#line 30 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
                           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-between mb-4\">\r\n            <h6>Năm : ");
#nullable restore
#line 34 "C:\Users\ACER\Desktop\Project.Net Core\DotNetCore5CRUD\DotNetCore5CRUD\Views\Users\Details.cshtml"
                 Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n");
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591