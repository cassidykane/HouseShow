#pragma checksum "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "143ec18c0c3fd392208af07e52d259cb9abe7d02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Show_Index), @"mvc.1.0.view", @"/Views/Show/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Show/Index.cshtml", typeof(AspNetCore.Views_Show_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"143ec18c0c3fd392208af07e52d259cb9abe7d02", @"/Views/Show/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4f05d79fcee9dd039806ff6c40c3a4c95dc601", @"/Views/_ViewImports.cshtml")]
    public class Views_Show_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Show>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayShow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/show/addvenue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
  
	ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(56, 46, true);
            WriteLiteral("<h1>House Show</h1>\r\n<h3>Search Shows</h3>\r\n\r\n");
            EndContext();
            BeginContext(102, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b7cc7ecdae424ebe1637275ad6c1db", async() => {
                BeginContext(122, 161, true);
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
            BeginContext(290, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(292, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14063b3e9e6b4325b9b0a54daec62ea6", async() => {
                BeginContext(312, 82, true);
                WriteLiteral("\r\n\t<label name=\"artist\">Search by Artist</label>\r\n\t<input name=\"artist\" /><br />\r\n");
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
            BeginContext(401, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(403, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634929a6b1274367b35ef4524f966056", async() => {
                BeginContext(423, 79, true);
                WriteLiteral("\r\n\t<label name=\"venue\">Search by Venue</label>\r\n\t<input name=\"venue\" /><br />\r\n");
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
            BeginContext(509, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 24 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(543, 149, true);
            WriteLiteral("\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Artists</th>\r\n\t\t\t\t<th>Venue</th>\r\n\t\t\t\t<th>City/State</th>\r\n\t\t\t\t<th>Date</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 36 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
             foreach (Show show in Model)
			{

#line default
#line hidden
            BeginContext(732, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(750, 16, false);
#line 39 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.ArtistNames);

#line default
#line hidden
            EndContext();
            BeginContext(766, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(782, 15, false);
#line 40 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.Venue.Name);

#line default
#line hidden
            EndContext();
            BeginContext(797, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(813, 15, false);
#line 41 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.Venue.City);

#line default
#line hidden
            EndContext();
            BeginContext(828, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(831, 16, false);
#line 41 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                                 Write(show.Venue.State);

#line default
#line hidden
            EndContext();
            BeginContext(847, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(863, 9, false);
#line 42 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.Time);

#line default
#line hidden
            EndContext();
            BeginContext(872, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(887, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6e5d5b743624519a30dabf318387031", async() => {
                BeginContext(958, 9, true);
                WriteLiteral("more info");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-showID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                                                      WriteLiteral(show.ShowID.ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["showID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-showID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["showID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(971, 17, true);
            WriteLiteral("</th>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 45 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(994, 23, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
            EndContext();
#line 48 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1020, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1022, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc463c2188ad435ea8f016c2dc8d52c8", async() => {
                BeginContext(1048, 11, true);
                WriteLiteral("Post a Show");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1063, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Show>> Html { get; private set; }
    }
}
#pragma warning restore 1591