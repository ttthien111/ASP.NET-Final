#pragma checksum "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "735739de29720cfa63fb4f62c88b5261c0b4ef34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KhachHangs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/KhachHangs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/KhachHangs/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_KhachHangs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"735739de29720cfa63fb4f62c88b5261c0b4ef34", @"/Areas/Admin/Views/KhachHangs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc14f7e575c464fbbdb75f6c33be9a2ed62694e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_KhachHangs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 110, true);
            WriteLiteral("\n\n\n<div>\n    <h4>Thông tin khách hàng</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(248, 44, false);
#line 15 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(292, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(333, 40, false);
#line 18 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(373, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(414, 43, false);
#line 21 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(457, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(498, 39, false);
#line 24 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(537, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(578, 41, false);
#line 27 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(619, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(660, 37, false);
#line 30 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(697, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(738, 44, false);
#line 33 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(782, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(823, 40, false);
#line 36 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(863, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(904, 44, false);
#line 39 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(948, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(989, 40, false);
#line 42 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1070, 42, false);
#line 45 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1153, 38, false);
#line 48 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1232, 45, false);
#line 51 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1318, 41, false);
#line 54 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1400, 41, false);
#line 57 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1482, 37, false);
#line 60 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1560, 40, false);
#line 63 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1641, 36, false);
#line 66 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1718, 47, false);
#line 69 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1806, 43, false);
#line 72 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 38, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n");
            EndContext();
            BeginContext(1977, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1981, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3132bf3dfe6c4c11920cee443211fa18", async() => {
                BeginContext(2027, 7, true);
                WriteLiteral("Trở lại");
                EndContext();
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
            EndContext();
            BeginContext(2038, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
