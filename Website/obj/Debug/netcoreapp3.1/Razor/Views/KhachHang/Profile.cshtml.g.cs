#pragma checksum "D:\tmdt\Website - Copy - Copy\Website\Views\KhachHang\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f3d198cc74504a656a79cbb15128f30924b5dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_Profile), @"mvc.1.0.view", @"/Views/KhachHang/Profile.cshtml")]
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
#line 1 "D:\tmdt\Website - Copy - Copy\Website\Views\_ViewImports.cshtml"
using Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tmdt\Website - Copy - Copy\Website\Views\_ViewImports.cshtml"
using Website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\tmdt\Website - Copy - Copy\Website\Views\KhachHang\Profile.cshtml"
using Website.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f3d198cc74504a656a79cbb15128f30924b5dd", @"/Views/KhachHang/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Website.Data.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KhachHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\tmdt\Website - Copy - Copy\Website\Views\KhachHang\Profile.cshtml"
   ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_ShopLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-container col2-right-layout"">
    <div class=""main container"">
        <div class=""row"">
            <div class=""col-main col-sm-9 col-xs-12"">
                <div class=""my-account"">
                    <div class=""page-title"">
                        <h2>Thông tin tài khoản</h2>
                    </div>
                    <div class=""dashboard"">

                        <div class=""recent-orders"">
                            <div class=""title-buttons""><strong>Recent Orders</strong>  </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f3d198cc74504a656a79cbb15128f30924b5dd4803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("       \n                <table>\n                    <tr>\n                        <td class=\"title-m\">Họ và tên</td>\n                        <td>");
#nullable restore
#line 22 "D:\tmdt\Website - Copy - Copy\Website\Views\KhachHang\Profile.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>$100</td>
                    </tr>
                    <tr>
                        <td class=""title-m"">Số điện thoại</td>
                        <td></td>
                        <td>$150</td>
                    </tr>
                    <tr>
                        <td class=""title-m"">Email</td>
                        <td></td>
                        <td>$300</td>
                    </tr>
                    <tr>
                        <td class=""title-m"">Địa chỉ</td>
                        <td></td>
                        <td>$250</td>
                    </tr>
                </table>
                        </div>
                        <!--<div class=""box-account"">
                            <div class=""page-title"">
                                <h2>Account Information</h2>
                            </div>
                            <div class=""col2-set"">
                                <div class=""col-1"">
                                    <h6>Contact ");
            WriteLiteral(@"Information</h6>
                                    <a href=""#"">Edit</a>
                                    <p>
                                        jones don<br>
                                        jonesd15@gmail.com<br>
                                        <a href=""#"">Change Password</a>
                                    </p>
                                </div>
                                <div class=""col-2"">
                                    <h5>Newsletters</h5>
                                    <a href=""#"">Edit</a>
                                    <p> You are currently not subscribed to any newsletter. </p>
                                </div>
                            </div>
                            <div class=""col2-set"">
                                <h5>Address Book</h5>
                                <div class=""manage_add""><a href=""#"">Manage Addresses</a> </div>
                                <div class=""col-1"">
                                    <h5>Primary Bil");
            WriteLiteral(@"ling Address</h5>
                                    <address>
                                        jones d<br>
                                        Hawaii<br>
                                        Britain,  North America, 65432<br>
                                        United States<br>
                                        T: 123456 <br>
                                        <a href=""#"">Edit Address</a>
                                    </address>
                                </div>
                                <div class=""col-2"">
                                    <h5>Primary Shipping Address</h5>
                                    <address>
                                        jones d<br>
                                        Hawaii<br>
                                        Britain,  North America, 65432<br>
                                        United States<br>
                                        T: 123456 <br>
                                        <a href=""#"">Edi");
            WriteLiteral(@"t Address</a>
                                    </address>
                                </div>
                            </div>
                        </div>-->
                    </div>
                </div>
            </div>
            <aside class=""right sidebar col-sm-3 col-xs-12"">
                <div class=""sidebar-account block"">
                    <div class=""sidebar-bar-title"">
                        <h3>My Account</h3>
                    </div>
                    <div class=""block-content"">
                        <ul>
                            <li class=""current""><a>Account Dashboard</a></li>
                            <li><a href=""#"">Account Information</a></li>
                            <li><a href=""#"">Address Book</a></li>
                            <li><a href=""#"">My Orders</a></li>
                            <li><a href=""#"">Billing Agreements</a></li>
                            <li><a href=""#"">Recurring Profiles</a></li>
                            <li><a href=""#"">My Pr");
            WriteLiteral(@"oduct Reviews</a></li>
                            <li><a href=""#"">My Tags</a></li>
                            <li><a href=""#"">My Wishlist</a></li>
                            <li><a href=""#"">My Downloadable</a></li>
                            <li class=""last""><a href=""#"">Newsletter Subscriptions</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""compare block"">
                    <div class=""sidebar-bar-title"">
                        <h3>Compare Products (2)</h3>
                    </div>
                    <div class=""block-content"">
                        <ol id=""compare-items"">
                            <li class=""item""> <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name"">Vestibulum porta tristique porttitor.</a> </li>
                            <li class=""item""> <a href=""#"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" c");
            WriteLiteral(@"lass=""product-name"">Lorem ipsum dolor sit amet</a> </li>
                        </ol>
                        <div class=""ajax-checkout"">
                            <button type=""submit"" title=""Submit"" class=""button button-compare""> <span>Compare</span></button>
                            <button type=""submit"" title=""Submit"" class=""button button-clear""> <span>Clear All</span></button>
                        </div>
                    </div>
                </div>
            </aside>
        </div>
    </div>
</section>

<style>
    table {
        border-collapse: collapse;
        width: 100%;
    }

    .title-m {
        font-weight: bold;
    }

    th, td {
        padding: 8px;
        text-align: left;
        border-bottom: 1px solid #ddd;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Website.Data.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591