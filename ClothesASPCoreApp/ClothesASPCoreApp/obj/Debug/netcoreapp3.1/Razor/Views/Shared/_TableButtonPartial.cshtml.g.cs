#pragma checksum "C:\Users\vohoa\Downloads\WebCuoiKy-TMDT-master\WebCuoiKy-TMDT-master\ClothesASPCoreApp\ClothesASPCoreApp\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "790f73ac9567ff94d2ea7df6504b5d26fd78149c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
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
#line 1 "C:\Users\vohoa\Downloads\WebCuoiKy-TMDT-master\WebCuoiKy-TMDT-master\ClothesASPCoreApp\ClothesASPCoreApp\Views\_ViewImports.cshtml"
using ClothesASPCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vohoa\Downloads\WebCuoiKy-TMDT-master\WebCuoiKy-TMDT-master\ClothesASPCoreApp\ClothesASPCoreApp\Views\_ViewImports.cshtml"
using ClothesASPCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790f73ac9567ff94d2ea7df6504b5d26fd78149c", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a5a40f201b5766cc8c8bd6b1b6d206553db2b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<td style=\"width:150px\">\n    <div class=\"btn-group\" role=\"group\">\n        <a type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 126, "\"", 178, 1);
#nullable restore
#line 5 "C:\Users\vohoa\Downloads\WebCuoiKy-TMDT-master\WebCuoiKy-TMDT-master\ClothesASPCoreApp\ClothesASPCoreApp\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 133, Url.Action("Edit/"+Model).Replace("%2F","/"), 133, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\"fas fa-edit\"></i>\n        </a>\n        <a type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 282, "\"", 337, 1);
#nullable restore
#line 8 "C:\Users\vohoa\Downloads\WebCuoiKy-TMDT-master\WebCuoiKy-TMDT-master\ClothesASPCoreApp\ClothesASPCoreApp\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 289, Url.Action("Details/"+Model).Replace("%2F","/"), 289, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\"far fa-list-alt\"></i>\n        </a>\n        <a type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 444, "\"", 498, 1);
#nullable restore
#line 11 "C:\Users\vohoa\Downloads\WebCuoiKy-TMDT-master\WebCuoiKy-TMDT-master\ClothesASPCoreApp\ClothesASPCoreApp\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 451, Url.Action("Delete/"+Model).Replace("%2F","/"), 451, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\"fas fa-trash-alt\"></i>\n        </a>\n    </div>\n</td>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591