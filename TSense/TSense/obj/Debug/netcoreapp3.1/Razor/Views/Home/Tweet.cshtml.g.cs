#pragma checksum "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\Home\Tweet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf2ab21619a62d68c6ee67059a0ee0ae416ecd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tweet), @"mvc.1.0.view", @"/Views/Home/Tweet.cshtml")]
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
#line 1 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\_ViewImports.cshtml"
using TSense;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\_ViewImports.cshtml"
using TSense.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf2ab21619a62d68c6ee67059a0ee0ae416ecd8", @"/Views/Home/Tweet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5f970ef3dd4899a107d9c624abd244eb12c213", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tweet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\Home\Tweet.cshtml"
  
    ViewData["Title"] = "Twitter detector";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\Home\Tweet.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 6 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\Home\Tweet.cshtml"
 using (Html.BeginForm("Tweeted", "Home", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group mx-sm-3 mb-2\">\r\n        <label for=\"inputLink\" class=\"sr-only\">Link</label>\r\n        ");
#nullable restore
#line 10 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\Home\Tweet.cshtml"
   Write(Html.TextBox("tweetLink", null, new { @class= "form - control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-primary mb-2\">Tweet It!</button>\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\Facultate\Anul III Semestrul I\.NET\TSense\.NetProject\TSense\TSense\Views\Home\Tweet.cshtml"
}

#line default
#line hidden
#nullable disable
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
