#pragma checksum "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\Main\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6902b08e06568bdb657ef2f086145e5515739a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Cadastrar), @"mvc.1.0.view", @"/Views/Main/Cadastrar.cshtml")]
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
#line 1 "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\_ViewImports.cshtml"
using AlunoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\_ViewImports.cshtml"
using AlunoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6902b08e06568bdb657ef2f086145e5515739a93", @"/Views/Main/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b570742181059c035aa95e17eb82766ae69fac61", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlunoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\Main\Cadastrar.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Cadastro de Alunos</h4>\r\n    <hr />\r\n");
#nullable restore
#line 16 "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\Main\Cadastrar.cshtml"
Write(Html.ValidationSummary("", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\Main\Cadastrar.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Cadastrar\" class=\"btn btn-success\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\VE\OneDrive\Área de Trabalho\revisao\aluno\AlunoApp\AlunoApp\AlunoApp\Views\Main\Cadastrar.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlunoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591