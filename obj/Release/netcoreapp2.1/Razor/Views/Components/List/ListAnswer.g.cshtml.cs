#pragma checksum "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5765ba7d7a7a4ae5c22aa375e6966ffbf7d5c288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_List_ListAnswer), @"mvc.1.0.view", @"/Views/Components/List/ListAnswer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/List/ListAnswer.cshtml", typeof(AspNetCore.Views_Components_List_ListAnswer))]
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
#line 1 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
using BBCWebAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5765ba7d7a7a4ae5c22aa375e6966ffbf7d5c288", @"/Views/Components/List/ListAnswer.cshtml")]
    public class Views_Components_List_ListAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/css/List.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/images/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/images/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(53, 553, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3476e6c4752b4495b93030bc8b5b69cd", async() => {
                BeginContext(59, 108, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    ");
                EndContext();
                BeginContext(167, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "200cd05d99b6434e9f77a834b18b8d26", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(223, 376, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
");
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
            BeginContext(606, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(610, 4377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1af8550cb14b9dbc1d4e929a45f6c1", async() => {
                BeginContext(616, 406, true);
                WriteLiteral(@"
    <div class=""w3-container"">
        <div class=""w3-responsive"">
            <table class=""w3-table-all"">
                <thead>
                    <tr>
                        <th>Content</th>
                        <th>Correct</th>
                        <th>Edit</th>
                        <th>Delete</th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 28 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
                     foreach (Answer answer in ViewBag.listAnswers)
                    {
                        var myModal = "myModal" + answer.AnswerID.Trim().ToString();

#line default
#line hidden
                BeginContext(1200, 79, true);
                WriteLiteral("                        <tr>\r\n                            <td class=\"ellipsis\">");
                EndContext();
                BeginContext(1280, 14, false);
#line 32 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
                                            Write(answer.Content);

#line default
#line hidden
                EndContext();
                BeginContext(1294, 56, true);
                WriteLiteral("</td>\r\n                            <td class=\"ellipsis\">");
                EndContext();
                BeginContext(1351, 14, false);
#line 33 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
                                            Write(answer.Correct);

#line default
#line hidden
                EndContext();
                BeginContext(1365, 76, true);
                WriteLiteral("</td>   \r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1441, 263, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5a97675888343b3884382720b00aca4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1455, "location.href=\'", 1455, 15, true);
#line 35 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
AddHtmlAttributeValue("", 1470, Url.Action("ToEditAnswerPage".Trim(),"Answer",new { answerID=answer.AnswerID.Trim(),questionID=ViewBag.questionID,contentQuestion=ViewBag.contentQuestion}), 1470, 156, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1626, "\'", 1626, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1704, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1807, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f2e883696b44c078731fe09eeb97c01", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                WriteLiteral("#");
#line 39 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
                                                                  Write(myModal);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-target", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1895, 107, true);
                WriteLiteral("\r\n\r\n                                <!-- Modal -->\r\n                                <div class=\"modal fade\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2002, "\"", 2015, 1);
#line 42 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
WriteAttributeValue("", 2007, myModal, 2007, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2016, 527, true);
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
                                    <div class=""modal-dialog"">
                                        <!-- Modal content-->
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h4 class=""modal-title"" style=""width:100%;text-align:center;"">
                                                    Are you sure you want to delete """);
                EndContext();
                BeginContext(2544, 14, false);
#line 48 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
                                                                                Write(answer.Content);

#line default
#line hidden
                EndContext();
                BeginContext(2558, 964, true);
                WriteLiteral(@"""?
                                                </h4>
                                            </div>
                                            <div class=""modal-body"">
                                                <div class=""btn-group"" style=""width:100%;"">
                                                    <button class=""btnPopup"" id=""btn_OK""
                                                            style=""margin: 20px;
                                                                    width: 100px;
                                                                    width: 100px;
                                                                    height: 50px;
                                                                    margin-left:50px;
                                                                    border: 1px solid white;
                                                                    border-radius: 4px;""");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                                            onclick=\"", 3522, "\"", 3683, 3);
                WriteAttributeValue("", 3593, "location.href=\'", 3593, 15, true);
#line 61 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
WriteAttributeValue("", 3608, Url.Action("DeleteAnswer","Answer",new {answerID=answer.AnswerID.Trim()}), 3608, 74, false);

#line default
#line hidden
                WriteAttributeValue("", 3682, "\'", 3682, 1, true);
                EndWriteAttribute();
                BeginContext(3684, 1195, true);
                WriteLiteral(@">
                                                        OK
                                                    </button>
                                                    <button data-dismiss=""modal""
                                                            class=""btnPopup""
                                                            style=""margin: 20px;
                                                            width: 100px;
                                                            width: 100px;
                                                            height: 50px;
                                                            border: 1px solid white;
                                                            border-radius: 4px;"">
                                                        Cancel
                                                    </button>
                                                </div>
                                            </div>
                           ");
                WriteLiteral("             </div>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 81 "D:\Xamarin\BBCWebAPI\BBCWebAPI\Views\Components\List\ListAnswer.cshtml"
                    }

#line default
#line hidden
                BeginContext(4902, 78, true);
                WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(4987, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
