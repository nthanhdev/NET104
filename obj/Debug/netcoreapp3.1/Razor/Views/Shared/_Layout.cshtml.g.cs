#pragma checksum "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e6109a35386cf96ba43839cf7e355bd7b7d393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\_ViewImports.cshtml"
using ASMMAIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\_ViewImports.cshtml"
using ASMMAIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e6109a35386cf96ba43839cf7e355bd7b7d393", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6026e44d3c177711fb395dba6086084292801d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e6109a35386cf96ba43839cf7e355bd7b7d3933234", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Shop Lego</title>
    <!-- reset css -->
    
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css""
        integrity=""sha512-NhSC1YmyruXifcj/KFRWoC561YpHpc5Jtzgvbuzx5VozKpWvQ+4nXhPdFgmx8xqexRcpAglTj9sIBWINXa8x5w==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css""
        integrity=""sha512-Fo3rlrZj/k7ujTnHg4CGR2D7kSs0v4LLanw2qksYuRlEzO+tcaEPQogQ0KaoGN26/zrn20ImR1DfuLWnOo7aBA==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""/css/base.css"" />
    <link rel=""stylesheet"" href=""/css/main.css"" />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9e6109a35386cf96ba43839cf7e355bd7b7d3935163", async() => {
                WriteLiteral(@"
    <div class=""main"">
        <!-- header -->
        <header class=""header"">
            <div class=""header_wrap"">
                <div class=""header_logo"">
                    <img src=""/images/LEGO.png"" alt=""logo"" class=""header_logo-img"" />
                    <h1 class=""header_logo-title"">LEGO PRO</h1>
                </div>
                <div class=""header_nav"">
                    <ul class=""header_nav-list"">
                        <li class=""header_nav-list-item"">
                            <a href=""/"">Trang chủ</a>
                        </li>
                        <li class=""header_nav-list-item"">
                            <a href=""#"">Danh mục</a>
                        </li>
                        <li class=""header_nav-list-item"">
                            <a href=""#""> Liên hệ</a>
                        </li>
                    </ul>
                </div>
                <div class=""header_search"">
                    <input class=""header_search-input"" type=""");
                WriteLiteral(@"text"" placeholder=""Nhập sản phẩm bạn muốn tìm"" />
                    <i class=""fa fa-search header_search-icon""></i>
                </div>

                <div class=""header_groupuser"">
                    <div class=""header_cart"">
                        <button class=""header_cart-wrap"">
                            <i class=""header_cart-icon fa fa-shopping-cart"">
                            </i>
                            <div class=""box-carts"">
                                <div class=""carts-header"">
                                    <div class=""carts-header_title"">Sản phẩm đã thêm</div>
                                    <div class=""carts-header_count"">3</div>
                                </div>
                                <div class=""carts-body"">
                                    <ul class=""products"">
                                        <li class=""product-item"">
                                            <div class=""product_img"" style=""
                            ");
                WriteLiteral(@"background: url('https://product.hstatic.net/1000295686/product/92c58511-96e6-4209-b37a-c7a1a895d302_c0f01cafac7e42b5ac6e9ba65b3a0052_small.jpg')
                              center center / contain no-repeat;"">
                                            </div>
                                            <div class=""product-body_info"">
                                                <div class=""product-body_info-title"">
                                                    xin chào tất cả các bạn mình tên là thành nhaaaxin chào tất cả các
                                                    bạn mình tên là thành nhaaa
                                                </div>
                                                <div class=""product-body_info-wrap"">
                                                    <i class=""product-body_info-icon fas fa-dollar-sign""></i>
                                                    <span class=""product-body_info-label"">20.000 x
                                       ");
                WriteLiteral(@"             </span>
                                                    <span class=""product-body_info-qty"">3</span>

                                                </div>
                                            </div>
                                            <i class=""product-body_info-remove far fa-times-circle""></i>
                                        </li>

                                    </ul>
                                </div>
                                <div class=""carts_preview-total"">
                                    <span class=""carts_preview-total-label"">Tổng tiền: </span>
                                    <div class=""product-body_info-price"">
                                        <i class=""product-body_info-icon fas fa-dollar-sign""></i>
                                        <span class=""product-body_info-total"">20.000</span>
                                    </div>
                                </div>
                                <div class");
                WriteLiteral(@"=""carts_controls"">
                                    <a href=""#"" class=""carts_cart-preview btn btn--blue-dark"">Cập nhật</a>
                                    <a href=""#"" class=""carts_cart-pay btn btn--blue-light"">Thanh toán</a>
                                </div>
                            </div>
                        </button>
                    </div>
                    <div class=""header_notify"">
                        <i class=""header_cart-icon fa fa-bell""></i>
                    </div>
                </div>

                <div class=""header_user"">
                    ");
#nullable restore
#line 104 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\Shared\_Layout.cshtml"
               Write(await Html.PartialAsync("_LoginPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                </div>
                <!-- dang nhap dang ky -->
                <!-- <div class=""header_controls"">
                    <a href=""#"" class=""header_controls-reg"">Đăng ký</a>
                    <a href=""#"" class=""header_controls-reg"">Đăng nhập</a>
                </div> -->
            </div>
        </header>
        <!-- end header -->
        <!-- aside -->
        <div class=""main-body"">
            ");
#nullable restore
#line 117 "D:\Hoc Hanh\C#4\Project\ASM\Project\ASMMAIN\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        </div>
        <!-- end aside -->
        <!-- Footer  -->
        <footer class=""footer"">
            <div class=""grid"">
                <div class=""grid_row"">
                    <div class=""grid_column-2-5"">
                        <h3 class=""footer_heading"">Chăm sóc khách hàng</h3>
                        <ul class=""footer_list"">
                            <li class=""footer_item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 6698, "\"", 6705, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_item-link\">Trung tâm trợ giúp</a>\r\n                            </li>\r\n                            <li class=\"footer_item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 6879, "\"", 6886, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_item-link\">Lego Pro</a>\r\n                            </li>\r\n                            <li class=\"footer_item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 7050, "\"", 7057, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_item-link"">Hướng dẫn mua hàng</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid_column-2-5"">
                        <h3 class=""footer_heading"">Giới thiệu</h3>
                        <ul class=""footer_list"">
                            <li class=""footer_item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 7459, "\"", 7466, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_item-link\">Về BemmTeam</a>\r\n                            </li>\r\n                            <li class=\"footer_item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 7633, "\"", 7640, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_item-link\">Tuyển dụng</a>\r\n                            </li>\r\n                            <li class=\"footer_item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 7806, "\"", 7813, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_item-link"">Điều khoản</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid_column-2-5"">
                        <h3 class=""footer_heading"">Danh mục</h3>
                        <ul class=""footer_list"">
                            <li class=""footer_item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 8205, "\"", 8212, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_item-link\">Lego chính hãng</a>\r\n                            </li>\r\n                            <li class=\"footer_item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8383, "\"", 8390, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_item-link\">Lego Hot</a>\r\n                            </li>\r\n                            <li class=\"footer_item\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8554, "\"", 8561, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_item-link"">Lego 2022</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid_column-2-5"">
                        <h3 class=""footer_heading"">Theo dõi</h3>
                        <ul class=""footer_list"">
                            <li class=""footer_item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 8952, "\"", 8959, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_item-link"">
                                    <i class=""footer_item-icon fab fa-facebook""></i> Facebook
                                </a>
                            </li>
                            <li class=""footer_item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 9244, "\"", 9251, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_item-link"">
                                    <i class=""footer_item-icon fab fa-instagram""></i>Instagram
                                </a>
                            </li>
                            <li class=""footer_item"">
                                <a");
                BeginWriteAttribute("href", " href=\"", 9537, "\"", 9544, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_item-link"">
                                    <i class=""footer_item-icon fab fa-linkedin""></i> Linkedin
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""grid_column-2-5"">
                        <h3 class=""footer_heading"">Vào cửa hàng</h3>
                        <div class=""footer_download"">
                            <img src=""/images/qrcode.png"" alt=""QRCODE"" class=""footer_download-qr"" />
                            <div class=""footer_download-apps"">


                                <a");
                BeginWriteAttribute("href", " href=\"", 10180, "\"", 10187, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"footer_download-apps-link\">\r\n                                    <img src=\"/images/ggplay.png\" alt=\"ggplay\" class=\"footer_download-apps-img\" />\r\n                                </a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 10413, "\"", 10420, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""footer_download-apps-link"">
                                    <img src=""/images/appstore.png"" alt=""appstore"" class=""footer_download-apps-img"" />
                                </a>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <div class=""footer_bottom"">

                <div class=""gird_row"">
                    <p class=""footer_text"">Bản quyền thuộc về Nguyễn Thành</p>
                </div>
            </div>
        </footer>
        <!-- end footer -->
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
