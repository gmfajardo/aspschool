#pragma checksum "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d19965007845d44b1a94c7f6c0040ec30f7cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_MultiAsignatura), @"mvc.1.0.view", @"/Views/Alumno/MultiAsignatura.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alumno/MultiAsignatura.cshtml", typeof(AspNetCore.Views_Alumno_MultiAsignatura))]
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
#line 1 "C:\Users\Chu\Source\Repos\aspplatzi\Views\_ViewImports.cshtml"
using aspplatzi;

#line default
#line hidden
#line 2 "C:\Users\Chu\Source\Repos\aspplatzi\Views\_ViewImports.cshtml"
using aspplatzi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d19965007845d44b1a94c7f6c0040ec30f7cb6", @"/Views/Alumno/MultiAsignatura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea45552c215b067b37f56a8d9fa669c7cf6b10ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_MultiAsignatura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alumno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
  
    ViewData["Title"] = "Alumnos";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(90, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(95, 17, false);
#line 7 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(112, 209, true);
            WriteLiteral(" </h1>\r\n\r\n\r\n\r\n\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
     foreach (Alumno alumno in Model)
    {

#line default
#line hidden
            BeginContext(367, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(398, 15, false);
#line 23 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
           Write(alumno.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(413, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(437, 13, false);
#line 24 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
           Write(alumno.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(450, 95, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <!-- <partial name=\"ObjetoEscuelaSimple\" model=\"alumno\" />  -->\r\n");
            EndContext();
#line 27 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
    }   

#line default
#line hidden
            BeginContext(555, 32, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p><i>");
            EndContext();
            BeginContext(588, 20, false);
#line 31 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(608, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(613, 17, false);
#line 31 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Alumno\MultiAsignatura.cshtml"
                          Write(ViewData["Fecha"]);

#line default
#line hidden
            EndContext();
            BeginContext(630, 8, true);
            WriteLiteral("</i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591