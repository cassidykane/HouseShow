#pragma checksum "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e6db54d820edfaa9b6abd4df053e99959133fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Show_DisplayVenues), @"mvc.1.0.view", @"/Views/Show/DisplayVenues.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Show/DisplayVenues.cshtml", typeof(AspNetCore.Views_Show_DisplayVenues))]
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
#line 1 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\_ViewImports.cshtml"
using HouseShow;

#line default
#line hidden
#line 2 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\_ViewImports.cshtml"
using HouseShow.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e6db54d820edfaa9b6abd4df053e99959133fb", @"/Views/Show/DisplayVenues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4f05d79fcee9dd039806ff6c40c3a4c95dc601", @"/Views/_ViewImports.cshtml")]
    public class Views_Show_DisplayVenues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Venue>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayVenue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
  
	ViewData["Title"] = "Venues";

#line default
#line hidden
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb8d810759ce4599b2dd1fb49ea0be8c", async() => {
                BeginContext(81, 161, true);
                WriteLiteral("\r\n\t<label name=\"city\">City:</label>\r\n\t<input name=\"city\" /><br />\r\n\t<label name=\"state\">State:</label>\r\n\t<input name=\"state\" /><br />\r\n\t<input type=\"submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(249, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 14 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
 if (Model != null)
{
	

#line default
#line hidden
#line 16 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
     foreach (Venue v in Model)
	{

#line default
#line hidden
            BeginContext(311, 5, true);
            WriteLiteral("\t\t<p>");
            EndContext();
            BeginContext(316, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d45340b582b1493db25c96c25d8d3a15", async() => {
                BeginContext(372, 6, false);
#line 18 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
                                                             Write(v.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-venue", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
                                             WriteLiteral(v.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["venue"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-venue", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["venue"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(382, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
	}

#line default
#line hidden
#line 19 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\DisplayVenues.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Venue>> Html { get; private set; }
    }
}
#pragma warning restore 1591
