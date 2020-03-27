#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c562ba3a03fbaeead281ff1c0ba61ea29d49960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Details), @"mvc.1.0.view", @"/Views/Treats/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Details.cshtml", typeof(AspNetCore.Views_Treats_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c562ba3a03fbaeead281ff1c0ba61ea29d49960", @"/Views/Treats/Details.cshtml")]
    public class Views_Treats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierres.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 38, true);
            WriteLiteral("\r\n<h2>Treat Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(101, 15, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
Write(Model.TreatName);

#line default
#line hidden
            EndContext();
            BeginContext(116, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
 if(@Model.Flavors.Count == 0)
{

#line default
#line hidden
            BeginContext(160, 48, true);
            WriteLiteral("  <p>This treat does not have any flavors.</p>\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(220, 51, true);
            WriteLiteral("  <h4>Flavors the Treat has written:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
   foreach(var join in Model.Flavors)
  {

#line default
#line hidden
            BeginContext(315, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(324, 103, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
   Write(Html.ActionLink($"{ join.Flavor.FlavorName }", "Details", "Flavors", new { id = join.Flavor.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(427, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
     using (Html.BeginForm("DeleteFlavor", "Treats"))
    {
      

#line default
#line hidden
            BeginContext(503, 42, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
 Write(Html.Hidden("joinId", @join.TreatFlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(547, 79, true);
            WriteLiteral("      <input class=\"button\" id=\"detailsDelete\" type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
    }

#line default
#line hidden
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(638, 19, true);
            WriteLiteral("  </ul>\r\n  <hr />\r\n");
            EndContext();
#line 30 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
}

#line default
#line hidden
            BeginContext(660, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(666, 42, false);
#line 32 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Back to Treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(708, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(718, 72, false);
#line 33 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Add a Flavor", "AddFlavor", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(790, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(800, 65, false);
#line 34 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Edit Treat", "Edit", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(865, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(875, 69, false);
#line 35 "C:\Users\Stunning\Desktop\epicodusProjects\c#\PierresTreats.Solution\Pierres\Views\Treats\Details.cshtml"
Write(Html.ActionLink("Delete Treat", "Delete", new { id = Model.TreatId }));

#line default
#line hidden
            EndContext();
            BeginContext(944, 4, true);
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
