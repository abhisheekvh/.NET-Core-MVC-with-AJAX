#pragma checksum "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c31217ac938c57a85097eede8d66d7fc5781b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacton__ViewAll), @"mvc.1.0.view", @"/Views/Transacton/_ViewAll.cshtml")]
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
#line 1 "/home/abhishek/JqueryAjax/Views/_ViewImports.cshtml"
using JqueryAjax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/abhishek/JqueryAjax/Views/_ViewImports.cshtml"
using JqueryAjax.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c31217ac938c57a85097eede8d66d7fc5781b6e", @"/Views/Transacton/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511156b64afa3d0c76ca9994633b0d5559833f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacton__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JqueryAjax.Models.TransactionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return JqueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 7 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.accountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 10 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.BenificiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 13 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n           \n            <th>\n                ");
#nullable restore
#line 17 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th><a");
            BeginWriteAttribute("onclick", " onclick=\"", 527, "\"", 635, 4);
            WriteAttributeValue("", 537, "showInPopup(\'", 537, 13, true);
#nullable restore
#line 19 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
WriteAttributeValue("", 550, Url.Action("AddOrEdit","Transacton",null,Context.Request.Scheme), 550, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 615, "\',\'New", 615, 6, true);
            WriteAttributeValue(" ", 621, "Transaction\')", 622, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Transaction</a></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 23 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 26 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.accountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 29 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.BenificiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 32 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n         \n            <td>\n                ");
#nullable restore
#line 36 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1245, "\"", 1376, 4);
            WriteAttributeValue("", 1255, "showInPopup(\'", 1255, 13, true);
#nullable restore
#line 39 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
WriteAttributeValue("", 1268, Url.Action("AddOrEdit","Transacton",new {id=item.transactionId},Context.Request.Scheme), 1268, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1356, "\',\'New", 1356, 6, true);
            WriteAttributeValue(" ", 1362, "Transaction\')", 1363, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> Update </a>\n              \n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c31217ac938c57a85097eede8d66d7fc5781b6e8277", async() => {
                WriteLiteral("\n                  <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\">\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
                                          WriteLiteral(item.transactionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 46 "/home/abhishek/JqueryAjax/Views/Transacton/_ViewAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JqueryAjax.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
