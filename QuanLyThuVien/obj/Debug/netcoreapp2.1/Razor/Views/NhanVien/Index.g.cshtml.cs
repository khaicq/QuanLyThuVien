#pragma checksum "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c38fd121307ff00bffa295705b037c639b61cd45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Index), @"mvc.1.0.view", @"/Views/NhanVien/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanVien/Index.cshtml", typeof(AspNetCore.Views_NhanVien_Index))]
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
#line 1 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien;

#line default
#line hidden
#line 2 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c38fd121307ff00bffa295705b037c639b61cd45", @"/Views/NhanVien/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.ViewModels.viewNhanVien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
  
    ViewData["Title"] = "Quản lý nhân viên";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(166, 43, true);
            WriteLiteral("\r\n<h2>Danh sách nhân viên</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(209, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cec17f0d4dec426fa44599c5f6059724", async() => {
                BeginContext(232, 17, true);
                WriteLiteral("Tạo tài khoản mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(253, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 46, false);
#line 17 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 44, false);
#line 20 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 43, false);
#line 23 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(591, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(647, 41, false);
#line 26 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(744, 44, false);
#line 29 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(788, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(844, 48, false);
#line 32 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(892, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(948, 42, false);
#line 35 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(990, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1046, 47, false);
#line 38 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 88, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1230, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1291, 45, false);
#line 49 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1404, 43, false);
#line 52 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1515, 42, false);
#line 55 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1625, 40, false);
#line 58 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1733, 43, false);
#line 61 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 64 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                     if (item.LoaiNhanVien == 0)
                    {

#line default
#line hidden
            BeginContext(1896, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1922, 9, true);
            WriteLiteral("Quản lý\r\n");
            EndContext();
#line 67 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1954, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 68 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                     if (item.LoaiNhanVien == 1)
                    {

#line default
#line hidden
            BeginContext(2027, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2053, 10, true);
            WriteLiteral("Bán hàng\r\n");
            EndContext();
#line 71 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2086, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2152, 41, false);
#line 74 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2261, 46, false);
#line 77 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2375, 61, false);
#line 80 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.IDNhanVien }));

#line default
#line hidden
            EndContext();
            BeginContext(2436, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2461, 67, false);
#line 81 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.IDNhanVien }));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2553, 65, false);
#line 82 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.IDNhanVien }));

#line default
#line hidden
            EndContext();
            BeginContext(2618, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 85 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\NhanVien\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2673, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2697, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e59ff2507fb64d7ebb7a769d936b1d36", async() => {
                BeginContext(2767, 21, true);
                WriteLiteral("Quay về trang quản lý");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(2792, 18, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.ViewModels.viewNhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
