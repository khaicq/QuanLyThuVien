#pragma checksum "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "164a9aaa97e79f38574f33724ac38077b9c80bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLy_XuLy), @"mvc.1.0.view", @"/Views/QuanLy/XuLy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLy/XuLy.cshtml", typeof(AspNetCore.Views_QuanLy_XuLy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164a9aaa97e79f38574f33724ac38077b9c80bce", @"/Views/QuanLy/XuLy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLy_XuLy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.ViewModels.viewMuonSach>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
  
    ViewData["Title"] = "XuLy";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(153, 23, true);
            WriteLiteral("<h2>XuLy</h2>\r\n<br />\r\n");
            EndContext();
#line 9 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
 using (Html.BeginForm("GiaoHet", "QuanLy",new { id=ViewBag.IDDocGia}))
{

#line default
#line hidden
            BeginContext(252, 94, true);
            WriteLiteral("    <input type=\"submit\" name=\"GiaoHet\" value=\"Giao toàn bộ sách\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 12 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
}

#line default
#line hidden
            BeginContext(349, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
 using (Html.BeginForm("NhanHet", "QuanLy", new { id = ViewBag.IDDocGia }))
{

#line default
#line hidden
            BeginContext(441, 94, true);
            WriteLiteral("    <input type=\"submit\" name=\"GiaoHet\" value=\"Nhận toàn bộ sách\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 19 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
}

#line default
#line hidden
            BeginContext(538, 16, true);
            WriteLiteral("\r\n    <br />\r\n\r\n");
            EndContext();
            BeginContext(555, 64, false);
#line 23 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(619, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(706, 43, false);
#line 28 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.IDPhieu));

#line default
#line hidden
            EndContext();
            BeginContext(749, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(805, 45, false);
#line 31 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(850, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(906, 46, false);
#line 34 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1008, 43, false);
#line 37 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TenSach));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1107, 47, false);
#line 40 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TenNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1210, 47, false);
#line 43 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1313, 49, false);
#line 46 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1418, 43, false);
#line 49 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.PhiMuon));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1517, 43, false);
#line 52 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TienCoc));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1616, 44, false);
#line 55 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayMuon));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1716, 45, false);
#line 58 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1817, 43, false);
#line 61 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1916, 47, false);
#line 64 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayTraThuc));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 70 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2098, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2159, 42, false);
#line 74 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.IDPhieu));

#line default
#line hidden
            EndContext();
            BeginContext(2201, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2269, 44, false);
#line 77 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenDocGia));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 80 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.LoaiDocGia == 0)
                    {

#line default
#line hidden
            BeginContext(2431, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2457, 12, true);
            WriteLiteral("Giảng Viên\r\n");
            EndContext();
#line 83 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                    }

#line default
#line hidden
            BeginContext(2492, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 84 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.LoaiDocGia == 1)
                    {

#line default
#line hidden
            BeginContext(2563, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2589, 11, true);
            WriteLiteral("Sinh Viên\r\n");
            EndContext();
#line 87 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                    }

#line default
#line hidden
            BeginContext(2623, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 88 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.LoaiDocGia == 1)
                    {

#line default
#line hidden
            BeginContext(2694, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2720, 14, true);
            WriteLiteral("Độc giả khác\r\n");
            EndContext();
#line 91 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                    }

#line default
#line hidden
            BeginContext(2757, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2823, 42, false);
#line 94 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenSach));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2933, 46, false);
#line 97 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(2979, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3047, 46, false);
#line 100 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(3093, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3161, 48, false);
#line 103 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.TinhTrangSach));

#line default
#line hidden
            EndContext();
            BeginContext(3209, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3277, 42, false);
#line 106 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhiMuon));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3387, 42, false);
#line 109 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.TienCoc));

#line default
#line hidden
            EndContext();
            BeginContext(3429, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3497, 43, false);
#line 112 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayMuon));

#line default
#line hidden
            EndContext();
            BeginContext(3540, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 115 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.TrangThai == 0)
                    {

#line default
#line hidden
            BeginContext(3657, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3683, 13, true);
            WriteLiteral("Đã đặt sách\r\n");
            EndContext();
#line 118 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                    }

#line default
#line hidden
            BeginContext(3719, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 119 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.TrangThai == 1)
                    {

#line default
#line hidden
            BeginContext(3789, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3815, 16, true);
            WriteLiteral("Đang mượn sách\r\n");
            EndContext();
#line 122 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                    }

#line default
#line hidden
            BeginContext(3854, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3920, 42, false);
#line 125 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTra));

#line default
#line hidden
            EndContext();
            BeginContext(3962, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4030, 46, false);
#line 128 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTraThuc));

#line default
#line hidden
            EndContext();
            BeginContext(4076, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 131 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.TrangThai == 0)
                    {
                        

#line default
#line hidden
            BeginContext(4218, 113, false);
#line 133 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                   Write(Html.ActionLink("Giao sách", "GiaoSach", "QuanLy", new { id = item.IDPhieu }, new { @class = "btn btn-default" }));

#line default
#line hidden
            EndContext();
#line 133 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                                                                                                                                          
                    }

#line default
#line hidden
            BeginContext(4356, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 135 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                     if (item.TrangThai == 1)
                    {
                        

#line default
#line hidden
            BeginContext(4451, 113, false);
#line 137 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                   Write(Html.ActionLink("Nhận sách", "NhanSach", "QuanLy", new { id = item.IDPhieu }, new { @class = "btn btn-default" }));

#line default
#line hidden
            EndContext();
#line 137 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
                                                                                                                                          
                    }

#line default
#line hidden
            BeginContext(4589, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(4610, 69, false);
#line 139 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4679, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 142 "C:\Users\Welcome\Desktop\QuanLyThuVien\QuanLyThuVien\Views\QuanLy\XuLy.cshtml"
        }

#line default
#line hidden
            BeginContext(4734, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.ViewModels.viewMuonSach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
