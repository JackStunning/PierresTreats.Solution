#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4bfe050110c5ccfdcc3fdcb460e2f64d64216b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_AddFlavor), @"mvc.1.0.view", @"/Views/Treats/AddFlavor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/AddFlavor.cshtml", typeof(AspNetCore.Views_Treats_AddFlavor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bfe050110c5ccfdcc3fdcb460e2f64d64216b4", @"/Views/Treats/AddFlavor.cshtml")]
    public class Views_Treats_AddFlavor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierres.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 58, true);
            WriteLiteral("\r\n<h2>Add a flavor</h2>\r\n\r\n<h4>Add a flavor to this task: ");
            EndContext();
            BeginContext(120, 41, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
                          Write(Html.DisplayFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(161, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(205, 38, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(252, 27, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
Write(Html.Label("Select flavor"));

#line default
#line hidden
            EndContext();
            BeginContext(286, 29, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
Write(Html.DropDownList("FlavorId"));

#line default
#line hidden
            EndContext();
            BeginContext(319, 57, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
}

#line default
#line hidden
            BeginContext(379, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(385, 40, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\AddFlavor.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(425, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierres.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
