#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d972bf2093ff9aef342800a6d95ec2c5b91d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Course_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Course/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Course/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Course_Index))]
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
#line 1 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d972bf2093ff9aef342800a6d95ec2c5b91d18", @"/Areas/Admin/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mr-2 create-book"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(69, 103, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n");
            EndContext();
#line 9 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(229, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(245, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61227587cd954d5bb0ee685c4c1d0673", async() => {
                BeginContext(309, 13, true);
                WriteLiteral("create Course");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(326, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(343, 97, true);
            WriteLiteral("            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Course Table</h4>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                 if (Model.Count() != 0)
                {

#line default
#line hidden
            BeginContext(501, 1803, true);
            WriteLiteral(@"                    <div class=""table-responsive pt-3"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>
                                        Image
                                    </th>
                                    <th>
                                        Title
                                    </th>
                                    <th>
                                        Startime
                                    </th>
                                    <th>
                                        Duration
                                    </th>
                                    <th>
                                        Class Durtaion
                                    </th>
                                    <th>
                                        Skill Level
                                    </th>
                 ");
            WriteLiteral(@"                   <th>
                                        Language
                                    </th>
                                    <th>
                                        Students Count
                                    </th>
                                    <th>
                                        Assesments
                                    </th>
                                    <th>
                                        Category
                                    </th>
                                    <th>
                                        Setting
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 58 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2401, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2533, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e35cc5817d6d4e77a71a19e29be8ba8f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2543, "~/img/course/", 2543, 13, true);
#line 62 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
AddHtmlAttributeValue("", 2556, item.Image, 2556, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2604, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2744, 10, false);
#line 65 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2754, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2894, 54, false);
#line 68 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.StartTime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2948, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3088, 13, false);
#line 71 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(3101, 145, true);
            WriteLiteral(" Month\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3247, 18, false);
#line 74 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(3265, 144, true);
            WriteLiteral(" Mins\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3410, 14, false);
#line 77 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.SkilLevel);

#line default
#line hidden
            EndContext();
            BeginContext(3424, 141, true);
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3566, 13, false);
#line 81 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3579, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3719, 18, false);
#line 84 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.StudentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(3737, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3877, 15, false);
#line 87 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                       Write(item.Assesments);

#line default
#line hidden
            EndContext();
            BeginContext(3892, 147, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <ul>\r\n\r\n");
            EndContext();
#line 92 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                                 foreach (var category in item.CourseCategories)
                                                {
                                                    if (category != null)
                                                    {

#line default
#line hidden
            BeginContext(4318, 84, true);
            WriteLiteral("                                                        <li style=\"list-style:none\">");
            EndContext();
            BeginContext(4403, 24, false);
#line 96 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                                                               Write(category?.Category?.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4427, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 97 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                                    }

                                                }

#line default
#line hidden
            BeginContext(4542, 190, true);
            WriteLiteral("\r\n                                            </ul>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4732, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be8e547369c49ab9faf6a217aa2ba98", async() => {
                BeginContext(4803, 140, true);
                WriteLiteral("\r\n                                                <i class=\"mdi mdi-account-card-details\"></i>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 104 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4947, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(4993, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4dbc05965944f7fae2d4c8ba32dcb8c", async() => {
                BeginContext(5064, 130, true);
                WriteLiteral("\r\n                                                <i class=\"mdi mdi-table-edit\"></i>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5198, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(5244, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5734ee54d41146f8acc0cf1fb48e2cb2", async() => {
                BeginContext(5314, 126, true);
                WriteLiteral("\r\n                                                <i class=\"mdi mdi-delete\"></i>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5444, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 115 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5571, 100, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
            EndContext();
#line 119 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Course\Index.cshtml"
                }
                else
                {
                    //<h4 class="card-title">Empty Table</h4>
                }

#line default
#line hidden
            BeginContext(5813, 62, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
