#pragma checksum "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\ContainerTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b653f361cb70168b942b590b4d88e81d2279687"
// <auto-generated/>
#pragma warning disable 1591
namespace RecadastroAMG.Web.Shared.formulario.InformacoesPessoais
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
    public partial class ContainerTitle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "svg");
            __builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
            __builder.AddAttribute(2, "width", "32");
            __builder.AddAttribute(3, "height", "32");
            __builder.AddAttribute(4, "fill", "currentColor");
            __builder.AddAttribute(5, "class", 
#nullable restore
#line 3 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\ContainerTitle.razor"
             classe

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "viewBox", "0 0 16 16");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\ContainerTitle.razor"
     PathsFragment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title  d-inline");
            __builder.AddContent(11, 
#nullable restore
#line 11 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\ContainerTitle.razor"
                                      Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, ":");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\ContainerTitle.razor"
           
        [Parameter] public string Titulo { get; set; }
        [Parameter] public RenderFragment PathsFragment { get; set; }
        [Parameter] public string classe { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
