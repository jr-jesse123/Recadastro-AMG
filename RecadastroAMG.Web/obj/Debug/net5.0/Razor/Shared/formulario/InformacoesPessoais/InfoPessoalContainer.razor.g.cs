#pragma checksum "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77943b6bbfdfb3caa546d6b2a1c845872660a696"
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
#line 13 "D:\repos\amg\RecadastroAMG.Web\_Imports.razor"
using RecadastroAMG.Web.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
using RecadastroAMG.Web.Shared.formulario.InformacoesPessoais;

#line default
#line hidden
#nullable disable
    public partial class InfoPessoalContainer : ContainerBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RecadastroAMG.Web.Shared.formulario.CardComponent>(0);
            __builder.AddAttribute(1, "TitleFragment", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.ContainerTitle>(2);
                __builder2.AddAttribute(3, "Titulo", "Informações Pessoais");
                __builder2.AddAttribute(4, "classe", "bi bi-file-earmark-person");
                __builder2.AddAttribute(5, "PathsFragment", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "<path d=\"M11 8a3 3 0 1 1-6 0 3 3 0 0 1 6 0z\"></path>\r\n                <path d=\"M14 14V4.5L9.5 0H4a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2zM9.5 3A1.5 1.5 0 0 0 11 4.5h2v9.255S12 12 8 12s-5 1.755-5 1.755V2a1 1 0 0 1 1-1h5.5v2z\"></path>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "BodyFragment", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.VerticalLabel>(8);
                __builder2.AddAttribute(9, "labelText", "CPF:");
                __builder2.AddAttribute(10, "idDoAlvo", "cpf");
                __builder2.AddAttribute(11, "classe", "col-md-6 col-lg-2");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                    __builder3.AddAttribute(14, "class", "form-control");
                    __builder3.AddAttribute(15, "id", "cpf");
                    __builder3.AddAttribute(16, "placeholder", "Digite seu CPF");
                    __builder3.AddAttribute(17, "required", true);
                    __builder3.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    Model.CPF

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.CPF = __value, Model.CPF))));
                    __builder3.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.CPF));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateValidationMessage_0(__builder3, 22, 23, 
#nullable restore
#line 16 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    () => Model.CPF

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenComponent<RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.VerticalLabel>(25);
                __builder2.AddAttribute(26, "labelText", "Data de Nascimento:");
                __builder2.AddAttribute(27, "idDoAlvo", "dtNascimento");
                __builder2.AddAttribute(28, "classe", "col-md-6 col-lg-2");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateInputDate_1(__builder3, 30, 31, "form-control", 32, "dtNascimento", 33, "Digite seu CPF", 34, true, 35, 
#nullable restore
#line 20 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    Model.DataNascimento

#line default
#line hidden
#nullable disable
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.DataNascimento = __value, Model.DataNascimento)), 37, () => Model.DataNascimento);
                    __builder3.AddMarkupContent(38, "\r\n            ");
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateValidationMessage_2(__builder3, 39, 40, 
#nullable restore
#line 22 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    () => Model.DataNascimento

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n\r\n        ");
                __builder2.OpenComponent<RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.VerticalLabel>(42);
                __builder2.AddAttribute(43, "classe", "col-md-6 col-lg-2");
                __builder2.AddAttribute(44, "labelText", "Ano de Formatura:");
                __builder2.AddAttribute(45, "idDoAlvo", "anoFormatura");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateInputNumber_3(__builder3, 47, 48, "form-control", 49, "anoFormatura1", 50, 
#nullable restore
#line 26 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                                           Model.AnoFormatura

#line default
#line hidden
#nullable disable
                    , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.AnoFormatura = __value, Model.AnoFormatura)), 52, () => Model.AnoFormatura);
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateValidationMessage_4(__builder3, 54, 55, 
#nullable restore
#line 27 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    () => Model.AnoFormatura

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n\r\n\r\n        ");
                __builder2.OpenComponent<RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.VerticalLabel>(57);
                __builder2.AddAttribute(58, "classe", "col-md-6 col-lg-2");
                __builder2.AddAttribute(59, "labelText", "Especialidade");
                __builder2.AddAttribute(60, "idDoAlvo", "Especialidade");
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateInputSelect_5(__builder3, 62, 63, "Especialidade", 64, "form-select", 65, 
#nullable restore
#line 32 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                                                             Model.Especialidade

#line default
#line hidden
#nullable disable
                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Especialidade = __value, Model.Especialidade)), 67, () => Model.Especialidade, 68, (__builder4) => {
                        __builder4.AddMarkupContent(69, "<option selected disabled>Escolha</option>");
#nullable restore
#line 34 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                 foreach (var item in Enum.GetNames(typeof(Enums.Especialidade)))
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(70, "option");
                        __builder4.AddAttribute(71, "value", 
#nullable restore
#line 36 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    item

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(72, 
#nullable restore
#line 36 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                           item

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 37 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(73, "\r\n            ");
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateValidationMessage_6(__builder3, 74, 75, 
#nullable restore
#line 39 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    () => Model.Especialidade

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n\r\n        ");
                __builder2.OpenComponent<RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.VerticalLabel>(77);
                __builder2.AddAttribute(78, "classe", "col-md-6 col-lg-2");
                __builder2.AddAttribute(79, "labelText", "Sexo");
                __builder2.AddAttribute(80, "idDoAlvo", "sexo");
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateInputSelect_7(__builder3, 82, 83, "form-select", 84, "sexo", 85, 
#nullable restore
#line 43 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                                                    Model.Sexo

#line default
#line hidden
#nullable disable
                    , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Sexo = __value, Model.Sexo)), 87, () => Model.Sexo, 88, (__builder4) => {
                        __builder4.AddMarkupContent(89, "<option selected disabled>Escolha</option>");
#nullable restore
#line 45 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                 foreach (var item in Enum.GetNames(typeof(Domain.Sexo)))
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(90, "option");
                        __builder4.AddAttribute(91, "value", 
#nullable restore
#line 47 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                    item

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(92, 
#nullable restore
#line 47 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                           item

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 48 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(93, "<option value>Não Desejo Informar</option>\r\n                ");
                        __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer.TypeInference.CreateValidationMessage_8(__builder4, 94, 95, 
#nullable restore
#line 50 "D:\repos\amg\RecadastroAMG.Web\Shared\formulario\InformacoesPessoais\InfoPessoalContainer.razor"
                                        () => Model.Sexo

#line default
#line hidden
#nullable disable
                        );
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RecadastroAMG.Web.Shared.formulario.InformacoesPessoais.InfoPessoalContainer
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "required", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
