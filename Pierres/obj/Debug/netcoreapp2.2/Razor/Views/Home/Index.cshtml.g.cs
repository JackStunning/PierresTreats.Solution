#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66babf7421f98441f951d4ae2c5f8365e5043dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66babf7421f98441f951d4ae2c5f8365e5043dbb", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 35, true);
            WriteLiteral("\r\n<h1>Welcome to Pierre\'s!</h1>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(105, 13, true);
            WriteLiteral("    <p>Hello ");
            EndContext();
            BeginContext(119, 18, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(137, 7, true);
            WriteLiteral("!</p>\r\n");
            EndContext();
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(147, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(153, 57, false);
#line 12 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
Write(Html.ActionLink("See Pierre's Treats", "Index", "Treats"));

#line default
#line hidden
            EndContext();
            BeginContext(210, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(220, 59, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
Write(Html.ActionLink("See Pierre's Flavors", "Index", "Flavors"));

#line default
#line hidden
            EndContext();
            BeginContext(279, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(289, 56, false);
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Home\Index.cshtml"
Write(Html.ActionLink("Create an account", "Index", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(345, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
