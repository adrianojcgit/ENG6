#pragma checksum "C:\Adriano\Projetos\ENG6\ENG6.WebUI\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4dbe4d2802dfc454c6e1f93720662042b35c833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
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
#line 1 "C:\Adriano\Projetos\ENG6\ENG6.WebUI\Views\_ViewImports.cshtml"
using ENG6.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Adriano\Projetos\ENG6\ENG6.WebUI\Views\_ViewImports.cshtml"
using ENG6.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4dbe4d2802dfc454c6e1f93720662042b35c833", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9ad8859ef89932eb6de2fc9f12bfa387494319", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Adriano\Projetos\ENG6\ENG6.WebUI\Views\Clientes\Index.cshtml"
  
	ViewData["Title"] = "Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n<div>\r\n\t<h2>");
#nullable restore
#line 8 "C:\Adriano\Projetos\ENG6\ENG6.WebUI\Views\Clientes\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n\t<div class=\"col-md-12\">\r\n\t\t<div>\r\n\t\t\t<div class=\"pull-left\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4dbe4d2802dfc454c6e1f93720662042b35c8334406", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<span title=\"Register New\" class=\"fas fa-plus\"></span> Register New\r\n\t\t\t\t");
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
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<br />\r\n<div class=\"panel panel-default\">\r\n\t<table id=\"myDataTable\" class=\"table table-bordered table-striped table-hover table-responsive\" style=\"white-space:nowrap\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n");
            WriteLiteral("\t\t\t\t<th>Nome</th>\r\n                <th>CNPJ</th>\r\n");
            WriteLiteral("\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n\t\t\t<tr>\r\n                <td></td>\r\n                <td></td>\r\n\t\t\t</tr>\r\n\t\t</tbody>\r\n\t</table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<!-- JS -->
	<script src=""https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js""></script>
	<script type=""text/javascript"">
		$(document).ready(function(){

			    //Pega os dados do banco de dados para preencher o datatable
			    //$('#myDataTable').DataTable({
				   // ""language"": {
					  //  ""lengthMenu"": ""Exibe _MENU_ Registros por p??gina"",
					  //  ""search"": ""Procurar"",
					  //  ""paginate"": { ""previous"": ""Retorna"", ""next"": ""Avan??a"" },
					  //  ""zeroRecords"": ""Nada foi encontrado"",
					  //  ""info"": ""Exibindo p??gina _PAGE_ de _PAGES_"",
					  //  ""infoEmpty"": ""Sem registros"",
					  //  ""infoFiltered"": ""(filtrado de _MAX_ regitros totais)""
				   // },
				   // ""processing"": true, // mostrar a progress bar
				   // //""serverSide"": true, // processamento no servidor
				   // ""filter"": true,     // habilita o filtro(search box)
				   // ""lengthMenu"": [[3, 5, 10, 25, 50, -1], [3, 5, 10, 25, 50, ""Todos""]],
				   // ""pageLength"": 10,    // define o tamanho da p??gi");
                WriteLiteral(@"na
				   // 'ajax': {
					  //  'url': '/Clientes/GetClientes',
					  //  'type': 'Post',
					  //  'dataType': 'json'
				   // },
				   // 'columns': [
       //                 { 'data': 'nomeEmpresarial', 'name': 'nomeEmpresarial' },
       //             ]
       //       });
			///////////////

            initDataTable($('#myDataTable'), 0, 'asc', false, true, 10, false, true, false, 'landscape', 'rptHdr');  /* Initialize Table */

            /*---------------------- Datatable initialization  --------------------------- */
            /*
             * table           Table id which be initialized
             * sortCol          Column number that will be initially sortered 
             * sorOrder         Ascendant (asc) or Descendant (desc)
             * enFilter         Boolean value to enable or not the filter option
             * enPaginate       Boolean value to enable or not the filter option
             * dplyLength       Number of records contained per page when p");
                WriteLiteral(@"agination is enabled
             * enInfo           Boolean value to show or not the records info
             * autoWidth        Boolean value to enable or not table autowidth
             * enTblTools       Boolean value to enable or not the table tools addin
             * pdfOrientation   Page orientation (landscape, portrait) for pdf documents (required enTblTools == enabled)
             * fileName         Output file naming (required enTblTools == enabled)
             * 
              /*------------------------------------------------------------------------------*/

            function initDataTable($table, sortCol, sortOrder, enFilter, enPaginate, dplyLength, enInfo, autoWidth, enTblTools, pdfOrientation, fileName) {

                var dom = (enTblTools) ? 'T' : '';

                var oTable = $table.dataTable({
                    	'ajax': {
                    		'url': '/Clientes/GetClientes',
                    		'type': 'POST',
                    		'dataType': 'json'
  ");
                WriteLiteral(@"                  },
                    	'columns': [
                        { 'data': 'nomeEmpresarial' }, { 'data': 'cnpjNumInscricao' }
                    ],

                    //""order"": [
                    //    [sortCol, sortOrder]
                    //],
                    ""bDestroy"": true,
                    ""bProcessing"": true,
                    //""dom"": dom,
                    ""bFilter"": enFilter,
                    ""bSort"": true,
                    ""bSortClasses"": true,
                    ""bPaginate"": enPaginate,
                    ""sPaginationType"": ""full_numbers"",
                    ""iDisplayLength"": dplyLength,
                    //""bInfo"": enInfo,
                    //""bAutoWidth"": autoWidth
                    //""tableTools"": {
                    //    ""aButtons"": [
                    //        {
                    //            ""sExtends"": ""copy"",
                    //            ""sButtonText"": ""Copy"",
                    //            ""bHeader""");
                WriteLiteral(@": true,
                    //            ""bFooter"": true,
                    //            ""fnComplete"": function (nButton, oConfig, oFlash, sFlash) {
                    //                $().shownotify('showNotify', {
                    //                    text: 'Table copied to clipboard (no formatting)',
                    //                    sticky: false,
                    //                    position: 'middle-center',
                    //                    type: 'success',
                    //                    closeText: ''
                    //                });
                    //            }
                    //        } 
                    //    ,{
                    //        ""sExtends"": ""csv"",
                    //        ""sButtonText"": ""Excel (CSV)"",
                    //        ""sToolTip"": ""Save as CSV file (no formatting)"",
                    //        ""bHeader"": true,
                    //        ""bFooter"": true,
                    //       ");
                WriteLiteral(@" ""sTitle"": fileName,
                    //        ""sFileName"": fileName + "".csv"",
                    //        ""fnComplete"": function (nButton, oConfig, oFlash, sFlash) {
                    //            $().shownotify('showNotify', {
                    //                text: 'CSV file saved in selected location.',
                    //                sticky: false,
                    //                position: 'middle-center',
                    //                type: 'success',
                    //                closeText: ''
                    //            });
                    //        }
                    //    }, 
                    //    {
                    //        ""sExtends"": ""pdf"",
                    //        ""sPdfOrientation"": pdfOrientation,
                    //        ""bFooter"": true,
                    //        ""sTitle"": fileName,
                    //        ""sFileName"": fileName + "".pdf"",
                    //        ""fnComplete"": function (nBut");
                WriteLiteral(@"ton, oConfig, oFlash, sFlash) {
                    //            $().shownotify('showNotify', {
                    //                text: 'PDF file saved in selected location.',
                    //                sticky: false,
                    //                position: 'middle-center',
                    //                type: 'success',
                    //                closeText: ''
                    //            });
                    //        }
                    //    },
                    //    {
                    //        ""sExtends"": ""Other"",
                    //        ""bShowAll"": true,
                    //        ""sMessage"": fileName,
                    //        ""sInfo"": ""Please press escape when done""
                    //    }
                    //  ]
                    //}
                    //""fnDrawCallback"": function( oSettings ) {alert( 'DataTables has redrawn the table' );}
                });
                /* If is IE then avoid set");
                WriteLiteral(@"ting the sticky headers */
                if (!navigator.userAgent.match(/msie/i) && enPaginate == false) {
                    new $.fn.dataTable.FixedHeader(oTable);
                }

                return oTable
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
