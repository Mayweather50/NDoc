#pragma checksum "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\CreateDocuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db8425160ceaa57ca0fea6b0460afc03bf9b7c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateDocuments), @"mvc.1.0.view", @"/Views/Admin/CreateDocuments.cshtml")]
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
#line 1 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\_ViewImports.cshtml"
using testNdoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\_ViewImports.cshtml"
using testNdoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8425160ceaa57ca0fea6b0460afc03bf9b7c04", @"/Views/Admin/CreateDocuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e93b8b1548dfbd2d369b6e6bc9d6efbbaad31285", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateDocuments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"<!--<form method=""post"" enctype=""multipart/form-data"" >
    <br />
    <input type=""hidden"" asp-for=""SectionId"" />
    <label asp-for=""Name"">Имя</label>
    <input type=""text"" asp-for=""Name"" />

    <input type=""file"" name=""filesupload"" multiple />
    <input type=""button"" value=""Добавить"" onclick=""SaveDocument()"" />
    <hr />
    <h2>");
#nullable restore
#line 21 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\CreateDocuments.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n</form>\r\n  \r\n\r\n\r\n<div id=\"TableDocumentsContainer\">\r\n\r\n</div>\r\n\r\n<script>\r\n    function SaveDocument() {\r\n        console.log(\"2323\");\r\n    }\r\n</script>-->");
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
