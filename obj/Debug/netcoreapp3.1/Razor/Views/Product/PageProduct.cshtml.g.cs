#pragma checksum "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43499bcd916d757ad51ba74476e228c445f0a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_PageProduct), @"mvc.1.0.view", @"/Views/Product/PageProduct.cshtml")]
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
#line 1 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\_ViewImports.cshtml"
using TheBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\_ViewImports.cshtml"
using TheBookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\_ViewImports.cshtml"
using TheBookStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\_ViewImports.cshtml"
using TheBookStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43499bcd916d757ad51ba74476e228c445f0a42", @"/Views/Product/PageProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a426f5a72d0a19bb49bda2ec635e24f94f009a7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_PageProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("review-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section"">
		<!-- container -->
		<div class=""container"">
			<!-- row -->
			<div class=""row"">
				<!--  Product Details -->
				<div class=""product product-details clearfix"">
					<div class=""col-md-6"">
						<div id=""product-main-view"">
							<div class=""product-view"">
								<img");
            BeginWriteAttribute("src", " src=\"", 324, "\"", 342, 1);
#nullable restore
#line 13 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
WriteAttributeValue("", 330, Model.Image, 330, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 343, "\"", 349, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t<div class=\"product-body\">\r\n\t\t\t\t\t\t\t<h2 class=\"product-name\">");
#nullable restore
#line 19 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t\t\t\t<h3 class=\"product-price\">");
#nullable restore
#line 20 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - грн</h3>
							<div>
								<div class=""product-rating"">
									<i class=""fa fa-star""></i>
									<i class=""fa fa-star""></i>
									<i class=""fa fa-star""></i>
									<i class=""fa fa-star""></i>
									<i class=""fa fa-star-o empty""></i>
								</div>
								<a href=""#"">3 Коментария</a>
							</div>
							<p><strong>Жанр:</strong> ");
#nullable restore
#line 31 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                                 Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<p><strong>Автор:</strong>");
#nullable restore
#line 32 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                                 Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<p><strong>Язык:</strong> ");
#nullable restore
#line 33 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                                 Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 34 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<div class=\"product-options\">\r\n\t\t\t\t\t\t\t\t<ul class=\"size-option\">\r\n\t\t\t\t\t\t\t\t\t<li><span class=\"text-uppercase\">Размер:</span></li>\r\n\t\t\t\t\t\t\t\t\t<li>");
#nullable restore
#line 38 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                   Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<ul class=\"color-option\">\r\n\t\t\t\t\t\t\t\t\t<li><span class=\"text-uppercase\">Количество страниц:</span></li>\r\n\t\t\t\t\t\t\t\t\t<li>");
#nullable restore
#line 42 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                   Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t<div class=\"product-btns\">\r\n\t\t\t\t\t\t\t\t<div class=\"qty-input\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"text-uppercase\">Количество: </span>\r\n\t\t\t\t\t\t\t\t\t<input class=\"input\" type=\"number\">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43499bcd916d757ad51ba74476e228c445f0a429753", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a43499bcd916d757ad51ba74476e228c445f0a4210029", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 52 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1819, "\"", 1874, 1);
#nullable restore
#line 53 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
WriteAttributeValue("", 1827, ViewContext.HttpContext.Request.PathAndQuery(), 1827, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"primary-btn add-to-cart\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-shopping-cart\"></i> \r\n\t\t\t\t\t\t\t\t\t\tДобавить в корзину\r\n\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
AddHtmlAttributeValue("", 1640, Model.ProductId, 1640, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								<div class=""pull-right"">
									<button class=""main-btn icon-btn""><i class=""fa fa-heart""></i></button>
									<button class=""main-btn icon-btn""><i class=""fa fa-exchange""></i></button>
									<button class=""main-btn icon-btn""><i class=""fa fa-share-alt""></i></button>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-md-12"">
						<div class=""product-tab"">
							<ul class=""tab-nav"">
								<li class=""active""><a data-toggle=""tab"" href=""#tab1"">Описание</a></li>
								<li><a data-toggle=""tab"" href=""#tab1"">Подробнее</a></li>
								<li><a data-toggle=""tab"" href=""#tab2"">Коментарии (3)</a></li>
							</ul>
							<div class=""tab-content"">
								<div id=""tab1"" class=""tab-pane fade in active"">
									<p>");
#nullable restore
#line 76 "D:\C#Projects\VStudio\BookStore\TheBookStore\TheBookStore\Views\Product\PageProduct.cshtml"
                                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
								</div>
								<div id=""tab2"" class=""tab-pane fade in"">

									<div class=""row"">
										<div class=""col-md-6"">
											<div class=""product-reviews"">
												<div class=""single-review"">
													<div class=""review-heading"">
														<div><a href=""#""><i class=""fa fa-user-o""></i> John</a></div>
														<div><a href=""#""><i class=""fa fa-clock-o""></i> 27 DEC 2017 / 8:0 PM</a></div>
														<div class=""review-rating pull-right"">
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star-o empty""></i>
														</div>
													</div>
													<div class=""review-body"">
														<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea com");
            WriteLiteral(@"modo consequat.Duis aute
															irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
													</div>
												</div>

												<div class=""single-review"">
													<div class=""review-heading"">
														<div><a href=""#""><i class=""fa fa-user-o""></i> John</a></div>
														<div><a href=""#""><i class=""fa fa-clock-o""></i> 27 DEC 2017 / 8:0 PM</a></div>
														<div class=""review-rating pull-right"">
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star-o empty""></i>
														</div>
													</div>
													<div class=""review-body"">
														<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea");
            WriteLiteral(@" commodo consequat.Duis aute
															irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
													</div>
												</div>

												<div class=""single-review"">
													<div class=""review-heading"">
														<div><a href=""#""><i class=""fa fa-user-o""></i> John</a></div>
														<div><a href=""#""><i class=""fa fa-clock-o""></i> 27 DEC 2017 / 8:0 PM</a></div>
														<div class=""review-rating pull-right"">
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star""></i>
															<i class=""fa fa-star-o empty""></i>
														</div>
													</div>
													<div class=""review-body"">
														<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip e");
            WriteLiteral(@"x ea commodo consequat.Duis aute
															irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
													</div>
												</div>

												<ul class=""reviews-pages"">
													<li class=""active"">1</li>
													<li><a href=""#"">2</a></li>
													<li><a href=""#"">3</a></li>
													<li><a href=""#""><i class=""fa fa-caret-right""></i></a></li>
												</ul>
											</div>
										</div>
										<div class=""col-md-6"">
											<h4 class=""text-uppercase"">Write Your Review</h4>
											<p>Your email address will not be published.</p>
											");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43499bcd916d757ad51ba74476e228c445f0a4219508", async() => {
                WriteLiteral(@"
												<div class=""form-group"">
													<input class=""input"" type=""text"" placeholder=""Your Name"" />
												</div>
												<div class=""form-group"">
													<input class=""input"" type=""email"" placeholder=""Email Address"" />
												</div>
												<div class=""form-group"">
													<textarea class=""input"" placeholder=""Your review""></textarea>
												</div>
												<div class=""form-group"">
													<div class=""input-rating"">
														<strong class=""text-uppercase"">Your Rating: </strong>
														<div class=""stars"">
															<input type=""radio"" id=""star5"" name=""rating"" value=""5"" /><label for=""star5""></label>
															<input type=""radio"" id=""star4"" name=""rating"" value=""4"" /><label for=""star4""></label>
															<input type=""radio"" id=""star3"" name=""rating"" value=""3"" /><label for=""star3""></label>
															<input type=""radio"" id=""star2"" name=""rating"" value=""2"" /><label for=""star2""></label>
															<input type=""radi");
                WriteLiteral("o\" id=\"star1\" name=\"rating\" value=\"1\" /><label for=\"star1\"></label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<button class=\"primary-btn\">Submit</button>\r\n\t\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t\t<!-- /Product Details -->\r\n\t\t\t</div>\r\n\t\t\t<!-- /row -->\r\n\t\t</div>\r\n\t\t<!-- /container -->\r\n\t</div>\r\n\t<!-- /section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591