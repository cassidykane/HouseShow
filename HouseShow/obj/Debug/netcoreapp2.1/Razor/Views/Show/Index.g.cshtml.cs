#pragma checksum "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f3ff6d57e38f060d515aad038c761218bfb150"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f3ff6d57e38f060d515aad038c761218bfb150", @"/Views/Show/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4f05d79fcee9dd039806ff6c40c3a4c95dc601", @"/Views/_ViewImports.cshtml")]
    public class Views_Show_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Show>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayShow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/show/addshow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c60b95c5ad84309bd70115449b288c2", async() => {
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
            BeginContext(290, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 16 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(324, 56, true);
            WriteLiteral("\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Upcoming Shows in ");
            EndContext();
            BeginContext(381, 19, false);
#line 21 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                                 Write(Model[0].Venue.City);

#line default
#line hidden
            EndContext();
            BeginContext(400, 145, true);
            WriteLiteral("</th>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Artists</th>\r\n\t\t\t\t<th>Venue</th>\r\n\t\t\t\t<th>City/State</th>\r\n\t\t\t\t<th>Date</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 31 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
             foreach (Show show in Model)
			{

#line default
#line hidden
            BeginContext(585, 9, true);
            WriteLiteral("\t\t\t<tr>\r\n");
            EndContext();
#line 34 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                 if (show.ArtistNames.Length < 1)
				{

#line default
#line hidden
            BeginContext(640, 9, true);
            WriteLiteral("\t\t\t\t\t<th>");
            EndContext();
            BeginContext(650, 26, false);
#line 36 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                   Write(ViewBag.Names[show.ShowID]);

#line default
#line hidden
            EndContext();
            BeginContext(676, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 37 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(690, 4, true);
            WriteLiteral("\t\t\t\t");
            EndContext();
#line 38 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                 if (show.ArtistNames.Length > 1) 
				{

#line default
#line hidden
            BeginContext(737, 9, true);
            WriteLiteral("\t\t\t\t\t<th>");
            EndContext();
            BeginContext(747, 16, false);
#line 40 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                   Write(show.ArtistNames);

#line default
#line hidden
            EndContext();
            BeginContext(763, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 41 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(777, 8, true);
            WriteLiteral("\t\t\t\t<th>");
            EndContext();
            BeginContext(786, 15, false);
#line 42 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.Venue.Name);

#line default
#line hidden
            EndContext();
            BeginContext(801, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(817, 15, false);
#line 43 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.Venue.City);

#line default
#line hidden
            EndContext();
            BeginContext(832, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(835, 16, false);
#line 43 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
                                 Write(show.Venue.State);

#line default
#line hidden
            EndContext();
            BeginContext(851, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(867, 9, false);
#line 44 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
               Write(show.Time);

#line default
#line hidden
            EndContext();
            BeginContext(876, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
            EndContext();
            BeginContext(891, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1620fa40e2d4b2e9fb1f64459820109", async() => {
                BeginContext(962, 9, true);
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
#line 45 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
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
            BeginContext(975, 17, true);
            WriteLiteral("</th>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 47 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(998, 23, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
            EndContext();
#line 50 "C:\Users\sleeper\Desktop\CS 295N ASP.NET\repos\TermProject\HouseShow\HouseShow\Views\Show\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1024, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1026, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b595f134bdb4b4d8b9b1a9a3f8b517d", async() => {
                BeginContext(1051, 11, true);
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
            BeginContext(1066, 2, true);
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
