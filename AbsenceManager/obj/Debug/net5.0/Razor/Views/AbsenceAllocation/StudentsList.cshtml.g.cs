#pragma checksum "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0bcf6d57ecc3c682c271b3a19861cae4d080f1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AbsenceAllocation_StudentsList), @"mvc.1.0.view", @"/Views/AbsenceAllocation/StudentsList.cshtml")]
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
#line 1 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\_ViewImports.cshtml"
using AbsenceManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\_ViewImports.cshtml"
using AbsenceManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0bcf6d57ecc3c682c271b3a19861cae4d080f1a", @"/Views/AbsenceAllocation/StudentsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2935d94a2eaa8d2f9a4ebab9520cd55f97adbe", @"/Views/_ViewImports.cshtml")]
    public class Views_AbsenceAllocation_StudentsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AbsenceManager.Models.StudentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn badge-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
  
    ViewData["Title"] = "StudentsList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Students List</h1>


<div class=""card-body"">
    <div id=""example2_wrapper"" class=""dataTables_wrapper dt-bootstrap4 table-dark table-hover"">
        <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
            <div class=""col-sm-12"">
                <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" role=""grid"" aria-describedby=""example2_info"">
                    <thead>
                        <tr role=""row"">
                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"">  ");
#nullable restore
#line 17 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                                                                                                                                                                                                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"sorting\" tabindex=\"0\" aria-controls=\"example2\" rowspan=\"1\" colspan=\"1\" aria-label=\"Browser: activate to sort column ascending\">  ");
#nullable restore
#line 18 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                                                                                                                                                               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th class=\"sorting\" tabindex=\"0\" aria-controls=\"example2\" rowspan=\"1\" colspan=\"1\" aria-label=\"Platform(s): activate to sort column ascending\">  ");
#nullable restore
#line 19 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                                                                                                                                                                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr role=\"row\" class=\"odd\">\r\n                            <td class=\"dtr-control sorting_1\" tabindex=\"0\">  ");
#nullable restore
#line 26 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>  ");
#nullable restore
#line 27 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                             Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>  ");
#nullable restore
#line 28 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bcf6d57ecc3c682c271b3a19861cae4d080f1a8478", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-info\" aria-hidden=\"true\"></i>\r\n                                    Details\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceAllocation\StudentsList.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n");
            WriteLiteral(@"                </table>
            </div>
        </div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""example2_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""example2_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""example2_previous""><a href=""#"" aria-controls=""example2"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""example2"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2""");
            WriteLiteral(@" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""example2_next""><a href=""#"" aria-controls=""example2"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AbsenceManager.Models.StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
