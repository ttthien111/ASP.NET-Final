#pragma checksum "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b37575a6582c0aacf720b78d560c3a0032a6186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinTucs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/TinTucs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/TinTucs/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_TinTucs_Details))]
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
#line 1 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b37575a6582c0aacf720b78d560c3a0032a6186", @"/Areas/Admin/Views/TinTucs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc14f7e575c464fbbdb75f6c33be9a2ed62694e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinTucs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.TinTuc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 106, true);
            WriteLiteral("\n<h2>Thông tin tin tức</h2>\n\n<div>\n   \n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(241, 43, false);
#line 15 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(284, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(325, 39, false);
#line 18 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(364, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(405, 43, false);
#line 21 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(448, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(489, 39, false);
#line 24 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(528, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(569, 45, false);
#line 27 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(614, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(655, 41, false);
#line 30 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(696, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(737, 52, false);
#line 33 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoaiTtNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(789, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(830, 55, false);
#line 36 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.LoaiTtNavigation.LoaiTt));

#line default
#line hidden
            EndContext();
            BeginContext(885, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(926, 50, false);
#line 39 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNvNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(976, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1017, 52, false);
#line 42 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaNvNavigation.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1111, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66a0e940b82e462988d7917c09a390d7", async() => {
                BeginContext(1183, 3, true);
                WriteLiteral("Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Details.cshtml"
                           WriteLiteral(Model.MaTt);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1190, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1197, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38291e66c2384f57a8e25d85952b5c87", async() => {
                BeginContext(1243, 7, true);
                WriteLiteral("Trở lại");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1254, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.TinTuc> Html { get; private set; }
    }
}
#pragma warning restore 1591