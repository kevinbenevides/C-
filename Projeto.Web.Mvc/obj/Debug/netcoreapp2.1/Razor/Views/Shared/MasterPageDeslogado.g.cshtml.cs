#pragma checksum "C:\Users\user\Documents\Scripts\C-sharp-master\Projeto.Web.Mvc\Views\Shared\MasterPageDeslogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694fa7b0f4a2dd9bea0b657cbd8c482bdb76fb00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageDeslogado), @"mvc.1.0.view", @"/Views/Shared/MasterPageDeslogado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageDeslogado.cshtml", typeof(AspNetCore.Views_Shared_MasterPageDeslogado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694fa7b0f4a2dd9bea0b657cbd8c482bdb76fb00", @"/Views/Shared/MasterPageDeslogado.cshtml")]
    public class Views_Shared_MasterPageDeslogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 758, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41574be67a2648df9998bcf9a86918d7", async() => {
                BeginContext(29, 109, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <title> \n        ");
                EndContext();
                BeginContext(139, 13, false);
#line 7 "C:\Users\user\Documents\Scripts\C-sharp-master\Projeto.Web.Mvc\Views\Shared\MasterPageDeslogado.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(152, 622, true);
                WriteLiteral(@" 
    </title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""../../wwwroot/css/Main.css"" rel=""stylesheet"" type=""text/css""/>
    <style>
        body{
            background-color: #444;
            color: #fff;
        }

        a{
            color: #fff;
        }

        input {
            border-radius: 30px;
            outline: none;
        }

        .caixa-principal{
            padding: 10px;
            width: 100%;
        }

        .caixa {
            border: 1px solid black;
            padding: 5px;
            margin: 100px 40%;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(782, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f916e778b44440d9aa5b3ee44db05b30", async() => {
                BeginContext(788, 198, true);
                WriteLiteral("\n    <a class=\"cor-amarelo\" href=\"/Usuario/Cadastrar\">Cadastrar Usuário</a>\n    <a href=\"/Usuario/Login\">Efetuar Login</a>\n\n    <div class=\"caixa-principal\">\n        <div class=\"caixa\">\n            ");
                EndContext();
                BeginContext(987, 12, false);
#line 44 "C:\Users\user\Documents\Scripts\C-sharp-master\Projeto.Web.Mvc\Views\Shared\MasterPageDeslogado.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(999, 86, true);
                WriteLiteral("\n        </div>\n    </div>\n\n    <footer>\n        Desenvolvido por Senai\n    </footer>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1092, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
