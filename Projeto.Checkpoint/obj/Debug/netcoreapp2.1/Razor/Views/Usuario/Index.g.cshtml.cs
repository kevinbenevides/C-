#pragma checksum "C:\Users\39235256801\Documents\sprint_4\Projeto.Checkpoint\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04d50fc0dcc90640feabfa80ad32fd94e92dabb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04d50fc0dcc90640feabfa80ad32fd94e92dabb", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 38, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"pt-br\">\n\n");
            EndContext();
            BeginContext(38, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d167e436bc14334b121627e265268cc", async() => {
                BeginContext(44, 183, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"/css/style.css\">\n    <title>Checkpoint</title>\n");
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
            BeginContext(234, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(236, 7011, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6fa466e4ea54ebfaca33447f7a5a710", async() => {
                BeginContext(242, 6998, true);
                WriteLiteral(@"
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
                                    Sobre Nós
                       ");
                WriteLiteral(@"         </div>
                            </a>
                        </li>
                        <li>
                            <a href=""/Comentario/Comentar"">
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
                    </ul>
                </nav>
            </div>
         ");
                WriteLiteral(@"   <!-- fim content-topo -->
        </div>
        <!-- fim do background-topo -->
    </header>

    <main class=""pag-prin"">
        <div class=""banner"">
            <img src=""img/banner.png"" alt=""#"">
        </div>

        <h1>Checkpoint</h1>
        <div class=""logo2 none"">
            <img src=""img/logo2.png"" alt=""#"">
        </div>
        <section class=""timeline"">

            <div class=""container left"">
                <div class=""content"">
                    <h3>O que é o Checkpoint?</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        <br> Unde velit aliquam hic similique nam vitae dicta adipisci eos,
                        <br> dolore perferendis minima voluptatum iusto excepturi ipsam dolorum nulla?
                        <br> Nam, officiis obcaecati.</p>
                </div>
            </div>
            <div class=""container right"">
                <div class=""content"">
                    <h3>Qual a sua importância?</h3>
        ");
                WriteLiteral(@"            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        <br> Unde velit aliquam hic similique nam vitae dicta adipisci eos,
                        <br> dolore perferendis minima voluptatum iusto excepturi ipsam dolorum nulla?
                        <br> Nam, officiis obcaecati.</p>
                </div>
            </div>
            <div class=""container left"">
                <div class=""content"">
                    <h3>O que ele pode fazer?</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        <br> Unde velit aliquam hic similique nam vitae dicta adipisci eos,
                        <br> dolore perferendis minima voluptatum iusto excepturi ipsam dolorum nulla?
                        <br> Nam, officiis obcaecati.</p>
                </div>
            </div>
            <div class=""container right"">
                <div class=""content "">
                    <h3>Qual o seu diferencial?</h3>
                ");
                WriteLiteral(@"    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        <br> Unde velit aliquam hic similique nam vitae dicta adipisci eos,
                        <br> dolore perferendis minima voluptatum iusto excepturi ipsam dolorum nulla?
                        <br> Nam, officiis obcaecati.</p>
                </div>
            </div>
        </section>
        <div id=""video"" class=""none"">
            <h3 class=""video1"">Como Funciona?</h3>
            <object class=""video none"" width=""360"" height=""250"" data=""https://www.youtube.com/embed/LVMWG6KTmgiiV6R9/""></object>
        </div>
        <section class=""planos"">
            <h2>Planos</h2>
            <div class=""content-planos"">
                <div class=""plano"" id=""bronze"">
                    <h3>Plano Gratuito</h3>
                    <ul>
                        <li>espinim slpleinim</li>
                        <li>spinim splerisom</li>
                        <li>sonim bleinim</li>
                        <li>sinim clerisom</l");
                WriteLiteral(@"i>
                    </ul>
                    <p>Gratis</p>
                    <button>Assinar</button>
                </div>

                <div class=""plano"" id=""prata"">
                    <h3>Plano Medium</h3>
                    <ul>
                        <li>espinim slpleinim</li>
                        <li>spinim splerisom</li>
                        <li>sonim bleinim</li>
                        <li>sinim clerisom</li>
                    </ul>
                    <p>R$49,99/mês</p>
                    <button>Assinar</button>
                </div>

                <div class=""plano plano3"" id=""ouro"">
                    <h3>Plano Premium</h3>
                    <ul>
                        <li>espinim slpleinim</li>
                        <li>spinim splerisom</li>
                        <li>sonim bleinim</li>
                        <li>sinim clerisom</li>
                    </ul>
                    <P>R$99,99/mês</P>
                    <button>Assinar</button>
                </div");
                WriteLiteral(@">
            </div>
        </section>
    </main>
    <footer class=""rodape"">
        <ul class=""none none2"">
            <li>Sobre</li>
            <li>Planos</li>
            <li>Contato</li>
        </ul>
        <ul class=""none none2"">
            <li>Dúvidas</li>
            <li><a href=""Usuario/Login"">Login</a></li>
            <li><a href=""Usuario/Cadastrar"">Cadastro</a></li>
        </ul>
        <div class=""redes-sociais none none2 "">
            <h3>Redes Sociais:</h3>
            <a href=""#"">
                <img src=""img/facebook.png"" alt=""#"">
            </a>
            <a href=""https://github.com/felipepoliveira"" target=""_blank"">
                <img id=""git"" src=""img/git.png"" alt=""#"">
            </a>
            <a href=""#"">
                <img src=""img/instagram.png"" alt=""#"">
            </a>
        </div>
    </footer>
");
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
            BeginContext(7247, 9, true);
            WriteLiteral("\n\n</html>");
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
