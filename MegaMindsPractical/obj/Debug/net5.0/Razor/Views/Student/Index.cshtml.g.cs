#pragma checksum "D:\Rinkesh Project\RinkeshFinalPractical3\MegaMindsPractical\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76444c709afc04cae7b171176d98a7927aa04c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "D:\Rinkesh Project\RinkeshFinalPractical3\MegaMindsPractical\Views\_ViewImports.cshtml"
using MegaMindsPractical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rinkesh Project\RinkeshFinalPractical3\MegaMindsPractical\Views\_ViewImports.cshtml"
using MegaMindsPractical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76444c709afc04cae7b171176d98a7927aa04c2", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c23228dd3eb7b622447387cd008c0bc71dbac2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddStudent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStudentAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#myModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("OpenAddPopup();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\"");
            BeginWriteAttribute("href", " href=\"", 40, "\"", 47, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 3 "D:\Rinkesh Project\RinkeshFinalPractical3\MegaMindsPractical\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css"">
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>

<div class=""text-center"">
    <h1 class=""display-4"">Student Form</h1>
</div>
<div class=""book-example panel panel-primary"">
    <!-- <div class=""panel-heading panel-head"">Student Listing</div> -->
    <div class=""panel-body"">
        ");
#nullable restore
#line 16 "D:\Rinkesh Project\RinkeshFinalPractical3\MegaMindsPractical\Views\Student\Index.cshtml"
   Write(Html.ValidationMessage("Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"btn-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e76444c709afc04cae7b171176d98a7927aa04c26695", async() => {
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-plus\"></i> Add Create\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <!-- <label>");
#nullable restore
#line 25 "D:\Rinkesh Project\RinkeshFinalPractical3\MegaMindsPractical\Views\Student\Index.cshtml"
               Write(ViewBag.CurrentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label> -->
        <table id=""CreateList"" class=""table table-striped table-bordered dt-responsive nowrap"" cellspacing=""0""
               width=""100%"" style=""margin: 4px"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Address</th>
                    <th>State</th>
                    <th>City</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>

        <div id=""divcontent"">
        </div>

    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


    <script src=""https://code.jquery.com/jquery-3.7.0.js""></script>
    <script src=""https://cdn.datatables.net/1.13.5/js/jquery.dataTables.min.js""></script>

    

    <script>
        $(document).ready(function () {
           // BindGrid();
            fetchAndInitializeDataTable();

        });
        function fetchAndInitializeDataTable() {
           
            debugger
            jQuery.ajax({
                url: '/Student/StudentList', // Replace with your server-side endpoint URL
                type: 'GET',
                success: function (data) {
                    debugger
                    // Initialize DataTable with the fetched data
                    new DataTable('#CreateList', {
                        destroy: true, // Destroy the existing DataTable if any
                        data: data.data,
                        columns: [
                            { ""data"": ""id"", ""name"": ""Id"", ""autoWidth"": true },
                            { ""data"": ""na");
                WriteLiteral(@"me"", ""name"": ""Name"", ""autoWidth"": true },
                            { ""data"": ""email"", ""name"": ""Email"", ""autoWidth"": true },
                            { ""data"": ""phone"", ""name"": ""Phone"", ""autoWidth"": true },
                            { ""data"": ""address"", ""name"": ""Address"", ""autoWidth"": true },
                            { ""data"": ""stateName"", ""name"": ""StateName"", ""autoWidth"": true },
                            { ""data"": ""cityName"", ""name"": ""CityName"", ""autoWidth"": true },
                            {
                                ""render"": function (data, type, full, meta) { return '<a class=""btn btn-info"" href=""#"" onclick=""return OpenUpdatePopup(' + full.id + ')"">Edit</a>'; }
                            },
                            {
                                data: null, render: function (data, type, row) {
                                    return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.id + ""'); >Delete</a>"";
                                }
       ");
                WriteLiteral(@"                     },
                        ]
                    });
                },
                error: function (error) {
                    console.error('Error fetching data:', error);
                }
            });
        }

        //function BindGrid() {
        //    debugger
        //    $('#CreateList').dataTable({
        //        ""processing"": true, // for show progress bar
        //        ""serverSide"": true, // for process server side
        //        ""filter"": true, // this is for disable filter (search box)
        //        ""orderMulti"": false, // for disable multiple column at once
        //        ""pageLength"": 5,
        //        ""order"": [[0, ""desc""]],
        //        ""ajax"": {
        //            ""url"": ""/Student/GetStudentList1"",
        //            ""type"": ""Get""

        //        }, ""columns"": [
        //            { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
        //            { ""data"": ""Name"", ""name"": ""Name"", ""autoWidth");
                WriteLiteral(@""": true },
        //            { ""data"": ""Email"", ""name"": ""Email"", ""autoWidth"": true },
        //            { ""data"": ""Phone"", ""name"": ""Phone"", ""autoWidth"": true },
        //            { ""data"": ""Address"", ""name"": ""Address"", ""autoWidth"": true },
        //            { ""data"": ""StateName"", ""name"": ""StateName"", ""autoWidth"": true },
        //            { ""data"": ""CityName"", ""name"": ""CityName"", ""autoWidth"": true },
        //            {
        //                ""render"": function (data, type, full, meta) { return '<a class=""btn btn-info"" href=""#"" onclick=""return OpenUpdatePopup(' + full.id + ')"">Edit</a>'; }
        //            },
        //            {
        //                data: null, render: function (data, type, row) {
        //                    return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.id + ""'); >Delete</a>"";
        //                }
        //            },
        //        ],
        //        ""lengthMenu"": [[10, 15, 25, 50, 100, 200], [");
                WriteLiteral(@"10, 15, 25, 50, 100, 200]]
        //    });
        //}

        function OpenAddPopup() {
            $.ajax({
                url: '/Student/GetStudentById', // Correct the URL
                contentType: 'application/html; charset=utf-8',
                type: 'GET',
                dataType: 'html',
                success: function (result) {
                    $('#divcontent').empty();
                    $('#divcontent').html(result);
                    $('#AddUpdateModelPopup').modal('show');
                },
                error: function (xhr, status) {
                    alert(status);
                }
            });
        }

        function OpenUpdatePopup(Id) {
            debugger
            $.ajax({
                url: '/Student/GetStudentById?Id=' + Id, // Correct the URL
                contentType: 'application/html; charset=utf-8',
                type: 'GET',
                dataType: 'html',
                success: function (result) {
         ");
                WriteLiteral(@"           $('#divcontent').empty();
                    $('#divcontent').html(result);
                    $('#AddUpdateModelPopup').modal('show');
                },
                error: function (xhr, status) {
                    alert(status);
                }
            });
        }

        function DeleteData(ID) {

            Swal.fire({
                title: 'Are you sure?',
                text: ""You won't be able to delete this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.isConfirmed) {

                    $.ajax({
                        url: ""/Student/DeleteStudent?Id="" + ID,
                        type: ""POST"",
                        contentType: ""application/json;charset=UTF-8"",
                        dataType: ""json"",
     ");
                WriteLiteral(@"                   success: function (result) {
                            Swal.fire('Deleted!', 'Your data has been deleted.', 'success')
                            setTimeout(function () { window.location.href = ""/Student/GetStudentList""; }, 2000);

                        },
                        error: function (errormessage) {
                            alert(errormessage.responseText);
                        }
                    });

                }
            })
        }
    </script>
    <!-- Add jQuery -->
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

    <!-- Add Bootstrap (JS and CSS) -->
    <link href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
