#pragma checksum "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ce3e0cd19c4d2b288ed5071acd2083f56a80ad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieForm), @"mvc.1.0.view", @"/Views/Movies/MovieForm.cshtml")]
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
#line 1 "D:\Proiecte\movie-renting\Renter\Renter\Views\_ViewImports.cshtml"
using Renter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proiecte\movie-renting\Renter\Renter\Views\_ViewImports.cshtml"
using Renter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce3e0cd19c4d2b288ed5071acd2083f56a80ad6", @"/Views/Movies/MovieForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e6d1b9a32ed5b3b2c49089f073fc910a5e3b6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_MovieForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Renter.ViewModels.MovieFormViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 9 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
 using (Html.BeginForm("Save", "Movies"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 12 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 17 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.ReleaseDate, "{0:d MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 22 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.DropDownListFor(m => m.Movie.GenreId, new SelectList(Model.Genres, "Id", "Name"), "", new {@class = "form-select"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        ");
#nullable restore
#line 24 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  \r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 28 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.NumberInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.NumberInStock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 30 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.NumberInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
Write(Html.HiddenFor(m => m.Movie.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary mt-4\">Save</button>\r\n");
#nullable restore
#line 35 "D:\Proiecte\movie-renting\Renter\Renter\Views\Movies\MovieForm.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Renter.ViewModels.MovieFormViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591