#pragma checksum "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdea9ef92fbd3b4144bb9c306bf33f24a7544c33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Loais_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Loais/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Loais/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Loais_Index))]
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
#line 3 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdea9ef92fbd3b4144bb9c306bf33f24a7544c33", @"/Areas/Admin/Views/Loais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc14f7e575c464fbbdb75f6c33be9a2ed62694e9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Loais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.Loai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(239, 102, true);
            WriteLiteral("\n<div class=\"outer-w3-agile mt-3\">\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách Loại HH</h4>\n    ");
            EndContext();
            BeginContext(341, 348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaa17e55492d452cba5ec8a34f649376", async() => {
                BeginContext(380, 80, true);
                WriteLiteral("\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\n               value=\"", 460, "\"", 516, 1);
#line 14 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
WriteAttributeValue("", 483, Model.RouteValue["searchString"], 483, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(517, 165, true);
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
            BeginContext(689, 28, true);
            WriteLiteral("\n    <hr />\n    <p>\n        ");
            EndContext();
            BeginContext(717, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aeb0799f99a453380ee80c1a442e131", async() => {
                BeginContext(764, 7, true);
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
            BeginContext(775, 136, true);
            WriteLiteral("\n    </p>\n    <table class=\"table table-striped\">\n        <thead>\n            <tr>\n                <th scope=\"col\">\n                    ");
            EndContext();
            BeginContext(912, 44, false);
#line 27 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(956, 76, true);
            WriteLiteral("\n                </th>\n                <th scope=\"col\">\n                    ");
            EndContext();
            BeginContext(1033, 43, false);
#line 30 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 100, true);
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1231, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1250, "\"", 1290, 4);
            WriteAttributeValue("", 1260, "_delete(\'", 1260, 9, true);
#line 38 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
WriteAttributeValue("", 1269, item.MaLoai, 1269, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1281, "\',", 1281, 2, true);
            WriteAttributeValue(" ", 1283, "event)", 1284, 7, true);
            EndWriteAttribute();
            BeginContext(1291, 68, true);
            WriteLiteral(">\n                    <td scope=\"row\">\n\n                        <a> ");
            EndContext();
            BeginContext(1360, 46, false);
#line 41 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                       Write(Html.Raw(item.GioiTinh == true ? "Nam" : "Nữ"));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 92, true);
            WriteLiteral("</a>\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(1499, 42, false);
#line 44 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 88, true);
            WriteLiteral("\n                    </td>\n                    <td scope=\"row\">\n                        ");
            EndContext();
            BeginContext(1629, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fee823e37bb460e81782c94080040d8", async() => {
                BeginContext(1678, 4, true);
                WriteLiteral("Edit");
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
#line 47 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                                               WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1686, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(1713, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e124639a22b7441fa9713b497356dd9f", async() => {
                BeginContext(1765, 7, true);
                WriteLiteral("Details");
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
#line 48 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                                                  WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1776, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(1803, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d15457902234e5981f58985824247da", async() => {
                BeginContext(1854, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
                                                 WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1864, 145, true);
            WriteLiteral(" |\n                        <button type=\"button\" class=\"btn btn-primary btn-delete\">Xóa</button>\n                    </td>\n                </tr>\n");
            EndContext();
#line 53 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2023, 1091, true);
            WriteLiteral(@"        </tbody>
    </table>
    <script>
        function _delete(id, ev) {
            if (ev.target.className == 'btn btn-primary btn-delete') {
                console.log(ev.target);
                console.log(ev.currentTarget);
                var cf = confirm('Bạn có muốn xoá loại HH ID: ' + id + '?');
                if (cf) {
                    $(ev.currentTarget).fadeOut();
                    $.ajax({
                        url: '/api/Loais/' + id,
                        type: ""Delete"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        async: true,
                        success: function (result) {
                            alert(""Xoá loại HH thành công"");
                        },
                        error: function (errormessage) {
                            alert(errormessage.responseText);
                        }
                    });
                }
            }
        }
    </script>");
            WriteLiteral("\n    <nav class=\"navbar-default justify-content-center\">\n\n\n        ");
            EndContext();
            BeginContext(3115, 135, false);
#line 84 "C:\Users\User\Desktop\ASPFilnal\ASPNETCore_Final-master\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Loais\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(3250, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.Loai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
