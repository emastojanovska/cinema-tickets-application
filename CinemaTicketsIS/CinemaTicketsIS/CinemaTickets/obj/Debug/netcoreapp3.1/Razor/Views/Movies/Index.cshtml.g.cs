#pragma checksum "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba24470474c60062fbbdb005c0566431658b78d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\_ViewImports.cshtml"
using CinemaTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\_ViewImports.cshtml"
using CinemaTickets.Domain.DomainModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba24470474c60062fbbdb005c0566431658b78d2", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d90b8772edd40683c0c6737ba7dc88f7386c94c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CinemaTickets.Domain.DomainModels.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-block btn-danger mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {
        var item = Model[i];

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row ml-3\">\r\n");
#nullable restore
#line 21 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
            }



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card text-white bg-dark\" style=\"width: 18rem; height: 30rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 803, "\"", 823, 1);
#nullable restore
#line 26 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 809, item.ImageUrl, 809, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 55%\" alt=\"Image for movie\" />\r\n\r\n                    <div class=\"card-body\">\r\n                        <label class=\"card-title\"><b>");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                                Write(item.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> - (");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                                                       Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</label>\r\n                        <br />\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                         for (int j = 0; j < item.Rating; j++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""orange"" class=""bi bi-star"" viewBox=""0 0 16 16"">
                                <path d=""M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.522-3.356c.33-.314.16-.888-.282-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.83 4.73zm4.905-2.767-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288L8 2.223l1.847 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.565.565 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z"" />
                            </svg>
");
#nullable restore
#line 37 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"card-footer\">\r\n");
#nullable restore
#line 41 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                             foreach (var u in Context.Users)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                 if (UserManager.GetUserId(User) == u.Id && u.Role == CinemaTickets.Domain.DomainModels.Enumerations.Role.ADMIN)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba24470474c60062fbbdb005c0566431658b78d29956", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba24470474c60062fbbdb005c0566431658b78d212486", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                 


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba24470474c60062fbbdb005c0566431658b78d215501", async() => {
                WriteLiteral("SEE MORE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 60 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"



            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\CinemaTicketsIS\CinemaTicketsIS\CinemaTickets\Views\Movies\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CinemaTickets.Repository.ApplicationDbContext Context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CinemaTickets.Domain.Identity.CinemaApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CinemaTickets.Domain.Identity.CinemaApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CinemaTickets.Domain.DomainModels.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
