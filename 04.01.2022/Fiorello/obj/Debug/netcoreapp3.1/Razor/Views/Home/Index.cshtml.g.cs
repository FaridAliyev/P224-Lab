#pragma checksum "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba3d4341361725ee4bc7a88b014c5f58965ebddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\faridra\source\repos\Fiorello\Views\_ViewImports.cshtml"
using Fiorello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\faridra\source\repos\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\faridra\source\repos\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3d4341361725ee4bc7a88b014c5f58965ebddc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de50368d54413322f609f2896d5958eb3422f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Fiorello";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"slider\">\r\n    <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 9 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
         foreach (SliderImage item in Model.SliderImages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div> <img");
            BeginWriteAttribute("src", " src=\"", 217, "\"", 238, 2);
            WriteAttributeValue("", 223, "img/", 223, 4, true);
#nullable restore
#line 11 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 227, item.Image, 227, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 239, "\"", 245, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 12 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"container context pl-lg-5 ml-lg-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"text\">\r\n                    <h1>");
#nullable restore
#line 19 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.SliderText.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-black-50 d-none d-sm-block\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                   Write(Model.SliderText.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 726, "\"", 759, 2);
            WriteAttributeValue("", 732, "img/", 732, 4, true);
#nullable restore
#line 25 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 736, Model.SliderText.Image, 736, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 760, "\"", 766, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""products"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-12 d-flex justify-content-between"">
                <ul class=""category-mobile d-md-none list-unstyled"">
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1129, "\"", 1136, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                        <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1355, "\"", 1362, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 42 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                             foreach (Category item in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1535, "\"", 1542, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 44 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                   Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 44 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 45 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1804, "\"", 1811, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                     foreach (Category item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 1967, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 53 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                           Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 53 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 54 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2163, "\"", 2170, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                        <i class=\"fas fa-caret-down\"></i>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 65 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
             foreach (Product item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n                    <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 68 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                              Write(item.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"img\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2675, "\"", 2682, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2722, "\"", 2743, 2);
            WriteAttributeValue("", 2728, "img/", 2728, 4, true);
#nullable restore
#line 71 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 2732, item.Image, 2732, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 2762, "\"", 2768, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"title mt-3\">\r\n                            <h6>");
#nullable restore
#line 75 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"price\">\r\n                            <span class=\"text-black-50\">Add to cart</span>\r\n                            <span class=\"text-black-50\">$");
#nullable restore
#line 79 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 83 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"about\">\r\n    <div class=\"container py-5\">\r\n        <div class=\"row py-5\">\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3495, "\"", 3523, 2);
            WriteAttributeValue("", 3501, "img/", 3501, 4, true);
#nullable restore
#line 95 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 3505, Model.About.Video, 3505, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3542, "\"", 3548, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                        <i class=""fas fa-play fa-lg""></i>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                    <h1>");
#nullable restore
#line 103 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.About.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"py-3\">\r\n                        ");
#nullable restore
#line 105 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                   Write(Model.About.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 108 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                         foreach (AboutFeature item in Model.AboutFeatures)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 4356, "\"", 4362, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 111 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                                                  Write(item.Feature);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 113 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

<section id=""experts"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>Flower Experts</h1>
                    <p class=""text-black-50"">
                        A perfect blend of creativity, energy, communication, happiness and
                        love. Let us arrange
                        a smile for you.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row pb-5"">
");
#nullable restore
#line 136 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
             foreach (Expert item in Model.Experts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"item text-center\">\r\n                        <div class=\"img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5368, "\"", 5389, 2);
            WriteAttributeValue("", 5374, "img/", 5374, 4, true);
#nullable restore
#line 141 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 5378, item.Image, 5378, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 5423, "\"", 5429, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"text mt-3\">\r\n                            <h6>");
#nullable restore
#line 144 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 144 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p class=\"text-black-50\">");
#nullable restore
#line 145 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                Write(item.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 149 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<section id=""blog"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>From our Blog</h1>
                    <p class=""text-black-50"">
                        A perfect blend of creativity, energy, communication, happiness and
                        love. Let us arrange
                        a smile for you.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row pb-5"">
");
#nullable restore
#line 169 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
             foreach (Blog item in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba3d4341361725ee4bc7a88b014c5f58965ebddc20238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6613, "~/img/", 6613, 6, true);
#nullable restore
#line 174 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6619, item.Image, 6619, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                <span>");
#nullable restore
#line 176 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                 Write(item.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text mt-3 text-center px-5\">\r\n                            <h5>");
#nullable restore
#line 180 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 182 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 187 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"say\">\r\n    <div class=\"container\">\r\n        <div class=\"row py-5 justify-content-center\">\r\n            <div class=\"col-md-8 col-xl-6\">\r\n                <div class=\"owl-carousel say\">\r\n");
#nullable restore
#line 197 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                     foreach (Testimonial testimonial in Model.Testimonials)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 7807, "\"", 7842, 2);
            WriteAttributeValue("", 7813, "img/", 7813, 4, true);
#nullable restore
#line 202 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
WriteAttributeValue("", 7817, testimonial.Expert.Image, 7817, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7843, "\"", 7849, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"text text-muted pt-3 pb-5\">\r\n                                    <i>");
#nullable restore
#line 205 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                  Write(testimonial.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                </div>\r\n                                <div class=\"author\">\r\n                                    <h6>");
#nullable restore
#line 208 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                   Write(testimonial.Expert.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 208 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                            Write(testimonial.Expert.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
#nullable restore
#line 209 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                                                        Write(testimonial.Expert.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 213 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"instagram\">\r\n    <div class=\"owl-carousel instagram\">\r\n\r\n");
#nullable restore
#line 223 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
         foreach (InstaPhoto item in Model.InstaPhotos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba3d4341361725ee4bc7a88b014c5f58965ebddc26778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8703, "~/img/", 8703, 6, true);
#nullable restore
#line 225 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8709, item.Image, 8709, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 226 "C:\Users\faridra\source\repos\Fiorello\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n        #FIORELLO\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
