#pragma checksum "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c6267a1eaac9f2c9ae2bc698f08858718031db"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/borrar")]
    public partial class BorrarVacunado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"titulocantvacuna\">Borrar Vacunado</h3>\r\n\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group w-50");
            __builder.AddMarkupContent(3, "<label for=\"cedula\" class=\"input-group-text\">Cedula</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "cedula");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                                                cedulaInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedulaInput = __value, cedulaInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "input-group-append");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                          parseaCedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn btn-success");
            __builder.AddContent(16, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n<br>");
#nullable restore
#line 18 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
 if (error != "")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "h4");
            __builder.AddAttribute(19, "class", "text-danger");
            __builder.AddContent(20, 
#nullable restore
#line 20 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                             error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
 if (vacunado != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "alert alert-secondary");
            __builder.AddAttribute(25, "role", "alert");
            __builder.AddMarkupContent(26, "<tr class=\"thead\"><th>Id</th>\r\n            <th>Cedula</th>\r\n            <th>Nombre</th>\r\n            <th>Apellido</th>\r\n            <th>Fecha de Nacimiento</th>\r\n            <th>Signo Zodiacal</th></tr>\r\n        ");
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 75 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 76 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 77 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 78 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 79 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.FechaNacimiento.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 80 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.SignoZodiacal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.AddMarkupContent(46, "<tr><th>Telefono</th>\r\n            <th>Provincia</th>\r\n            <th>Vacuna #1</th>\r\n            <th>Fecha</th>\r\n            <th>Vacuna #2</th>\r\n            <th>Fecha</th>\r\n            <th></th></tr>\r\n\r\n        ");
            __builder.OpenElement(47, "tr");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 93 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 94 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                 vacunado.Provincia.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 96 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                  (vacunado.Vacuna1Id.HasValue)
            ? vacunado.Vacuna1.Marca : "N/A"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 100 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                  (vacunado.Vacuna1Fecha.HasValue) ?
            vacunado.Vacuna1Fecha.Value.ToShortDateString()
            : "N/A"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 105 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                  (vacunado.Vacuna2Id.HasValue)
            ? vacunado.Vacuna2.Marca : "N/A"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 109 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                  (vacunado.Vacuna2Fecha.HasValue) ?
            vacunado.Vacuna2Fecha.Value.ToShortDateString()
            : "N/A"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            <td></td>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "w-25 mx-auto");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
                          borrarVacunado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "class", "btn btn-warning");
            __builder.AddContent(72, "Borrar Registro");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 120 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\HP 15-BS191DX\Documents\Tarea7.1\Programacion-III-Tarea-7\Pages\BorrarVacunado.razor"
       
    private string cedulaInput = "";
    private string cedula = "";
    private string error = "";

    private Vacunado vacunado = null;

    private void parseaCedula()
    {
        cedula = cedulaInput.Replace("-", "").Replace(" ", "");

        vacunado = null;

        if (!Functions.ValidaCedula(cedula))
        {
            error = "La cedula ingresada no es valida";
            return;
        }

        buscaCedula();
    }

    private void buscaCedula()
    {
        try
        {
            vacunado = vc.Vacunados.Where(x => x.Cedula == cedula)
                .Include("Provincia").Include("Vacuna1")
                .Include("Vacuna2").First();
            error = "";
        }
        catch (InvalidOperationException)
        {
            error = "No se ha encontrado ninguna persona con esa cedula";
        }
    }

    private void borrarVacunado()
    {
        vc.Remove(vacunado);
        vc.SaveChanges();
        vacunado = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunaContext vc { get; set; }
    }
}
#pragma warning restore 1591
