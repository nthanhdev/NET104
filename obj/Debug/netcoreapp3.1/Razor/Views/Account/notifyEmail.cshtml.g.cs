#pragma checksum "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\Account\notifyEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0a1432d881b35690c6ed9047c056da0da2b214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_notifyEmail), @"mvc.1.0.view", @"/Views/Account/notifyEmail.cshtml")]
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
#line 1 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\_ViewImports.cshtml"
using ASMMAIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\_ViewImports.cshtml"
using ASMMAIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0a1432d881b35690c6ed9047c056da0da2b214", @"/Views/Account/notifyEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6026e44d3c177711fb395dba6086084292801d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_notifyEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\Account\notifyEmail.cshtml"
  
    ViewData["Title"] = "Xác thực email";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .box { 
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    .box_title { 
        font-size: 3rem;
        color: var(--secondary);
    }

    .box_desc{ 
        font-size: 1.4rem;
    }

</style>


<div class=""grid"">
    <div class=""grid_row box"">

        <h1 class=""box_title"">Xác thực email để hoàn tất</h1>
        <p class=""box_desc"">Cảm ơn bạn đã đăng ký tại shop lego. Chúng tối đã gửi cho bạn 1 email đính kèm link xác nhận vui lòng tiến hành kiểm tra email để hoàn tất.</p>
        <img class=""image"" src=""/images/emailchecker.png""");
            BeginWriteAttribute("alt", " alt=\"", 675, "\"", 681, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 800px;\">\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591