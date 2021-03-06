#pragma checksum "C:\Users\FX505GT\Desktop\ASP.NET\OneHealth\OneHealth\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e775aef0783cec685e6442a3b3f32c70ae5169e"
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
#line 1 "C:\Users\FX505GT\Desktop\ASP.NET\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\ASP.NET\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e775aef0783cec685e6442a3b3f32c70ae5169e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1693003578dd1016abdcd6ff5082a4d8fcec5828", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "general", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "cardiology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "dental", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "neurology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "orthopaedics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FX505GT\Desktop\ASP.NET\OneHealth\OneHealth\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""bg-light"">
    <div class=""page-section py-3 mt-md-n5 custom-index"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-4 py-3 py-md-0"">
                    <div class=""card-service wow fadeInUp"">
                        <div class=""circle-shape bg-secondary text-white"">
                            <span class=""mai-chatbubbles-outline""></span>
                        </div>
                        <p><span>Chat</span> with a doctors</p>
                    </div>
                </div>
                <div class=""col-md-4 py-3 py-md-0"">
                    <div class=""card-service wow fadeInUp"">
                        <div class=""circle-shape bg-primary text-white"">
                            <span class=""mai-shield-checkmark""></span>
                        </div>
                        <p><span>One</span>-Health Protection</p>
                    </div>
                </div>
                <div clas");
            WriteLiteral(@"s=""col-md-4 py-3 py-md-0"">
                    <div class=""card-service wow fadeInUp"">
                        <div class=""circle-shape bg-accent text-white"">
                            <span class=""mai-basket""></span>
                        </div>
                        <p><span>One</span>-Health Pharmacy</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- .page-section -->

    <div class=""page-section pb-0"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-6 py-3 wow fadeInUp"">
                    <h1>
                        Welcome to Your Health <br />
                        Center
                    </h1>
                    <p class=""text-grey mb-4"">
                        Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed
                        diam nonumy eirmod tempor invidunt ut labore et dolore magna
                        aliquyam er");
            WriteLiteral(@"at, sed diam voluptua. At vero eos et accusam et
                        justo duo dolores et ea rebum. Accusantium aperiam earum ipsa
                        eius, inventore nemo labore eaque porro consequatur ex
                        aspernatur. Explicabo, excepturi accusantium! Placeat voluptates
                        esse ut optio facilis!
                    </p>
                    <a href=""about.html"" class=""btn btn-primary"">Learn More</a>
                </div>
                <div class=""col-lg-6 wow fadeInRight"" data-wow-delay=""400ms"">
                    <div class=""img-place custom-img-1"">
                        <img src=""../assets/img/bg-doctor.png""");
            BeginWriteAttribute("alt", " alt=\"", 2778, "\"", 2784, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- .bg-light -->
</div>
<!-- .bg-light -->

<div class=""page-section"">
    <div class=""container"">
        <h1 class=""text-center mb-5 wow fadeInUp"">Our Doctors</h1>

        <div class=""owl-carousel wow fadeInUp"" id=""doctorSlideshow"">
            <div class=""item"">
                <div class=""card-doctor"">
                    <div class=""header"">
                        <img src=""../assets/img/doctors/doctor_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3327, "\"", 3333, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""meta"">
                            <a href=""#""><span class=""mai-call""></span></a>
                            <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                        </div>
                    </div>
                    <div class=""body"">
                        <p class=""text-xl mb-0"">Dr. Stein Albert</p>
                        <span class=""text-sm text-grey"">Cardiology</span>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""card-doctor"">
                    <div class=""header"">
                        <img src=""../assets/img/doctors/doctor_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4047, "\"", 4053, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""meta"">
                            <a href=""#""><span class=""mai-call""></span></a>
                            <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                        </div>
                    </div>
                    <div class=""body"">
                        <p class=""text-xl mb-0"">Dr. Alexa Melvin</p>
                        <span class=""text-sm text-grey"">Dental</span>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""card-doctor"">
                    <div class=""header"">
                        <img src=""../assets/img/doctors/doctor_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4763, "\"", 4769, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""meta"">
                            <a href=""#""><span class=""mai-call""></span></a>
                            <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                        </div>
                    </div>
                    <div class=""body"">
                        <p class=""text-xl mb-0"">Dr. Rebecca Steffany</p>
                        <span class=""text-sm text-grey"">General Health</span>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""card-doctor"">
                    <div class=""header"">
                        <img src=""../assets/img/doctors/doctor_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5491, "\"", 5497, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""meta"">
                            <a href=""#""><span class=""mai-call""></span></a>
                            <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                        </div>
                    </div>
                    <div class=""body"">
                        <p class=""text-xl mb-0"">Dr. Rebecca Steffany</p>
                        <span class=""text-sm text-grey"">General Health</span>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""card-doctor"">
                    <div class=""header"">
                        <img src=""../assets/img/doctors/doctor_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6219, "\"", 6225, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""meta"">
                            <a href=""#""><span class=""mai-call""></span></a>
                            <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                        </div>
                    </div>
                    <div class=""body"">
                        <p class=""text-xl mb-0"">Dr. Rebecca Steffany</p>
                        <span class=""text-sm text-grey"">General Health</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""page-section bg-light"">
    <div class=""container"">
        <h1 class=""text-center wow fadeInUp"">Latest News</h1>
        <div class=""row mt-5"">
            <div class=""col-lg-4 py-2 wow zoomIn"">
                <div class=""card-blog"">
                    <div class=""header"">
                        <div class=""post-category"">
                            <a href=""#"">Covid19</a>
                        </div>
                 ");
            WriteLiteral("       <a href=\"blog-details.html\" class=\"post-thumb\">\r\n                            <img src=\"../assets/img/blog/blog_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7374, "\"", 7380, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </a>
                    </div>
                    <div class=""body"">
                        <h5 class=""post-title"">
                            <a href=""blog-details.html"">List of Countries without Coronavirus case</a>
                        </h5>
                        <div class=""site-info"">
                            <div class=""avatar mr-2"">
                                <div class=""avatar-img"">
                                    <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7910, "\"", 7916, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                                <span>Roger Adams</span>
                            </div>
                            <span class=""mai-time""></span> 1 week ago
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 py-2 wow zoomIn"">
                <div class=""card-blog"">
                    <div class=""header"">
                        <div class=""post-category"">
                            <a href=""#"">Covid19</a>
                        </div>
                        <a href=""blog-details.html"" class=""post-thumb"">
                            <img src=""../assets/img/blog/blog_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8645, "\"", 8651, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </a>
                    </div>
                    <div class=""body"">
                        <h5 class=""post-title"">
                            <a href=""blog-details.html"">Recovery Room: News beyond the pandemic</a>
                        </h5>
                        <div class=""site-info"">
                            <div class=""avatar mr-2"">
                                <div class=""avatar-img"">
                                    <img src=""../assets/img/person/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9178, "\"", 9184, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                                <span>Roger Adams</span>
                            </div>
                            <span class=""mai-time""></span> 4 weeks ago
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 py-2 wow zoomIn"">
                <div class=""card-blog"">
                    <div class=""header"">
                        <div class=""post-category"">
                            <a href=""#"">Covid19</a>
                        </div>
                        <a href=""blog-details.html"" class=""post-thumb"">
                            <img src=""../assets/img/blog/blog_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9914, "\"", 9920, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </a>
                    </div>
                    <div class=""body"">
                        <h5 class=""post-title"">
                            <a href=""blog-details.html"">What is the impact of eating too much sugar?</a>
                        </h5>
                        <div class=""site-info"">
                            <div class=""avatar mr-2"">
                                <div class=""avatar-img"">
                                    <img src=""../assets/img/person/person_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10452, "\"", 10458, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                                <span>Diego Simmons</span>
                            </div>
                            <span class=""mai-time""></span> 2 months ago
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-12 text-center mt-4 wow zoomIn"">
                <a href=""blog.html"" class=""btn btn-primary"">Read More</a>
            </div>
        </div>
    </div>
</div>
<!-- .page-section -->

<div class=""page-section"">
    <div class=""container"">
        <h1 class=""text-center wow fadeInUp"">Make an Appointment</h1>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e775aef0783cec685e6442a3b3f32c70ae5169e18451", async() => {
                WriteLiteral(@"
            <div class=""row mt-5"">
                <div class=""col-12 col-sm-6 py-2 wow fadeInLeft"">
                    <input type=""text"" class=""form-control"" placeholder=""Full name"" />
                </div>
                <div class=""col-12 col-sm-6 py-2 wow fadeInRight"">
                    <input type=""text""
                           class=""form-control""
                           placeholder=""Email address.."" />
                </div>
                <div class=""col-12 col-sm-6 py-2 wow fadeInLeft""
                     data-wow-delay=""300ms"">
                    <input type=""date"" class=""form-control"" />
                </div>
                <div class=""col-12 col-sm-6 py-2 wow fadeInRight""
                     data-wow-delay=""300ms"">
                    <select name=""departement"" id=""departement"" class=""custom-select"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e775aef0783cec685e6442a3b3f32c70ae5169e19627", async() => {
                    WriteLiteral("General Health");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e775aef0783cec685e6442a3b3f32c70ae5169e20883", async() => {
                    WriteLiteral("Cardiology");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e775aef0783cec685e6442a3b3f32c70ae5169e22135", async() => {
                    WriteLiteral("Dental");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e775aef0783cec685e6442a3b3f32c70ae5169e23383", async() => {
                    WriteLiteral("Neurology");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e775aef0783cec685e6442a3b3f32c70ae5169e24634", async() => {
                    WriteLiteral("Orthopaedics");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-12 py-2 wow fadeInUp"" data-wow-delay=""300ms"">
                    <input type=""text"" class=""form-control"" placeholder=""Number.."" />
                </div>
                <div class=""col-12 py-2 wow fadeInUp"" data-wow-delay=""300ms"">
                    <textarea name=""message""
                              id=""message""
                              class=""form-control""
                              rows=""6""
                              placeholder=""Enter message..""></textarea>
                </div>
            </div>

            <button type=""submit"" class=""btn btn-primary mt-3 wow zoomIn"">
                Submit Request
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
