#pragma checksum "C:\Users\Chu\Source\Repos\aspplatzi\Views\Shared\AsignaturaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e9171407e3a7c46759af9555853445c9e26ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AsignaturaSimple), @"mvc.1.0.view", @"/Views/Shared/AsignaturaSimple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AsignaturaSimple.cshtml", typeof(AspNetCore.Views_Shared_AsignaturaSimple))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e9171407e3a7c46759af9555853445c9e26ae1", @"/Views/Shared/AsignaturaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea45552c215b067b37f56a8d9fa669c7cf6b10ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AsignaturaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 17, true);
            WriteLiteral("<p>\n    Nombre:  ");
            EndContext();
            BeginContext(36, 12, false);
#line 3 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Shared\AsignaturaSimple.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(48, 11, true);
            WriteLiteral("  \n    Id: ");
            EndContext();
            BeginContext(60, 14, false);
#line 4 "C:\Users\Chu\Source\Repos\aspplatzi\Views\Shared\AsignaturaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(74, 6, true);
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591
