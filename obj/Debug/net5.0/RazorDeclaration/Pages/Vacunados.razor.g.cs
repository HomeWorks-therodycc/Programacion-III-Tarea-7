// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\Vacunados.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\Vacunados.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunados")]
    public partial class Vacunados : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\Vacunados.razor"
       
    private string filtro = String.Empty;
    List<Vacunado> filva;
    private List<Vacunado> vacunados = null;
        
    protected override void OnInitialized()
    {
        vacunados = vc.Vacunados.Include("Provincia")
            .Include("Vacuna1").Include("Vacuna2").ToList();
    }
    private void buscar(){
            if(!string.IsNullOrEmpty(filtro)){
                filva = vacunados.Where(x => x.Nombre == filtro.ToLower() && x.Apellido == filtro.ToLower()).ToList();;
            }
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunaContext vc { get; set; }
    }
}
#pragma warning restore 1591
