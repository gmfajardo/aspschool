#pragma checksum "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7aad151d98d116f9e7bfe5d82d8adac04355542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7aad151d98d116f9e7bfe5d82d8adac04355542", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea45552c215b067b37f56a8d9fa669c7cf6b10ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Escuela";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(83, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(88, 17, false);
#line 6 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 20, true);
            WriteLiteral("</h1>\r\n<h2>Nombre:  ");
            EndContext();
            BeginContext(126, 12, false);
#line 7 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(138, 30, true);
            WriteLiteral("  </h2>\r\n<h3>Tipo de escuela: ");
            EndContext();
            BeginContext(169, 17, false);
#line 8 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(186, 36, true);
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Direccion: ");
            EndContext();
            BeginContext(223, 15, false);
#line 10 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(238, 19, true);
            WriteLiteral("</p>\r\n    <p>Pais: ");
            EndContext();
            BeginContext(258, 10, false);
#line 11 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(268, 21, true);
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
            EndContext();
            BeginContext(290, 12, false);
#line 12 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(302, 47, true);
            WriteLiteral("</p>\r\n</address>\r\n\r\n<p>Año en que fue fundada: ");
            EndContext();
            BeginContext(350, 19, false);
#line 15 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
                      Write(Model.AñoDeCreación);

#line default
#line hidden
            EndContext();
            BeginContext(369, 14, true);
            WriteLiteral("</p>\r\n\r\n<p><i>");
            EndContext();
            BeginContext(384, 20, false);
#line 17 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Escuela\Index.cshtml"
 Write(ViewBag.CosaDinamica);

#line default
#line hidden
            EndContext();
            BeginContext(404, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
