#pragma checksum "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de43dd459f136b24b7c03c5aee8302ebe3ac8758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Codegym_List), @"mvc.1.0.view", @"/Views/Codegym/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Codegym/List.cshtml", typeof(AspNetCore.Views_Codegym_List))]
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
#line 1 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\_ViewImports.cshtml"
using DemoAjaxCallController;

#line default
#line hidden
#line 1 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
using DemoAjaxCallController.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de43dd459f136b24b7c03c5aee8302ebe3ac8758", @"/Views/Codegym/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184aed3416b875b457d48eac1c0fd810ab1477ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Codegym_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Codegymer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(106, 296, true);
            WriteLiteral(@"
<h1 class=""text-center"">Danh Sách Học Viên Codegym</h1>

<div class=""row"">
    <table class=""table"">
        <tr>
            <td>Mã Học Viên</td>
            <td>Tên Học Viên</td>
            <td>Đẹp Trai</td>
            <td>Giàu</td>
            <td>Thông Minh</td>
        </tr>
");
            EndContext();
#line 20 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
         for (int i = 0; i < Model.Count ; i++)
        {

#line default
#line hidden
            BeginContext(462, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(523, 11, false);
#line 24 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
               Write(Model[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(534, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(557, 28, false);
#line 25 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
               Write(Html.HiddenFor(m => m[i].Id));

#line default
#line hidden
            EndContext();
            BeginContext(585, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(631, 13, false);
#line 27 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
               Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(644, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(672, 45, false);
#line 28 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
               Write(Html.CheckBoxFor(Model => Model[i].IsDepTrai));

#line default
#line hidden
            EndContext();
            BeginContext(717, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(745, 42, false);
#line 29 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
               Write(Html.CheckBoxFor(Model => Model[i].IsGiau));

#line default
#line hidden
            EndContext();
            BeginContext(787, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(815, 47, false);
#line 30 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
               Write(Html.CheckBoxFor(Model => Model[i].IsThongMinh));

#line default
#line hidden
            EndContext();
            BeginContext(862, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
        }

#line default
#line hidden
            BeginContext(899, 392, true);
            WriteLiteral(@"    </table>
</div>

<script>
    $('input[type=""checkbox""]').click(function (d) {
        let idValue = $(this).attr('name');
        let textTmp = idValue.split('.');
        let id = getId(textTmp[0]) + 1;
        console.log(id);

        //var stt = $(this).data(""stt"");

        var data = {
            id: id,
            attr: textTmp[1]
        }
        var url = """);
            EndContext();
            BeginContext(1292, 26, false);
#line 49 "D:\ProjectNET\DemoAjaxCallController\DemoAjaxCallController\Views\Codegym\List.cshtml"
              Write(Url.Action("UpdateStatus"));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 284, true);
            WriteLiteral(@""";
        var success = function (result) {
            console.log(result);
        };
        $.post(url, data, success);

    });

    function getId(str) {
        let kq = str.replace('[', '');
        kq = kq.replace(']', '');

        return +kq;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Codegymer>> Html { get; private set; }
    }
}
#pragma warning restore 1591