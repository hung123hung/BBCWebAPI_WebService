#pragma checksum "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\ProductsMVC\LoginSucess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee638b4b6445dbe393d61f3e79ef83a170b1dbfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductsMVC_LoginSucess), @"mvc.1.0.razor-page", @"/Views/ProductsMVC/LoginSucess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/ProductsMVC/LoginSucess.cshtml", typeof(AspNetCore.Views_ProductsMVC_LoginSucess), null)]
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
#line 2 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\ProductsMVC\LoginSucess.cshtml"
using BBCWebAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee638b4b6445dbe393d61f3e79ef83a170b1dbfb", @"/Views/ProductsMVC/LoginSucess.cshtml")]
    public class Views_ProductsMVC_LoginSucess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(60, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c9a084afea649dab1f9302928d18c3d", async() => {
                BeginContext(66, 30, true);
                WriteLiteral("\r\n    <title>Details</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(105, 361, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd9bcad99ed4e528b0c6907f4405a64", async() => {
                BeginContext(111, 135, true);
                WriteLiteral("\r\n    <h2>Product by NguyenVanHung</h2>\r\n    <table>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n        </tr>\r\n");
                EndContext();
#line 16 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\ProductsMVC\LoginSucess.cshtml"
         foreach (var product in ViewBag.listProduct)
        {   

#line default
#line hidden
                BeginContext(315, 39, true);
                WriteLiteral("            <tr>\r\n                <th> ");
                EndContext();
                BeginContext(355, 10, false);
#line 19 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\ProductsMVC\LoginSucess.cshtml"
                Write(product.ID);

#line default
#line hidden
                EndContext();
                BeginContext(365, 29, true);
                WriteLiteral(" </th>\r\n                <th> ");
                EndContext();
                BeginContext(395, 12, false);
#line 20 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\ProductsMVC\LoginSucess.cshtml"
                Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(407, 27, true);
                WriteLiteral(" </th>\r\n            </tr>\r\n");
                EndContext();
#line 22 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\ProductsMVC\LoginSucess.cshtml"
        }

#line default
#line hidden
                BeginContext(445, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(466, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_ProductsMVC_LoginSucess> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_ProductsMVC_LoginSucess> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_ProductsMVC_LoginSucess>)PageContext?.ViewData;
        public Views_ProductsMVC_LoginSucess Model => ViewData.Model;
    }
}
#pragma warning restore 1591