#pragma checksum "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7f1af1528464ea51577cd2c8bd74968558fe3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MoviesController1_Index), @"mvc.1.0.view", @"/Views/MoviesController1/Index.cshtml")]
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
#line 1 "D:\Projects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7f1af1528464ea51577cd2c8bd74968558fe3e", @"/Views/MoviesController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7981eff67e1d9c0c09483ec8e732626ed5f4d965", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MoviesController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Creat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
  
    ViewData["Title"] = "Movis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <h2>\r\n    <i class=\"bi bi-film\"></i>\r\n    Movies\r\n </h2>\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7f1af1528464ea51577cd2c8bd74968558fe3e5532", async() => {
                WriteLiteral("\r\n    <i class=\"bi bi-plus-circle-dotted\"></i> Add Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class = \"mt-4\">\r\n");
#nullable restore
#line 17 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"alert alert-warning\" role=\"alert\">\r\n           <i class=\"bi bi-exclamation-lg\"></i>\r\n           No Movies Found!\r\n        </div>\r\n");
#nullable restore
#line 23 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class = \"row\">\r\n");
#nullable restore
#line 27 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class = \"col-12\">\r\n                    <div class=\"card mb-3\">\r\n                        <div class=\"row no-gutters\">\r\n                          <div class=\"col-md-2 poster\"");
            BeginWriteAttribute("style", " style= \"", 759, "\"", 851, 4);
            WriteAttributeValue("", 768, "background-image:", 768, 17, true);
            WriteAttributeValue(" ", 785, "url(data:image\\/*;base64,", 786, 26, true);
#nullable restore
#line 32 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
WriteAttributeValue("", 811, Convert.ToBase64String(movie.Poster), 811, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 850, ")", 850, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                          <div class=\"col-md-10\">\r\n                            <div class=\"card-body d-flex flex-column justify-content-between h-100\">\r\n                            <div>\r\n                              <h5 class=\"card-title\">");
#nullable restore
#line 36 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 36 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                              Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                              <p class=\"card-text text-justify\">");
#nullable restore
#line 37 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                            Write(movie.StoreLine.Length > 500? $"{movie.StoreLine.Substring(0, 500)}..." :movie.StoreLine);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                            </div>  
                             <div class= ""d-flex justify-content-between"">
                                  <p class=""card-text mb-0 mt-2"">
                                  <i class = ""bi bi-star-fill text-warning""></i>
                                  <small class=""text-muted"">");
#nullable restore
#line 42 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                       Write(movie.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                  </p>\r\n                                  <div>\r\n                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7f1af1528464ea51577cd2c8bd74968558fe3e10411", async() => {
                WriteLiteral("\r\n                                          <i class = \"bi bi-camera-reels\"></i>\r\n                                          Details\r\n                                          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                                  WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7f1af1528464ea51577cd2c8bd74968558fe3e12874", async() => {
                WriteLiteral("\r\n                                          <i class = \"bi bi-pencil\"></i>\r\n                                          Edit\r\n                                          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                                   WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                          <a href=\"javascript:;\" class= \"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 53 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
                                                                                                       Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                          <i class = ""bi bi-trash""></i>
                                          Delete
                                          </a>
                                  </div>
                             </div>
                            </div>
                          </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 64 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 66 "D:\Projects\Movies\Movies\Views\MoviesController1\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
               $(document).ready(function () {
                    $('.js-delete').on('click', function () {
                        var btn = $(this);
                                    
                        bootbox.confirm({
                        message: ""You have delete this movie?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        
                    if (result) {
                        $.ajax({
                            url: '/movies/delete/' + btn.data('id'),
                            success: function () {
                                var movieContainer = bt");
                WriteLiteral(@"n.parents('.col-12');
                                movieContainer.addClass('animate__animated animate__zoomOut');

                                setTimeout(function () {
                                    movieContainer.remove();
                                }, 1000);

                                toastr.success('Movies deleted');
                            },
                            error:function () {
                                toastr.error('Somthing went wrong!');
                            }
                    });
                   }
                 }
               });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
