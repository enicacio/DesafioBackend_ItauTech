#pragma checksum "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1640442e4648f169476cf580e1549b2d08bdfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_AllContas), @"mvc.1.0.view", @"/Views/Conta/AllContas.cshtml")]
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
#line 1 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\_ViewImports.cshtml"
using Frontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1640442e4648f169476cf580e1549b2d08bdfc", @"/Views/Conta/AllContas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_AllContas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Lista de todas as contas</h1>
<hr>
<table class=""table table-striped"">
    <thead>
        <th scope=""col"">Número da Conta</th>
        <th scope=""col"">Agência </th>
        <th scope=""col"">Id Tipo</th>
        <th scope=""col"">Nome Conta</th>
        <th scope=""col"">Saldo</th>
        <th scope=""col"">Código</th>
        <th scope=""col"">Titular</th>
        <th scope=""col"">CPF</th>
        <th scope=""col"">Telefone</th>
        <th scope=""col"">Email</th>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
         foreach (Conta contas in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.numConta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.agencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.tipoConta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.nomeTipoConta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.saldo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.codInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
               Write(contas.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\elian\Desktop\Itau Tech\Desafio Backend\DotNetMVC\Frontend\Views\Conta\AllContas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591