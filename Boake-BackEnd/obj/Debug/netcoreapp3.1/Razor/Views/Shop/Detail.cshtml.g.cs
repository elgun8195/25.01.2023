#pragma checksum "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80784131f4dd3574ff9159123c261b6d1895282a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Detail), @"mvc.1.0.view", @"/Views/Shop/Detail.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80784131f4dd3574ff9159123c261b6d1895282a", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fd6bb7c7335018762291f9a99db59597b2b892", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("  text-decoration-none text-white work-sans hover2 t-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--====== Breadcrumb-Area Start ======-->\r\n\r\n<section class=\"breadcrumb-area py-5 py-sm-0\">\r\n    <div class=\" bg-shade text-center py-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80784131f4dd3574ff9159123c261b6d1895282a5517", async() => {
                WriteLiteral("HOME ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span class=\" text-white \">/</span>\r\n        <span class=\" text-white work-sans\"> ");
#nullable restore
#line 13 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    </div>
</section>

<!--====== Breadcrumb-Area End ======-->
<!--====== Detail-Area Start ======-->
<section class=""my-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""border position-relative"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80784131f4dd3574ff9159123c261b6d1895282a7671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 797, "~/assets/img/feature-collection/", 797, 32, true);
#nullable restore
#line 24 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 829, Model.ImageUrl, 829, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <!-- <a data-toggle=""modal"" href=""#myModal"" class=""text-decoration-none text-white bg-fusion hover4 t-5 px-4 py-3 position-absolute bottom-0 start-0"">
                        <i class=""fas fa-play""></i>
                        <span>View Video</span>
                    </a> -->
                </div>
            </div>
            <div class=""col-lg-6 details col-12 pt-5 pt-sm-0"">
                <h2 class=""title text-white geometric ls-1"">");
#nullable restore
#line 32 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <span class=\"price d-block pb-3\">\r\n                    <span class=\"money text-fusion work-sans fw-bold fs-3\">$");
#nullable restore
#line 34 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                             if (Model.CampaignId==null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                       Write(Model.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                        
                        }else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                        Write(Model.Price * (100 - Model.Campaign.DiscountPercent) / 100);

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                         
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span>\r\n                </span>\r\n                <span class=\"text-white d-block pb-3 fs-6 work-sans \">\r\n                    SKU: <span>");
#nullable restore
#line 43 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                          Write(Model.ImageUrl.Substring(5,7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </span>\r\n\r\n\r\n                <span class=\"text-white d-block pb-3 fs-6 work-sans \">\r\n                    Availability: <span>");
#nullable restore
#line 48 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                   Write(Model.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" left in stock</span>\r\n                </span>\r\n                <p class=\"description text-white\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <ul class=\"list-unstyled text-white\">\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 2326, "\"", 2334, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <span class=\"label\">Book Name:</span>\r\n                        <span class=\"desc\">");
#nullable restore
#line 56 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </li>\r\n                    <li>\r\n                        <span class=\"label\">Author Name</span>\r\n                        <span class=\"desc\">\r\n");
#nullable restore
#line 61 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                             foreach (var item in Model.AuthorBooks)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2761, "\"", 2768, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white hover2 t-5\" title=\"Vendor 11\">");
#nullable restore
#line 63 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                                           Write(item.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 64 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\r\n                    </li>\r\n                    <li>\r\n                        <span class=\"label\">Product Type</span>\r\n                        <span class=\"desc\">\r\n");
#nullable restore
#line 70 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                             foreach (var item in Model.BookTypes)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 3222, "\"", 3229, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white hover2 t-5\" title=\"Type 11\">");
#nullable restore
#line 72 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                                         Write(item.ProductType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 73 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\r\n                    </li>\r\n                    <li>\r\n                        <span class=\"label\">Item Publish Date</span>\r\n                        <span class=\"desc\">");
#nullable restore
#line 79 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                      Write(Model.CreatedTime.ToString("yyyy/ MM/ dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </li>
                </ul>


                <div class=""pro-details-quality py-4"">
                    <div class=""quickview-plus-minus d-flex align-items-center pt-4"">
                        <div class=""cart-plus-minus border py-3 d-flex justify-content-around align-items-center w-80"">
                            <div class=""minus text-white fw-bold"" style=""cursor: pointer;"">-</div>
                            <input type=""text"" id=""ival"" value=""1""  name=""quantity"" class=""bg-transparent border-0 w-24 text-white"" style=""outline: none;"">
                            <div class=""plus text-white fw-bold"" style=""cursor: pointer;"">+</div>
                        </div>
                        <div class=""quickview-btn-cart ps-4"">
                            <button class=""bg-grey2 input-border tocart text-uppercase text-white work-sans px-5 py-3 hover3 t-5 "" style=""outline: none;"">Add to Cart</button>
                        </div>
                    </div>
          ");
            WriteLiteral("          <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4655, "\"", 4672, 1);
#nullable restore
#line 95 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 4663, Model.Id, 4663, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"bookid\">\r\n                </div>\r\n                <div class=\"pro-details-meta pt-4 text-white\">\r\n                    <span class=\"me-2 work-sans\">Categories:</span>\r\n");
#nullable restore
#line 99 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                     foreach (var item in Model.BookCategories)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 4954, "\"", 4961, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white hover2 work-sans t-5\">");
#nullable restore
#line 101 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                       Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 102 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                       
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"pro-details-meta pt-4 text-white\">\r\n                    <span class=\"me-2 work-sans\">Tags:</span>\r\n");
#nullable restore
#line 107 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                     foreach (var item in Model.BookTags)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 5357, "\"", 5390, 2);
            WriteAttributeValue("", 5364, "/blog/blogtag/", 5364, 14, true);
#nullable restore
#line 110 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 5378, item.Tag.Id, 5378, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white hover2 work-sans t-5\">");
#nullable restore
#line 110 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                                                     Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 111 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!-- Share -->
                <div class=""share-icons text-white  py-4"">
                    <span class=""me-2 work-sans"">Share:</span>
                    <a href=""https://www.facebook.com/"" class=""text-decoration-none bg-facebook ps-2 br-5 pe-1 text-black"" target=""_blank"">
                        <i class=""fa-brands fa-facebook-f ""></i>
                    </a>
                    <a href=""https://www.twitter.com/"" class=""ms-2 text-decoration-none bg-twitter ps-1 br-5  text-black"" target=""_blank"">
                        <i class=""fa-brands fa-twitter""></i>
                    </a>
                    <a href=""https://www.pinterest.com/"" class=""ms-2 text-decoration-none bg-pinterest ps-2 br-5 pe-1 text-black"" target=""_blank"">
                        <i class=""fa-brands fa-pinterest-p""></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
</section>
<!--====== Detail-Area End ======-->
<!--====== Related Pr");
            WriteLiteral(@"oducts Start ======-->
<div class=""py-5"">
    <div class=""container"">
        <div class=""text-center py-5"">
            <h2 class=""text-white work-sans"">Related Products</h2>
            <p class=""text-white work-sans"">Contrary to popular belief, Lorem Ipsum is not simply random.</p>
        </div>

        <div");
            BeginWriteAttribute("class", " class=\"", 6842, "\"", 6850, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"container position-relative olo1\">\r\n                <div class=\"row featured-collections-slider\">\r\n");
#nullable restore
#line 142 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                     foreach (var item in ViewBag.RelatedBooks)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 7093, "\"", 7101, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"input-border me-4 position-relative \">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7219, "\"", 7247, 2);
            WriteAttributeValue("", 7226, "/shop/detail/", 7226, 13, true);
#nullable restore
#line 146 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 7239, item.Id, 7239, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80784131f4dd3574ff9159123c261b6d1895282a24499", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7297, "~/assets/img/feature-collection/", 7297, 32, true);
#nullable restore
#line 147 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 7329, item.ImageUrl, 7329, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n                                <h4 class=\"title fs-6 fs-sm-12 fs-sm-12 ls-1\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7524, "\"", 7552, 2);
            WriteAttributeValue("", 7531, "/shop/detail/", 7531, 13, true);
#nullable restore
#line 150 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
WriteAttributeValue("", 7544, item.Id, 7544, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white  ps-3 work-sans hover2 t-5 geometric\">");
#nullable restore
#line 150 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h4>\r\n                                <span class=\"discounted-price\">\r\n");
#nullable restore
#line 153 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                     if (item.CampaignId != null)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"money text-decoration-line-through ps-3  text-white\">$");
#nullable restore
#line 156 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 157 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n\r\n                                <span class=\"price\">\r\n");
#nullable restore
#line 161 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                     if (item.CampaignId != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"money text-fusion ps-3 fw-bold fs-4\">$");
#nullable restore
#line 163 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                       Write(item.Price * (100 - item.Campaign.DiscountPercent) / 100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 164 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"money text-fusion ps-3 fw-bold fs-4\">$");
#nullable restore
#line 168 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 169 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </span>
                                <span class=""stars ps-3 pt-2 pb-3 d-block"">
                                    <i class=""fa-regular fa-star text-yellow""></i>
                                    <i class=""fa-regular fa-star text-yellow""></i>
                                    <i class=""fa-regular fa-star text-yellow""></i>
                                    <i class=""fa-regular fa-star text-yellow""></i>
                                    <i class=""fa-regular fa-star text-yellow""></i>
                                </span>
                                <div class=""ht-product-action "">
                                    <ul class=""list-unstyled d-flex align-items-center justify-content-center pt-3"">
                                        <li class="" "">
                                            <a href=""#"" class=""text-decoration-none hover2 t-5 text-white"" data-modal>
                                                <i class=""fas fa-search fs-4"" style=""");
            WriteLiteral(@"cursor: pointer;""></i>
                                            </a>
                                        </li>
                                        <li class=""ps-4 "">
                                            <a class=""text-decoration-none hover2 t-5 text-white"">
                                                <i class=""las la-shopping-bag fs-4"" style=""cursor: pointer;""></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div> 
");
#nullable restore
#line 193 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                 if (item.CampaignId != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"sale\">\r\n                                        <span class=\"bg-fusion px-3  text-white d-flex justify-content-center align-items-center mt-sm-3 mt-2 fs-sm-12 work-sans br-50\">-");
#nullable restore
#line 196 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                                                                                                                                                    Write(item.Campaign.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                    </div>\r\n");
#nullable restore
#line 198 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 201 "C:\Users\hp\Desktop\ONLY GITHUB PROJECTS !!!\HHHHHHHHHHHHHHH\Panel-For-Boake\Boake-BackEnd\Views\Shop\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""prev-collection hover3 t-5 pa-col "">
                    <i class=""fa-solid fa-chevron-left  work-sans"" style=""cursor: pointer;""></i>
                </div>
                <div class=""next-collection hover3 t-5  pa1-col"">
                    <i class=""fa-solid fa-chevron-right work-sans"" style=""cursor: pointer;""></i>
                </div>
            </div>
        </div>
    </div>
</div>
<!--====== Related Products End ======-->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.3/jquery.min.js""></script>

<script>
    $(document).on(""click"", "".tocart"", function (e) {
        var inputString = $(""#ival"");
        var elmId = $(""#bookid"");
        var base = window.location.origin;
        var url = `${base}/basket/add/${$(elmId).val()}?count=${$(inputString).val()} `
        window.location.replace(url)

    })
    $('.minus').click(function () {
        var $input = $(this).parent().find('input');
        var count = ");
            WriteLiteral(@"parseInt($input.val()) - 1;
        count = count < 1 ? 1 : count;
        $input.val(count);
        $input.change();
        return false;
    });
    $('.plus').click(function () {
        var $input = $(this).parent().find('input');
        $input.val(parseInt($input.val()) + 1);
        $input.change();
        return false;
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
