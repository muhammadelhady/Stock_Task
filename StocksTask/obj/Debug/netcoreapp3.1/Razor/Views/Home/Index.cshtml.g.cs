#pragma checksum "D:\StocksTask\StocksTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76921ab1da09c71e464c39715871ff928a32923d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.razor-page", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\StocksTask\StocksTask\Views\_ViewImports.cshtml"
using StocksTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\StocksTask\StocksTask\Views\_ViewImports.cshtml"
using StocksTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76921ab1da09c71e464c39715871ff928a32923d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78693c44c24c336fbf04c5970237650930edaed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script type=""text/javascript"" src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
<link rel=""stylesheet"" href=""//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css"" />

<div class=""container"">
    <div class=""row"">&nbsp;</div>
    <div class=""row"">
        <div class=""col-2"">Stocks</div>
        <div class=""col-12"">
            <table id=""TblInfo"" class=""table table-bordered table-striped mt-4"">
                <thead>
                    <tr class=""bg-primary text-light"">
                        <td>Stock Code</td>
                        <td>old Price</td>
                        <td>Price</td>
                        <td>Updated At</td>

                    </tr>
                </thead>
                <tbody class=""InfoTBody"">
                </tbody>
            </table>
        </div>
    </div>

</div>
<div class=""row"">
    <div class=""col-12"">
        <hr />");
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n    setInterval(function () {\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \"");
#nullable restore
#line 43 "D:\StocksTask\StocksTask\Views\Home\Index.cshtml"
             Write(Url.Action("getStocks"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
            data:"""",
            dataType: """",
            success: function (data) {
                var rows = '';
                $.each(data, function (index, item) {  
                    rows += ""<tr>"";
                    rows += ""<td>"" + item.stockCode + ""</td>"";
                    rows += ""<td>"" + item.lastPrice + ""</td>"";
                    rows += ""<td>"" + item.oldPrice + ""</td>"";
                    rows += ""<td>"" + item.modifiedAt + ""</td>"";
                    rows += ""</tr>"";
                });
                $('.InfoTBody').html(rows);
                $('#TblInfo').DataTable();
            }
        });
    }, 1000);//time in milliseconds
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Index>)PageContext?.ViewData;
        public Views_Home_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
