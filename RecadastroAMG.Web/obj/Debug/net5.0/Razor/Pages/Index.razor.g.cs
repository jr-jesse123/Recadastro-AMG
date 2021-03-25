#pragma checksum "D:\repos\amg\RecadastroAMG.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347675f3fc720a9afc357d91f86e802b1615c515"
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
#nullable restore
#line 11 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using RecadastroAMG.Web.Shared.formulario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using RecadastroAMG.Web.Shared.formulario.InformacoesPessoais;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using RecadastroAMG.Web.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\repos\amg\RecadastroAMG.Web\Pages\Index.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/{CRMHash:int}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RecadastroAMG.Web.Shared.formulario.ForComponent>(0);
            __builder.AddAttribute(1, "model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RecadastroAMG.Web.Data.Models.NovoRegistroInputDto>(
#nullable restore
#line 5 "D:\repos\amg\RecadastroAMG.Web\Pages\Index.razor"
                     model

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n\r\n\r\n\r\n}\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\repos\amg\RecadastroAMG.Web\Pages\Index.razor"
         
    NovoRegistroInputDto model { get; set; }

    ForComponent formulario { get; set; }

    [Parameter] public int CRMHash { get; set; }
    [Inject] public AMGContext context { get; set; }

    protected override Task OnParametersSetAsync()
    {
        var crm = Domain.CRMModule.GetCRM(CRMHash);

        var registro = context.DadosIniciais.Where(d => d.Crm == crm.ToString()).Single();

        DateTime nascimento;
        try
        {
            var parts = registro.DataNascimento.Split("/").Select(p => Convert.ToInt32(p)).ToArray();
            nascimento = new DateTime(parts[0], parts[1], parts[2]);

        }
        catch (Exception)
        {

            nascimento = new DateTime();
        }

        model = new NovoRegistroInputDto()
        {
            Email = registro.Email,
            Telefone1 = registro.Telefone1,
            Telefone2 = registro.Telefone2,
            Bairro = registro.Bairro,
            CEP = registro.Cep,
            Cidade = registro.Cidade,
            Complemento = registro.Complemento,
            Estado = (Enums.Estado)Enum.Parse(typeof(Enums.Estado), registro.Estado)
            ,
            Logradouro = registro.Logradoutro,

            AnoFormatura = string.IsNullOrWhiteSpace(registro.AnoFormatura) ? 2000 : Convert.ToInt32(registro.AnoFormatura),
            CPF = registro.Cpf,
            CRM = Convert.ToInt32(registro.Crm),
            DataNascimento = nascimento,
            Nome = registro.Nome

        };

        return base.OnParametersSetAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
