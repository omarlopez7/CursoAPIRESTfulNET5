#pragma checksum "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\Shared\_RatingPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ce11f426dfc596c289566dc83ecc21fdb338d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RatingPartial), @"mvc.1.0.view", @"/Views/Shared/_RatingPartial.cshtml")]
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
#line 1 "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\_ViewImports.cshtml"
using ProductWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\_ViewImports.cshtml"
using ProductWEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ce11f426dfc596c289566dc83ecc21fdb338d3", @"/Views/Shared/_RatingPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c64bce0f1aa8b6c627b8cb3645e757b95c1315a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RatingPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<double>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\Shared\_RatingPartial.cshtml"
   
    string startWidth = (Model * 95 / 5).ToString() + "px";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"crop\"");
            BeginWriteAttribute("style", " style=\"", 101, "\"", 126, 2);
            WriteAttributeValue("", 109, "width:", 109, 6, true);
#nullable restore
#line 5 "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\Shared\_RatingPartial.cshtml"
WriteAttributeValue("", 115, startWidth, 115, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 127, "\"", 141, 1);
#nullable restore
#line 5 "C:\Users\Dnarvaez\source\repos\Udemy\CursoAPIProductASPNETCore\ProductWEB\Views\Shared\_RatingPartial.cshtml"
WriteAttributeValue("", 135, Model, 135, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div style=\"width:100px\">\r\n        <i class=\"fa fa-star\"></i>\r\n        <i class=\"fa fa-star\"></i>\r\n        <i class=\"fa fa-star\"></i>\r\n        <i class=\"fa fa-star\"></i>\r\n        <i class=\"fa fa-star\"></i>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<double> Html { get; private set; }
    }
}
#pragma warning restore 1591