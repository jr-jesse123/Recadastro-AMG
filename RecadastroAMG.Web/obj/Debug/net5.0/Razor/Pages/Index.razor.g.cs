#pragma checksum "D:\repos\amg\RecadastroAMG.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9236973392b76e1bfcd54d8ddf424c11a3440643"
// <auto-generated/>
#pragma warning disable 1591
namespace RecadastroAMG.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using RecadastroAMG.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using RecadastroAMG.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<RecadastroAMG.Web.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, @"<div class=""alert alert-primary"" role=""alert""><p>
            Prezado Sr. Jos� Rodrigues!
        </p>
        <p class=""text-justify"">
            Visando as boas pr�ticas de privacidade e gest�o de dados nos princ�pios da nova LGPD - Lei Geral de Prote��o de
            Dados -
            Estamos atualizando os dos nossos associados. <br>
            Por Favor Gostaria que verificasse os dados abaixo e corrigisse qualquer informa��o que se encontre
            desatualizada.
        </p>

        <p><b>
                Nossa Equipe de comunica��o entrar� em contato em breve para confirmar o processo e esclarecer poss�veis
                d�vidas
            </b></p></div>
    ");
            __builder.AddMarkupContent(7, "<div class=\"card mt-4\"><div class=\"card-header text-center\"><h1>M�dico Jos� Rodriggues Fernandes</h1>\r\n            <h2 class=\"text-muted\">CRM: 7782</h2></div></div>\r\n\r\n    ");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "class", "row g-3");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card my-3");
            __builder.AddMarkupContent(12, @"<div class=""m-3""><svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" fill=""currentColor"" class=""bi bi-file-earmark-person"" viewBox=""0 0 16 16""><path d=""M11 8a3 3 0 1 1-6 0 3 3 0 0 1 6 0z""></path>
                    <path d=""M14 14V4.5L9.5 0H4a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2zM9.5 3A1.5 1.5 0 0 0 11 4.5h2v9.255S12 12 8 12s-5 1.755-5 1.755V2a1 1 0 0 1 1-1h5.5v2z""></path></svg>
                <h5 class=""card-title  d-inline"">Informa��es Pessoais:</h5></div>
            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.AddMarkupContent(17, "<div class=\"col-md-6 col-lg-2\"><label for=\"inputEmail4\" class=\"form-label\">CPF:</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"cpf\" placeholder=\"Digite seu CPF\" required></div>\r\n                    ");
            __builder.AddMarkupContent(18, "<div class=\"col-md-6 col-lg-2\"><div class=\"form-label\">Data de Nascimento:</div>\r\n                        <input type=\"date\" class=\"form-control\" id=\"inlineFormInputGroupUsername\" required></div>\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-6 col-lg-2");
            __builder.AddMarkupContent(21, "<label for=\"inputAddress2\" class=\"form-label\">Ano de Formatura: </label>\r\n                        ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-select");
            __builder.AddAttribute(24, "aria-label", "Default select example");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "2020");
            __builder.AddContent(27, "2020");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-md-6 col-lg-2");
            __builder.AddMarkupContent(31, "<label for=\"inputAddress2\" class=\"form-label\">Especialidade:</label>\r\n                        ");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-select");
            __builder.AddAttribute(34, "aria-label", "Default select example");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value");
            __builder.AddContent(37, "Acupuntura");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-6 col-lg-2");
            __builder.AddMarkupContent(41, "<label for=\"inputAddress2\" class=\"form-label\">Sexo:</label>\r\n                        ");
            __builder.OpenElement(42, "select");
            __builder.AddAttribute(43, "class", "form-select");
            __builder.AddAttribute(44, "aria-label", "Default select example");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "0");
            __builder.AddContent(47, "Escolha");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", "1");
            __builder.AddContent(51, "Masculino");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "2");
            __builder.AddContent(55, "Feminino");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.AddMarkupContent(57, "<div class=\"card my-3\"><div class=\"m-3\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"32\" height=\"32\" fill=\"currentColor\" class=\"bi bi-telephone-plus\" viewBox=\"0 0 16 16\"><path d=\"M3.654 1.328a.678.678 0 0 0-1.015-.063L1.605 2.3c-.483.484-.661 1.169-.45 1.77a17.568 17.568 0 0 0 4.168 6.608 17.569 17.569 0 0 0 6.608 4.168c.601.211 1.286.033 1.77-.45l1.034-1.034a.678.678 0 0 0-.063-1.015l-2.307-1.794a.678.678 0 0 0-.58-.122l-2.19.547a1.745 1.745 0 0 1-1.657-.459L5.482 8.062a1.745 1.745 0 0 1-.46-1.657l.548-2.19a.678.678 0 0 0-.122-.58L3.654 1.328zM1.884.511a1.745 1.745 0 0 1 2.612.163L6.29 2.98c.329.423.445.974.315 1.494l-.547 2.19a.678.678 0 0 0 .178.643l2.457 2.457a.678.678 0 0 0 .644.178l2.189-.547a1.745 1.745 0 0 1 1.494.315l2.306 1.794c.829.645.905 1.87.163 2.611l-1.034 1.034c-.74.74-1.846 1.065-2.877.702a18.634 18.634 0 0 1-7.01-4.42 18.634 18.634 0 0 1-4.42-7.009c-.362-1.03-.037-2.137.703-2.877L1.885.511z\"></path>\r\n                    <path fill-rule=\"evenodd\" d=\"M12.5 1a.5.5 0 0 1 .5.5V3h1.5a.5.5 0 0 1 0 1H13v1.5a.5.5 0 0 1-1 0V4h-1.5a.5.5 0 0 1 0-1H12V1.5a.5.5 0 0 1 .5-.5z\"></path></svg>\r\n                <h5 class=\"card-title  d-inline\">Informa��es de Contato:</h5></div>\r\n            <div class=\"card-body\"><div class=\"row\"><div class=\"col-lg-2 col-md-6\"><label for=\"inputAddress2\" class=\"form-label\">Telefone Fixo:</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" placeholder=\"(62) 5555-5555\" required></div>\r\n                    <div class=\"col-lg-2 col-md-6\"><label for=\"inputAddress2\" class=\"form-label\">Telefone Celular</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" placeholder=\"(62) 9 9999-9999\" required></div>\r\n                    <div class=\"col-lg-6 col-md-12\"><label for=\"inputEmail4\" class=\"form-label\">Email:</label>\r\n                        <input type=\"email\" class=\"form-control\" id=\"inputEmail4\" placeholder=\"contato@exemplo.com.br\" required></div></div></div></div>\r\n\r\n\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card my-3");
            __builder.AddMarkupContent(60, @"<div class=""m-3""><svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" fill=""currentColor"" class=""bi bi-house"" viewBox=""0 0 16 16""><path fill-rule=""evenodd"" d=""M2 13.5V7h1v6.5a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5V7h1v6.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 13.5zm11-11V6l-2-2V2.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5z""></path>
                    <path fill-rule=""evenodd"" d=""M7.293 1.5a1 1 0 0 1 1.414 0l6.647 6.646a.5.5 0 0 1-.708.708L8 2.207 1.354 8.854a.5.5 0 1 1-.708-.708L7.293 1.5z""></path></svg>
                <h5 class=""card-title  d-inline"">Endere�o:</h5></div>
            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "card-body");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row");
            __builder.AddMarkupContent(65, "<div class=\"col-md-6 col-lg-3\"><label for=\"inputAddress2\" class=\"form-label\">CEP:</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" placeholder=\"71000-000\" required></div>\r\n                    ");
            __builder.AddMarkupContent(66, "<div class=\"col-md-6 col-lg-3\"><label for=\"inputAddress2\" class=\"form-label\">Cidade:</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" placeholder=\"ex: Goi�nia\" required></div>\r\n                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-2");
            __builder.AddMarkupContent(69, "<label for=\"inputCity\" class=\"form-label\">Estado:</label>\r\n                        ");
            __builder.OpenElement(70, "select");
            __builder.AddAttribute(71, "class", "form-select");
            __builder.AddAttribute(72, "aria-label", "Default select example");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value");
            __builder.AddContent(75, "GO");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.AddMarkupContent(77, "<div class=\"col-md-7\"><label for=\"inputAddress2\" class=\"form-label\">Logradouro:</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" placeholder=\"Logradouro\" required></div>\r\n\r\n                    ");
            __builder.AddMarkupContent(78, "<div class=\"col-md-3\"><label for=\"inputAddress2\" class=\"form-label\">N�mero:</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" placeholder=\" ex: S/N ou 20\" required></div>\r\n                    ");
            __builder.AddMarkupContent(79, @"<div class=""row""><div class=""col-md-4""><label for=""inputAddress2"" class=""form-label"">Bairro:</label>
                            <input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder=""Centro"" required></div>
                        <div class=""col-md-6""><label for=""inputAddress2"" class=""form-label"">Complemento:</label>
                            <input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder=""ex: pr�ximo ao shopping"" required></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.AddMarkupContent(81, "<button type=\"submit\" class=\"btn mt-5 btn-lg btn-primary\">Confirmar Altera��es</button>\r\n        ");
            __builder.AddMarkupContent(82, "<button type=\"submit\" class=\"btn mt-5 btn-lg btn-success\">As informa��es Est�o Corretas!</button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
