#pragma checksum "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf067ba09f06497659ebbed83531a18932ccbd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_LoaiTinTucs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/LoaiTinTucs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/LoaiTinTucs/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_LoaiTinTucs_Index))]
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
#line 3 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf067ba09f06497659ebbed83531a18932ccbd9", @"/Areas/Admin/Views/LoaiTinTucs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc14f7e575c464fbbdb75f6c33be9a2ed62694e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_LoaiTinTucs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.LoaiTinTuc>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(245, 109, true);
            WriteLiteral("\n\n\n<div class=\"outer-w3-agile mt-3\">\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách Loại Tin Tức</h4>\n    ");
            EndContext();
            BeginContext(354, 348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94efe0e98f941e488c0c87679db8c3e", async() => {
                BeginContext(393, 80, true);
                WriteLiteral("\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\n               value=\"", 473, "\"", 529, 1);
#line 16 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
WriteAttributeValue("", 496, Model.RouteValue["searchString"], 496, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(530, 165, true);
                WriteLiteral(" />\n        <button type=\"submit\" class=\"btn btn-info\">\n            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Search\n        </button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(702, 28, true);
            WriteLiteral("\n    <hr />\n    <p>\n        ");
            EndContext();
            BeginContext(730, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19b4706e117b46f6b0a80292f0055655", async() => {
                BeginContext(777, 7, true);
                WriteLiteral("Tạo mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(788, 136, true);
            WriteLiteral("\n    </p>\n    <table class=\"table table-striped\">\n        <thead>\n            <tr>\n                <th scope=\"col\">\n                    ");
            EndContext();
            BeginContext(925, 41, false);
#line 29 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TenTt));

#line default
#line hidden
            EndContext();
            BeginContext(966, 100, true);
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 35 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1121, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1140, "\"", 1180, 4);
            WriteAttributeValue("", 1150, "_delete(\'", 1150, 9, true);
#line 37 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
WriteAttributeValue("", 1159, item.LoaiTt, 1159, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1171, "\',", 1171, 2, true);
            WriteAttributeValue(" ", 1173, "event)", 1174, 7, true);
            EndWriteAttribute();
            BeginContext(1181, 63, true);
            WriteLiteral(">\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(1245, 40, false);
#line 39 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenTt));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 88, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(1373, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0483644abae34539b398e3cb9e69ff49", async() => {
                BeginContext(1446, 3, true);
                WriteLiteral("Sửa");
                EndContext();
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
#line 42 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
                                               WriteLiteral(item.LoaiTt);

#line default
#line hidden
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
            EndContext();
            BeginContext(1453, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(1480, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e99a224e15146f9815f0a609e672c3d", async() => {
                BeginContext(1556, 12, true);
                WriteLiteral("Xem chi tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
                                                  WriteLiteral(item.LoaiTt);

#line default
#line hidden
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
            EndContext();
            BeginContext(1572, 146, true);
            WriteLiteral(" |\n\n                        <button type=\"button\" class=\"btn btn-primary btn-delete\">Xóa</button>\n                    </td>\n                </tr>\n");
            EndContext();
#line 48 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1732, 1086, true);
            WriteLiteral(@"        </tbody>
    </table>
    <script>
        function _delete(id, ev) {
            if (ev.target.className == 'btn btn-primary btn-delete') {
                console.log(ev.target);
                console.log(ev.currentTarget);
                var cf = confirm('Bạn có muốn xoá loại tt: ' + id + '?');
                if (cf) {
                    $(ev.currentTarget).fadeOut();
                    $.ajax({
                        url: '/api/LoaiTinTucs/' + id,
                        type: ""Delete"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        async: true,
                        success: function (result) {
                            alert(""Xoá thành công"");
                        },
                        error: function (errormessage) {
                            alert(errormessage.responseText);
                        }
                    });
                }
            }
        }
    </script>
    ");
            WriteLiteral("<nav class=\"navbar-default justify-content-center\">\n\n\n        ");
            EndContext();
            BeginContext(2819, 135, false);
#line 79 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\LoaiTinTucs\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(2954, 20, true);
            WriteLiteral("\n\n\n    </nav>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.LoaiTinTuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591