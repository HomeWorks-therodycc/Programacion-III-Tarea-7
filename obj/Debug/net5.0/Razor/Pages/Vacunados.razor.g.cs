#pragma checksum "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f981813752c251e66b2fcdfe295681828b292ca"
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
#line 1 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
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
            __builder.AddMarkupContent(0, "<div class=\"alert alert-light\" role=\"alert\"><h3>Vacunados</h3></div>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group");
            __builder.AddMarkupContent(3, "<label for=\"filtro\" class=\"input-group-text\">Nombre o Apellido</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "filtro");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                                                filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filtro = __value, filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<br>");
#nullable restore
#line 14 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
 if (vacunados == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"spinner-border text-secondary\" role=\"status\"><span class=\"sr-only\">Loading...</span></div>");
#nullable restore
#line 18 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<tr><th>ID</th>\r\n            <th>Cedula</th>\r\n            <th>Nombre</th>\r\n            <th>Apellido</th>\r\n            <th>Telefono</th>\r\n            <th>Provincia</th>\r\n            <th>Vacuna #1</th>\r\n            <th>Vacuna #2</th></tr>");
#nullable restore
#line 30 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
         foreach (var v in vacunados.Where(x => x.Nombre.ToLower().Contains(filtro) || x.Apellido.ToLower().Contains(filtro)))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Provincia.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 39 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Vacuna1Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 40 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
                     v.Vacuna2Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\Vacunados.razor"
       
    private string filtro = "";
    private List<Vacunado> vacunados = null;
    
    protected override void OnInitialized() {
        vacunados = vc.Vacunados.Include(x => x.Provincia).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunaContext vc { get; set; }
    }
}
#pragma warning restore 1591
