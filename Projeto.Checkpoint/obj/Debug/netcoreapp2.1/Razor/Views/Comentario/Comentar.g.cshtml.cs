#pragma checksum "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5766a37e8c4a5fd063c163a8a46b8c3a5ca657fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Comentar), @"mvc.1.0.view", @"/Views/Comentario/Comentar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Comentar.cshtml", typeof(AspNetCore.Views_Comentario_Comentar))]
namespace AspNetCore
{
    #line hidden
#line 2 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
using System;

#line default
#line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
using Projeto.Checkpoint.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5766a37e8c4a5fd063c163a8a46b8c3a5ca657fb", @"/Views/Comentario/Comentar.cshtml")]
    public class Views_Comentario_Comentar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
  
    ViewBag.Title = "Comentários do Usuário";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(134, 2781, true);
            WriteLiteral(@"
<link href=""/css/style.css"" rel=""stylesheet"" type=""text/css"">

<header>
        <div class=""background-topos"">
            <div class=""logo"">
                <img class=""none none2"" src=""img/logo.png"" alt=""#"">
            </div>
            <div class=""content-topo"">
                <div class=""login none none2"">
                    <a href=""Usuario/Login"">Login</a>
                </div>
                <div class=""login none none2"">
                    <a href=""Usuario/Cadastrar"">Cadastrar</a>
                </div>
                <nav class=""nav-bar"">
                    <ul>
                        <li>
                            <a href=""http://localhost:5000"">
                                <div class=""link m-res"">
                                    Home
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""sobre.html"">
                                <div class=""link m-res"">
          ");
            WriteLiteral(@"                          Sobre Nós
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""Comentario/Comentar"">
                                <div class=""link m-res"">
                                    Comentários
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""contato.html"">
                                <div class=""link"">
                                    Fale Conosco
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""duvidas.html"">
                                <div class=""link"">
                                    Dúvidas Frequentes
                                </div>
                            </a>
                        </li>
                   ");
            WriteLiteral(@" </ul>
                </nav>
            </div>
            <!-- fim content-topo -->
        </div>
        <!-- fim do background-topo -->
    </header>

    <main>
        <div class=""comentario"">
            <h1>Comentários</h1>
            <form class=""area-comentario""  action = ""/Comentario/Cadastrar"" method = ""POST""> 
                <label>Escreva seu comentario sobre o CheckList:<br>
                    <textarea name=""texto"" placeholder=""Digite aqui..."" required=""true"" maxlength=""100"" minlength=""1""></textarea>
                </label><br> 
                <input class=""botao"" type=""submit"" value=""Enviar"">
            </form>

        </div>

        <div class=""comentarios"">
            <div class=""caixa-comen"">
");
            EndContext();
#line 82 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
                 foreach (var item in ViewData["Comentarios"] as List<ComentarioModel>){

#line default
#line hidden
            BeginContext(3004, 49, true);
            WriteLiteral("                    <h3>\n                        ");
            EndContext();
            BeginContext(3054, 17, false);
#line 84 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
                   Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3071, 75, true);
            WriteLiteral("\n                    </h3>\n                    <p>\n                        ");
            EndContext();
            BeginContext(3147, 10, false);
#line 87 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
                   Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(3157, 74, true);
            WriteLiteral("\n                    </p>\n                    <p>\n                        ");
            EndContext();
            BeginContext(3232, 16, false);
#line 90 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
                   Write(item.DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(3248, 26, true);
            WriteLiteral("\n                    </p>\n");
            EndContext();
#line 92 "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Comentario\Comentar.cshtml"
                    }

#line default
#line hidden
            BeginContext(3296, 1042, true);
            WriteLiteral(@"            </div>

            <div class=""caixa-comen"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>
        </div>
        <div class=""comentarios"">

            <div class=""caixa-comen"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>

            <div class=""caixa-comen"">
                <h3>(Nome) - Usuario </h3>
                <p>Isto é um exemplo de comentario feito<br>
                    para que possa servir como um substituto<br>
                    temporário, enquanto o c# ainda não foi criado.
                </p>
            </div>
        ");
            WriteLiteral("</div>\n    </main>");
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