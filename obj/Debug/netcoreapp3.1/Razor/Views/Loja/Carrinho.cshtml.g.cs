#pragma checksum "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2d9c49056503d5228d35abc298b7b712c22399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loja_Carrinho), @"mvc.1.0.view", @"/Views/Loja/Carrinho.cshtml")]
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
#line 1 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/_ViewImports.cshtml"
using ECommerceLiteAlexandre;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/_ViewImports.cshtml"
using ECommerceLiteAlexandre.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/_ViewImports.cshtml"
using ECommerceLiteAlexandre.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2d9c49056503d5228d35abc298b7b712c22399", @"/Views/Loja/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b11b79586c7f3df7ef497d4f4ce941f0e1c430", @"/Views/_ViewImports.cshtml")]
    public class Views_Loja_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "inicio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/carrinho.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
  
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2d9c49056503d5228d35abc298b7b712c223995249", async() => {
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
            WriteLiteral("\r\n\r\n<header>\r\n    <h1>Carrinho</h1>\r\n</header>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2d9c49056503d5228d35abc298b7b712c223996880", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2d9c49056503d5228d35abc298b7b712c223997175", async() => {
                    WriteLiteral("\r\n            <button type=\"submit\">Adicionar Produto</button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <h2 totalVenda>Valor total: R$");
#nullable restore
#line 19 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
                                 Write(Math.Round(Model.TotalVenda, 2));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n        <button onclick=\"carrinho.zerarCarrinho(this)\">Limpar Carrinho</button>\r\n\r\n    </div>\r\n");
#nullable restore
#line 24 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
      var className = "wrapper"; 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div carrinhoTexto class=\"carrinhoTexto\">\r\n");
#nullable restore
#line 27 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
         if (Model.Pedido.Itens.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>Seu carrinho está vazio.</h1>");
#nullable restore
#line 28 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 31 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
 if (Model.Pedido.Itens.Count() == 1)
{
    className += "1";
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
 if (Model.Pedido.Itens.Count() == 2)
{
    className += "2";
}

#line default
#line hidden
#nullable disable
                WriteLiteral("<div");
                BeginWriteAttribute("class", " class=\"", 862, "\"", 880, 1);
#nullable restore
#line 39 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
WriteAttributeValue("", 870, className, 870, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 40 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
     foreach (var item in Model.Pedido.Itens)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card carrinho\"");
                BeginWriteAttribute("item-id", " item-id=\"", 972, "\"", 990, 1);
#nullable restore
#line 42 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
WriteAttributeValue("", 982, item.Id, 982, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 1010, "\"", 1065, 3);
                WriteAttributeValue("", 1016, "/images/produtos/large_", 1016, 23, true);
#nullable restore
#line 43 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
WriteAttributeValue("", 1039, item.Produto.Codigo, 1039, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1061, ".jpg", 1061, 4, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <h1>");
#nullable restore
#line 44 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
           Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            <p precoVenda>R$");
#nullable restore
#line 45 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
                       Write(Math.Round(item.SubtotalVenda, 2));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p class=\"descricao\">");
#nullable restore
#line 46 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
                            Write(item.Produto.Descricao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div>\r\n                <button onclick=\"carrinho.clickIncremento(this)\"><img class=\"mais\" src=\"/images/plus.png\"></button>\r\n                <input quantidade class=\"quantidade\" type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1442, "\"", 1466, 1);
#nullable restore
#line 49 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
WriteAttributeValue("", 1450, item.Quantidade, 1450, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" oninput=\"validity.valid||(value=\'\');\"\r\n                       onblur=\"carrinho.updateQuantidade(this)\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1570, "\"", 1600, 1);
#nullable restore
#line 50 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
WriteAttributeValue("", 1584, item.Quantidade, 1584, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <button onclick=\"carrinho.clickDecremento(this)\"><img class=\"menos\" src=\"/images/minus.png\"></button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 54 "/Users/alexandrelima/Desktop/ECommerceLiteAlexandre/e-commerce-lite/Views/Loja/Carrinho.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2d9c49056503d5228d35abc298b7b712c2239915538", async() => {
                    WriteLiteral("\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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