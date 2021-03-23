using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RecadastroAMG.Web.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecadastroAMG.Web.Shared.formulario
{
    public class ContainerBase : ComponentBase
    {
        public NovoRegistroInputDto Model { get; set; }

        protected override void OnInitialized()
        {
            Model = (NovoRegistroInputDto)Context.Model;
            base.OnInitialized();
        }

        [Parameter] public EditContext Context { get; set; }
    }
}
