#pragma checksum "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f569cba9eebdc7f7de5ee543b7013094ba66b452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AbsenceRequest_Details), @"mvc.1.0.view", @"/Views/AbsenceRequest/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f569cba9eebdc7f7de5ee543b7013094ba66b452", @"/Views/AbsenceRequest/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2935d94a2eaa8d2f9a4ebab9520cd55f97adbe", @"/Views/_ViewImports.cshtml")]
    public class Views_AbsenceRequest_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AbsenceManager.Models.AbsenceRequestViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
 if (Model.Approved == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        <h4 class=\"alert-heading\">Pending Approval</h4>\r\n        <p>\r\n            <strong>");
#nullable restore
#line 76 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingStudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>  ");
#nullable restore
#line 76 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                                   Write(Model.RequestingStudent.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 76 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                                                                      Write(Model.RequestingStudent.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'s Leave Request <br />\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
#nullable restore
#line 80 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 80 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 83 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
}
else if (Model.Approved == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        <h4 class=\"alert-heading\">Approved by ");
#nullable restore
#line 87 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                         Write(Model.ApprovedBy.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n        <p>\r\n            <strong>");
#nullable restore
#line 89 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingStudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 89 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                                  Write(Model.RequestingStudent.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 89 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                                                                     Write(Model.RequestingStudent.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br />\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
#nullable restore
#line 93 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 93 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 96 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <h4 class=\"alert-heading\">Rejected by ");
#nullable restore
#line 100 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                         Write(Model.ApprovedBy.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 100 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                    Write(Model.ApprovedBy.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>\r\n            <strong>");
#nullable restore
#line 102 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingStudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 102 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                                  Write(Model.RequestingStudent.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 102 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                                                                     Write(Model.RequestingStudent.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
#nullable restore
#line 106 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 106 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.RequestDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 115 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 118 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 121 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 124 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 127 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AbsenceType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 130 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
       Write(Html.DisplayFor(model => model.AbsenceType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 135 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
     if (Model.Approved == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f569cba9eebdc7f7de5ee543b7013094ba66b45215844", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-check\"></i> Approve\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f569cba9eebdc7f7de5ee543b7013094ba66b45218208", async() => {
                WriteLiteral("\r\n            <i class=\"fa fa-remove\"></i> Reject\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
                                                               WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\Users\Administrateur\Desktop\osa\Asp.net-core-Absence-Manager\AbsenceManager\Views\AbsenceRequest\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f569cba9eebdc7f7de5ee543b7013094ba66b45220806", async() => {
                WriteLiteral("\r\n        <i class=\"fa fa-arrow-left\"></i> Back to List\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AbsenceManager.Models.AbsenceRequestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
