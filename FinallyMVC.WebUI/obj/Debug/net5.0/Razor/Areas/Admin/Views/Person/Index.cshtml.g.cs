#pragma checksum "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b2ac091a23bc18c33f4e5184ee6a62f01937ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Person_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Person/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.PersonModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.BackgroundModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.BlogModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.ContactModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.ExperienceModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.ServiceModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.SkillModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b2ac091a23bc18c33f4e5184ee6a62f01937ce", @"/Areas/Admin/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0501eb553750b685a65143db9faaf12c8bb293", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ListBody", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page-header start -->
<div class=""page-header"">
    <div class=""row align-items-end"">
        <div class=""col-lg-8"">
            <div class=""page-header-title"">
                <div class=""d-inline"">
                    <h4>Bootstrap Basic Tables</h4>
                    <span>
                        lorem ipsum dolor sit amet, consectetur adipisicing
                        elit
                    </span>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""page-header-breadcrumb"">
                <ul class=""breadcrumb-title"">
                    <li class=""breadcrumb-item"" style=""float: left;"">
                        <a href=""../index.html""> <i class=""feather icon-home""></i> </a>
                    </li>
                    <li class=""breadcrumb-item"" style=""float: left;"">
                        <a href=""#!"">Bootstrap Table</a>
                    </li>
                    <li class=""breadcrumb-item"" style=""float: ");
            WriteLiteral(@"left;"">
                        <a href=""#!"">Basic Table</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Page-header end -->
<!-- Page-body start -->
<div class=""page-body"">
    <!-- Basic table card start -->
    <div class=""card"">
        <div class=""card-header"">
            <h5>Basic Table</h5>
            <span>use class <code>table</code> inside table element</span>

        </div>
        <div class=""card-block table-border-style"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Location</th>
                            <th>Experience</th>
                            <th>Age</th>
                            <th>Degree</th>
                            <th>Careerlevel</th>
                            <th>Phone</th>
                            <th>Email</");
            WriteLiteral("th>\r\n                            <th>Website</th>\r\n                            <th>Fax</th>\r\n                            <th class=\"operation\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b2ac091a23bc18c33f4e5184ee6a62f01937ce9321", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-plus\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody id=\"dynamic-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8b2ac091a23bc18c33f4e5184ee6a62f01937ce10834", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 71 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\Person\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Basic table card end -->\r\n</div>\r\n\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b2ac091a23bc18c33f4e5184ee6a62f01937ce12687", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        function removeEntity(e, id, name) {
            e.preventDefault();

            swal({
                title: ""Diqqət!"",
                text: `${name} - silinsinmi?`,
                icon: ""warning"",
                buttons: ['Xeyr', 'Bəli'],
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {

                        $.ajax({
                            url: `");
#nullable restore
#line 99 "C:\Users\Admin\Desktop\New folder\FinallyMVC\FinallyMVC.WebUI\Areas\Admin\Views\Person\Index.cshtml"
                             Write(Url.Action("Remove"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/${id}`,
                            type: ""POST"",
                            success: function (response, statusText, xhr) {

                                if (/[<>]+/g.test(xhr.responseText) == true
                                    || xhr.responseText.replace(/(\r|\n|\r\n|\s)/g, '').length == 0) {
                                    $('#dynamic-body').html(xhr.responseText);
                                }
                                else {
                                    toastr.error(response.message, ""Xəta!"");
                                }
                            },
                            error: function(response) {
                                toastr.error('Sistem xətası.Biraz sonra yenidən yoxlayın', ""Xəta!"")
                                console.warn(response);
                            }

                        });

                    }
                });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
