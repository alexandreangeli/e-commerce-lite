#pragma checksum "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f938df25ebe8de1f595d96607399a1de51923551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loja_Carrinho), @"mvc.1.0.view", @"/Views/Loja/Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Loja/Carrinho.cshtml", typeof(AspNetCore.Views_Loja_Carrinho))]
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
#line 1 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\_ViewImports.cshtml"
using ECommerceLiteAlexandre;

#line default
#line hidden
#line 2 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\_ViewImports.cshtml"
using ECommerceLiteAlexandre.Models;

#line default
#line hidden
#line 3 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\_ViewImports.cshtml"
using ECommerceLiteAlexandre.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f938df25ebe8de1f595d96607399a1de51923551", @"/Views/Loja/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b11b79586c7f3df7ef497d4f4ce941f0e1c430", @"/Views/_ViewImports.cshtml")]
    public class Views_Loja_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "inicio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carrinho.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
  
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
            BeginContext(73, 31, true);
            WriteLiteral("\r\n<br />\r\n<h1>Carrinho</h1>\r\n\r\n");
            EndContext();
            BeginContext(206, 44, true);
            WriteLiteral("\r\n<div lista>\r\n    <div class=\"wrapper\">\r\n\r\n");
            EndContext();
#line 16 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
         foreach (var item in Model.Pedido.Itens)
        {

#line default
#line hidden
            BeginContext(312, 38, true);
            WriteLiteral("            <div class=\"card carrinho\"");
            EndContext();
            BeginWriteAttribute("item-id", " item-id=\"", 350, "\"", 368, 1);
#line 18 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
WriteAttributeValue("", 360, item.Id, 360, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(369, 23, true);
            WriteLiteral(">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 392, "\"", 447, 3);
            WriteAttributeValue("", 398, "/images/produtos/large_", 398, 23, true);
#line 19 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
WriteAttributeValue("", 421, item.Produto.Codigo, 421, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 443, ".jpg", 443, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 448, "\"", 472, 1);
#line 19 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
WriteAttributeValue("", 454, item.Produto.Nome, 454, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(473, 42, true);
            WriteLiteral(" style=\"width:100%\">\r\n                <h1>");
            EndContext();
            BeginContext(516, 17, false);
#line 20 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
               Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(533, 53, true);
            WriteLiteral("</h1>\r\n                <p class=\"price\" precoVenda>R$");
            EndContext();
            BeginContext(587, 18, false);
#line 21 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
                                         Write(item.SubtotalVenda);

#line default
#line hidden
            EndContext();
            BeginContext(605, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(631, 22, false);
#line 22 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
              Write(item.Produto.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(653, 170, true);
            WriteLiteral("</p>\r\n                <div>\r\n                    <button onclick=\"carrinho.clickIncremento(this)\">/\\</button>\r\n                    <input class=\"quantidade\" type=\"number\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 823, "\"", 849, 1);
#line 25 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
WriteAttributeValue("", 831, item.Quantidade, 831, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(850, 238, true);
            WriteLiteral(" oninput=\"validity.valid||(value=\'\');\"\r\n                           onblur=\"carrinho.updateQuantidade(this)\" />\r\n                    <button onclick=\"carrinho.clickDecremento(this)\">\\/</button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
        }

#line default
#line hidden
            BeginContext(1099, 48, true);
            WriteLiteral("    </div>\r\n    <p totalVenda>Total de venda: R$");
            EndContext();
            BeginContext(1148, 16, false);
#line 32 "C:\Users\alean\Desktop\Nova pasta (3)\Projetinho\ECommerceLiteAlexandre\ECommerceLiteAlexandre\Views\Loja\Carrinho.cshtml"
                               Write(Model.TotalVenda);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 18, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2165, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49334d19beab484b8de613eec6bd7b80", async() => {
                BeginContext(2205, 72, true);
                WriteLiteral("\r\n    <button type=\"submit\">\r\n        Adicionar Produto\r\n    </button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2284, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2311, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2317, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82092ebc9f41420dbd4aceb891b49502", async() => {
                    BeginContext(2348, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2365, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591