#pragma checksum "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e9c10cd21e6c152deeaa583a66c8747ed7b3f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Experience_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Experience/Default.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.AppCode.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.PersonModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e9c10cd21e6c152deeaa583a66c8747ed7b3f0", @"/Views/Shared/Components/Experience/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cf9172ebfc22aefac038d37d14f5194a0d0e0b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Experience_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""margin-bottom: 40px"">
        <div style=""
                display: table-cell;
                vertical-align: top;
                padding-right: 10px;
              "">
            <span style=""
                  font-size: 13px;
                  font-weight: bold;
                  display: inline-block;
                  width: 130px;
                "">");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
             Write(item.StartYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
                             Write(item.EndYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
        <div style=""margin-bottom: 20px"">
            <div style=""
                  box-shadow: none;
                  border-radius: 0px;
                  margin-bottom: 30px;
                  position: relative;
                  border: none;
                  margin-top: 0px;
                "">
                <div style=""margin-right: -15px; margin-left: -15px"">
                    <div style=""width: 33.33333333%; float: left"">
                        ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
                                 Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div style=\"width: 33.33333333%; float: left; font-style:italic\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
                   Write(item.Details.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Views\Shared\Components\Experience\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
