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
#line 1 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunados/registrar")]
    public partial class RegistrarVacunado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
       
    private string cedulaInput = "";
    private string cedula = "";
    private Vacunado vacunado = null;
    private bool existente = false;

    private string error = "";

    private void parseaCedula() {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                         

        cedula = cedulaInput.Replace("-", "").Replace(" ", "");

        if (!Functions.ValidaCedula(cedula)) {
            error = "La cedula ingresada no es valida";
            return;
        }

        buscaCedula();
    }

    private void buscaCedula() {
        try {
            vacunado = vc.Vacunados.Where(x => x.Cedula == cedula).First();
            existente = true;
            error = "";
        } catch (InvalidOperationException) {
            buscaEnApi();
        }
    }

    private async void buscaEnApi() {
        string url = $"https://api.adamix.net/apec/cedula/{cedula}";
        try {
            CedulaInfo datos = await http.GetJsonAsync<CedulaInfo>(url);
            reemplazarDatos(datos);
        } catch {
            vacunado = new Vacunado();
        }
        
        error = "";
        StateHasChanged();
    }

    private void reemplazarDatos(CedulaInfo datos) {
        string nombre = datos.Nombres;
        string apellido = datos.Apellido1+" "+datos.Apellido2;

        vacunado = new Vacunado{
            Cedula = cedula,
            Nombre = nombre,
            Apellido = apellido,
        };
    }

    private void vacunadoValido() {
        if (!existente) {
            vc.Add(vacunado);
            existente = true;
        }
        vc.SaveChanges();
    }

    private void borrarVacunado() {
        vc.Remove(vacunado);
        vc.SaveChanges();

        vacunado = null;
        existente = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunaContext vc { get; set; }
    }
}
#pragma warning restore 1591