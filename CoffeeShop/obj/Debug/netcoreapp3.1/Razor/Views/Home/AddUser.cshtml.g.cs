#pragma checksum "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f3c1fe6ecb4a8718dc28a5673afee14c3eff117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddUser), @"mvc.1.0.view", @"/Views/Home/AddUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3c1fe6ecb4a8718dc28a5673afee14c3eff117", @"/Views/Home/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserID>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\AddUser.cshtml"
  
    ViewData["Title"] = "AddUser";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <h1 >Welcome to Cuppa Joe <span class=\"text-primary\">");
#nullable restore
#line 9 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\AddUser.cshtml"
                                                    Write(Model.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</span></h1>\r\n<h1>We see that you like your coffee roasted <span class=\"text-info\"> ");
#nullable restore
#line 10 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\AddUser.cshtml"
                                                                 Write(Model.preference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  ");
#nullable restore
#line 10 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\AddUser.cshtml"
                                                                                                 if (Model.homeRoast == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-secondary\"> and you <span class=\"text-danger\">home roast</span></span>");
#nullable restore
#line 10 "C:\Users\josep\source\repos\CoffeeShop\CoffeeShop\Views\Home\AddUser.cshtml"
                                                                                                                                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserID> Html { get; private set; }
    }
}
#pragma warning restore 1591
