#pragma checksum "F:\example\EmptyCore\Views\Shared\Components\Greeter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46222f47b589198f1d2112b26213bc45d6506732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Greeter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Greeter/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Greeter/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Greeter_Default))]
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
#line 1 "F:\example\EmptyCore\Views\_ViewImports.cshtml"
using EmptyCore.Models;

#line default
#line hidden
#line 2 "F:\example\EmptyCore\Views\_ViewImports.cshtml"
using EmptyCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46222f47b589198f1d2112b26213bc45d6506732", @"/Views/Shared/Components/Greeter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6798cd6621d0fcf5eb5902b31327b88fbc212c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Greeter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(22, 5, false);
#line 3 "F:\example\EmptyCore\Views\Shared\Components\Greeter\Default.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(27, 5, true);
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
