#pragma checksum "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\InsufficientFunds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "118ed919160348fec2b8bfd89b5c85f51389493c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InsufficientFunds), @"mvc.1.0.view", @"/Views/Home/InsufficientFunds.cshtml")]
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
#line 1 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"118ed919160348fec2b8bfd89b5c85f51389493c", @"/Views/Home/InsufficientFunds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InsufficientFunds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\InsufficientFunds.cshtml"
  
    ViewData["Title"] = "InsufficientFunds";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-3 text-warning\">You Cannot Buy this item because you do not have enough funds!</h1>\r\n<h1 class=\"display-4\">The Item costs $");
#nullable restore
#line 8 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\InsufficientFunds.cshtml"
                                 Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and you only have $");
#nullable restore
#line 8 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\InsufficientFunds.cshtml"
                                                                   Write(ViewBag.Funds);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n\r\n");
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
