#pragma checksum "C:\Users\Young Family\Desktop\CODE\FSDI 110\Day 2\Views\Representatives\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430ad44df3dbe511ceecb30d8230c4d15a085783"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Representatives_Create), @"mvc.1.0.view", @"/Views/Representatives/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Representatives/Create.cshtml", typeof(AspNetCore.Views_Representatives_Create))]
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
#line 1 "C:\Users\Young Family\Desktop\CODE\FSDI 110\Day 2\Views\_ViewImports.cshtml"
using Day_2;

#line default
#line hidden
#line 2 "C:\Users\Young Family\Desktop\CODE\FSDI 110\Day 2\Views\_ViewImports.cshtml"
using Day_2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430ad44df3dbe511ceecb30d8230c4d15a085783", @"/Views/Representatives/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07ce51cb5c4949d9cb25159ee3fa1e323ea0157a", @"/Views/_ViewImports.cshtml")]
    public class Views_Representatives_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1446, true);
            WriteLiteral(@"<link href=""https://fonts.googleapis.com/css?family=Open+Sans+Condensed:300&display=swap"" rel=""stylesheet"">

<link href=""/css/createrep.css"" rel=""stylesheet"">


<h1>Register new representatives</h1>

<div class=""row create-form"">
    
  <div class=""col-md-8 offset-3 form-container"">
    <div class=""form-group row"">
      <label for=""firstName"" class=""col-2 col-form-label"">First Name</label>
    <div class=""col-8"">
      <input type=""text"" class=""form-control"" id=""txtName"" name=""txtName"" placeholder=""First Name"">
    </div>
  </div>
  <div class=""form-group row"">
      <label for=""lastName"" class=""col-2 col-form-label"">Last Name</label>
    <div class=""col-8"">
      <input type=""text"" class=""form-control"" id=""txtlastName"" placeholder=""Last Name"">
  </div>
</div>
  <div class=""form-group row"">
      <label for=""Id"" class=""col-2 col-form-label"">ID:</label>
    <div class=""col-8"">
      <input type=""text"" class=""form-control"" id=""txtId"" placeholder=""ID"">
  </div>
</div>
  <div class=""f");
            WriteLiteral(@"orm-group row"">
    <label for=""phoneNumber"" class=""col-2 col-form-label"">Phone Number</label>
    <div class=""col-8"">
      <input type=""text"" class=""form-control"" id=""txtphoneNumber"" placeholder=""xxx-xxx-xxxx"">
  </div>
</div>
  </div>
</div>
  

<div>
    <button id=""btnSave"" class=""btn btn-success btn-sm"" name=""submit"" type=""button"">Register</button>
</div>

<script src=""/js/createreps.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591