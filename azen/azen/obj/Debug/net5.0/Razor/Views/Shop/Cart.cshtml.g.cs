#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\Shop\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e534d57ecd49a0de207c853aed2805ff6a85b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Cart), @"mvc.1.0.view", @"/Views/Shop/Cart.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code Academy\Teaching\Groupes\P222\Lessons\74.20.12.2021-Azen\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e534d57ecd49a0de207c853aed2805ff6a85b0", @"/Views/Shop/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce09aa79235bba9d3756fe18caadde6fc53ebdab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woocommerce-cart-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""site page-content"">

    <div class=""breadcrumb-contact-us breadcrumb-section section-box"">
        <div class=""container breadcrumb-inner"">
            <div class=""breadcrumbs-wrapper"">
                <ul class=""phys-breadcrumb"">
                    <li><a href=""index.html"" class=""home"">Home</a></li>
                    <li><a href=""shop.html"" class=""home"">Shop</a></li>
                    <li>Cart</li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""content-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""site-main col-sm-12 full-width"">

                    <div class=""entry-content"">
                        <div class=""woocommerce"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5e534d57ecd49a0de207c853aed2805ff6a85b05951", async() => {
                WriteLiteral(@"

                                <table class=""shop_table shop_table_responsive cart woocommerce-cart-form__contents"">
                                    <thead>
                                        <tr>
                                            <th class=""product-remove"">&nbsp;</th>
                                            <th class=""product-thumbnail"">&nbsp;</th>
                                            <th class=""product-name"">Product</th>
                                            <th class=""product-price"">Price</th>
                                            <th class=""product-quantity"">Quantity</th>
                                            <th class=""product-subtotal"">Subtotal</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr class=""woocommerce-cart-form__cart-item cart_item"">

                                            <td class=""prod");
                WriteLiteral(@"uct-remove"">
                                                <a href=""#"" class=""remove"">??</a>
                                            </td>

                                            <td class=""product-thumbnail"">
                                                <a href=""simple-product.html"">
                                                    <img src=""images/product/Hyper-shoe.jpg""
                                                         class=""attachment-woocommerce_thumbnail size-woocommerce_thumbnail""");
                BeginWriteAttribute("alt", "\r\n                                                         alt=\"", 2397, "\"", 2461, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                </a>
                                            </td>

                                            <td class=""product-name"" data-title=""Product"">
                                                <a href=""simple-product.html"">Hyper shoe</a>
                                            </td>

                                            <td class=""product-price"" data-title=""Price"">
                                                <span class=""woocommerce-Price-amount amount"">
                                                    <span class=""woocommerce-Price-currencySymbol"">$</span>100
                                                </span>
                                            </td>

                                            <td class=""product-quantity"" data-title=""Quantity"">
                                                <div class=""btn-group"">
                                                    <button type=""button"" class=""prev btn "">-</b");
                WriteLiteral(@"utton>
                                                    <button type=""button"" class=""show-number btn "">1</button>
                                                    <button type=""button"" class=""next btn "">+</button>
                                                </div>
                                            </td>

                                            <td class=""product-subtotal"" data-title=""Subtotal"">
                                                <span class=""woocommerce-Price-amount amount"">
                                                    <span class=""woocommerce-Price-currencySymbol"">$</span>100
                                                </span>
                                            </td>
                                        </tr>
                                        <tr class=""woocommerce-cart-form__cart-item cart_item"">

                                            <td class=""product-remove"">
                                                <a href=""#"" ");
                WriteLiteral(@"class=""remove"">??</a>
                                            </td>
                                            <td class=""product-thumbnail"">
                                                <a href=""simple-product.html"">
                                                    <img src=""images/product/sneaker5.jpg""
                                                         class=""attachment-woocommerce_thumbnail size-woocommerce_thumbnail""");
                BeginWriteAttribute("alt", "\r\n                                                         alt=\"", 4955, "\"", 5019, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                </a>
                                            </td>

                                            <td class=""product-name"" data-title=""Product"">
                                                <a href=""simple-product.html"">
                                                    Sneaker
                                                    v5
                                                </a>
                                            </td>

                                            <td class=""product-price"" data-title=""Price"">
                                                <span class=""woocommerce-Price-amount amount"">
                                                    <span class=""woocommerce-Price-currencySymbol"">$</span>70
                                                </span>
                                            </td>

                                            <td class=""product-quantity"" data-title=""Quantity"">
             ");
                WriteLiteral(@"                                   <div class=""btn-group"">
                                                    <button type=""button"" class=""prev btn "">-</button>
                                                    <button type=""button"" class=""show-number btn "">1</button>
                                                    <button type=""button"" class=""next btn "">+</button>
                                                </div>

                                            </td>

                                            <td class=""product-subtotal"" data-title=""Subtotal"">
                                                <span class=""woocommerce-Price-amount amount"">
                                                    <span class=""woocommerce-Price-currencySymbol"">$</span>70
                                                </span>
                                            </td>
                                        </tr>


                                        <tr>
                         ");
                WriteLiteral(@"                   <td colspan=""6"" class=""actions"">

                                                <div class=""coupon"">
                                                    <label for=""coupon_code"">Coupon:</label>
                                                    <input type=""text"" name=""coupon_code"" class=""input-text""
                                                           id=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 7472, "\"", 7480, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Coupon code"">
                                                    <button type=""submit"" class=""button"" name=""apply_coupon""
                                                            value=""Apply coupon"">
                                                        Apply coupon
                                                    </button>
                                                </div>

                                                <button type=""submit"" class=""button"" name=""update_cart""
                                                        value=""Update cart""");
                BeginWriteAttribute("disabled", " disabled=\"", 8074, "\"", 8085, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    Update cart
                                                </button>


                                                <input type=""hidden"" id=""woocommerce-cart-nonce""
                                                       name=""woocommerce-cart-nonce"" value=""4b591cdf2c""><input type=""hidden"" name=""_wp_http_referer"" value=""/cart/"">
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""cart-collaterals"">
                                <div class=""cart_totals "">
                                    <h2>Cart totals</h2>
                                    <table class=""shop_table shop_table_responsive"">
                                        <tbody>
                                            <tr class=""cart-subtotal"">
                                                <th>Subtotal</th>
                                                <td data-title=""Subtotal"">
                                                    <span class=""woocommerce-Price-amount amount"">
                                                        <span class=""woocommerce-Price-currencySymbol"">$</span>170
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr class=""order-total"">
                                         ");
            WriteLiteral(@"       <th>Total</th>
                                                <td data-title=""Total"">
                                                    <strong>
                                                        <span class=""woocommerce-Price-amount amount"">
                                                            <span class=""woocommerce-Price-currencySymbol"">$</span>170
                                                        </span>
                                                    </strong>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <div class=""wc-proceed-to-checkout"">
                                        <a href=""checkout.html""
                                           class=""checkout-button button alt wc-forward"">
                                            Proceed to checkout
                 ");
            WriteLiteral(@"                       </a>
                                    </div>


                                </div>
                            </div>
                        </div>
                    </div><!-- .entry-content -->
                </div>
            </div>
        </div>
    </div>
</div>");
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
