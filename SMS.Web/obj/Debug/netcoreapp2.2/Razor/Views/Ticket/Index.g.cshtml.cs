#pragma checksum "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b6141e0c4a56f2d7c7a683753b10d312a5e9fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Index.cshtml", typeof(AspNetCore.Views_Ticket_Index))]
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
#line 1 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\_ViewImports.cshtml"
using SMS.Web;

#line default
#line hidden
#line 2 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\_ViewImports.cshtml"
using SMS.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\_ViewImports.cshtml"
using SMS.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b6141e0c4a56f2d7c7a683753b10d312a5e9fe", @"/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa2b49b31d8f20cfdb977b0c89a4c231924fd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Close", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 112, true);
            WriteLiteral("\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            EndContext();
            BeginContext(134, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43b6141e0c4a56f2d7c7a683753b10d312a5e9fe5319", async() => {
                BeginContext(178, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 168, true);
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">\r\n            Tickets\r\n        </li>\r\n    </ol>\r\n</nav>\r\n\r\n<h3>Open Ticket List</h3>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(386, 36, true);
            WriteLiteral("    <div class=\"mt-4 mb-4\">\r\n       ");
            EndContext();
            BeginContext(422, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43b6141e0c4a56f2d7c7a683753b10d312a5e9fe7382", async() => {
                BeginContext(476, 13, true);
                WriteLiteral("Create Ticket");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(493, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
}

#line default
#line hidden
            BeginContext(510, 227, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n      <tr>\r\n         <th>Id</th>\r\n         <th>Student</th>\r\n         <th>Issue</th>\r\n         <th>Created</th>           \r\n         <th>Actions</th>\r\n      </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
       foreach(var t in Model) {

#line default
#line hidden
            BeginContext(771, 32, true);
            WriteLiteral("          <tr>\r\n            <td>");
            EndContext();
            BeginContext(804, 4, false);
#line 35 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
           Write(t.Id);

#line default
#line hidden
            EndContext();
            BeginContext(808, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(832, 14, false);
#line 36 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
           Write(t.Student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(846, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(870, 7, false);
#line 37 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
           Write(t.Issue);

#line default
#line hidden
            EndContext();
            BeginContext(877, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(901, 11, false);
#line 38 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
           Write(t.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(912, 39, true);
            WriteLiteral("</td>              \r\n            <td>\r\n");
            EndContext();
#line 40 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
                 if (User.IsInRole("Admin") || User.IsInRole("Manager"))
                {

#line default
#line hidden
            BeginContext(1043, 19, true);
            WriteLiteral("                   ");
            EndContext();
            BeginContext(1062, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43b6141e0c4a56f2d7c7a683753b10d312a5e9fe11406", async() => {
                BeginContext(1087, 53, true);
                WriteLiteral("\r\n                     <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1140, "", 1152, 1);
#line 43 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 1147, t.Id, 1147, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1152, 104, true);
                WriteLiteral(" />\r\n                     <input type=\"submit\" value=\"Close\" class=\"btn btn-link\"/>\r\n                   ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1263, 44, true);
            WriteLiteral("                                          \r\n");
            EndContext();
#line 46 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1326, 35, true);
            WriteLiteral("            </td>\r\n         </tr>\r\n");
            EndContext();
#line 49 "C:\Users\shidu\Documents\Practical11-SMS2-Template\SMS.Web\Views\Ticket\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(1370, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
