#pragma checksum "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eeb521972930d35b39f516c43495d401f0d970f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\_ViewImports.cshtml"
using WebAppDotNetCoreAndEntity;

#line default
#line hidden
#line 2 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\_ViewImports.cshtml"
using WebAppDotNetCoreAndEntity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eeb521972930d35b39f516c43495d401f0d970f", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3605b0702438a1f8449d42e6a1a2ab9b78325b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppDotNetCoreAndEntity.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(352, 14, true);
            WriteLiteral("\r\n\r\n<h2>Name: ");
            EndContext();
            BeginContext(367, 17, false);
#line 13 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml"
     Write(Model.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(384, 19, true);
            WriteLiteral("</h2>\r\n<h2>Reg No: ");
            EndContext();
            BeginContext(404, 11, false);
#line 14 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml"
       Write(Model.RegNo);

#line default
#line hidden
            EndContext();
            BeginContext(415, 18, true);
            WriteLiteral("</h2>\r\n<h2>Email: ");
            EndContext();
            BeginContext(434, 11, false);
#line 15 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml"
      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(445, 20, true);
            WriteLiteral("</h2>\r\n<h2>Address: ");
            EndContext();
            BeginContext(466, 13, false);
#line 16 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml"
        Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(479, 23, true);
            WriteLiteral("</h2>\r\n<h2>Department: ");
            EndContext();
            BeginContext(503, 16, false);
#line 17 "D:\F-EDUCATIONAL\C#\Practice\AspDotNetAndEntity\Views\Student\Index.cshtml"
           Write(Model.Department);

#line default
#line hidden
            EndContext();
            BeginContext(519, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppDotNetCoreAndEntity.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591