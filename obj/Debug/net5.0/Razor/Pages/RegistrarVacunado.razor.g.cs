#pragma checksum "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25dc25963b593fbcf4129ce03267c295d2a659b"
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
#line 2 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
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
            __builder.AddMarkupContent(0, "<div class=\"alert alert-light\" role=\"alert\"><h3>Registrar Vacunado</h3></div>\r\n\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group");
            __builder.AddMarkupContent(3, "<label for=\"cedula\" class=\"input-group-text\">Cedula</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "cedula");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
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
#line 16 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
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
#line 20 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
 if (error != "")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "alert alert-danger");
            __builder.AddAttribute(20, "role", "alert");
            __builder.AddContent(21, 
#nullable restore
#line 23 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
         error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
}
else if (vacunado != null)
{


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
            __builder.AddAttribute(23, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                     vacunado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 29 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                              vacunadoValido

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.OpenElement(28, "table");
                __builder2.AddAttribute(29, "class", "table");
                __builder2.OpenElement(30, "tr");
                __builder2.AddMarkupContent(31, "<td>Cedula</td>\r\n                ");
                __builder2.OpenElement(32, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                            vacunado.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Cedula = __value, vacunado.Cedula))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Cedula));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                <td></td>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "tr");
                __builder2.AddMarkupContent(41, "<td>Nombres</td>\r\n                ");
                __builder2.OpenElement(42, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                            vacunado.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Nombre = __value, vacunado.Nombre))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                <td></td>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "tr");
                __builder2.AddMarkupContent(51, "<td>Apellidos</td>\r\n                ");
                __builder2.OpenElement(52, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                            vacunado.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Apellido = __value, vacunado.Apellido))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Apellido));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                <td></td>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "tr");
                __builder2.AddMarkupContent(61, "<td>Telefono</td>\r\n                ");
                __builder2.OpenElement(62, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                            vacunado.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Telefono = __value, vacunado.Telefono))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Telefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                <td></td>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.AddMarkupContent(70, "<tr><td>Fecha de nacimiento</td>\r\n                <td><input type=\"text\" class=\"form-control\"></td>\r\n                <td></td></tr>\r\n            ");
                __builder2.AddMarkupContent(71, "<tr><td>Signo zodiacal</td>\r\n                <td><input type=\"text\" class=\"form-control\"></td>\r\n                <td></td></tr>\r\n            ");
                __builder2.OpenElement(72, "tr");
                __builder2.AddMarkupContent(73, "<td>Provincia</td>\r\n                ");
                __builder2.OpenElement(74, "td");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputSelect_0(__builder2, 75, 76, "form-control", 77, 
#nullable restore
#line 66 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                              vacunado.ProvinciaId

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.ProvinciaId = __value, vacunado.ProvinciaId)), 79, () => vacunado.ProvinciaId, 80, (__builder3) => {
#nullable restore
#line 68 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                     foreach (var p in vc.Provincias)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(81, "option");
                    __builder3.AddAttribute(82, "value", 
#nullable restore
#line 70 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                        p.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(83, 
#nullable restore
#line 70 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                               p.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 71 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                <td></td>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.OpenElement(86, "tr");
                __builder2.AddMarkupContent(87, "<td>Vacuna #1</td>\r\n                ");
                __builder2.OpenElement(88, "td");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputDate_1(__builder2, 89, 90, "form-control", 91, 
#nullable restore
#line 78 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                            vacunado.Vacuna1Fecha

#line default
#line hidden
#nullable disable
                , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna1Fecha = __value, vacunado.Vacuna1Fecha)), 93, () => vacunado.Vacuna1Fecha);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.OpenElement(95, "td");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputSelect_2(__builder2, 96, 97, "form-control", 98, 
#nullable restore
#line 80 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                              vacunado.Vacuna1Id

#line default
#line hidden
#nullable disable
                , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna1Id = __value, vacunado.Vacuna1Id)), 100, () => vacunado.Vacuna1Id, 101, (__builder3) => {
                    __builder3.AddMarkupContent(102, "<option value>N/A</option>");
#nullable restore
#line 82 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                     foreach (var v in vc.Vacunas)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(103, "option");
                    __builder3.AddAttribute(104, "value", 
#nullable restore
#line 84 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                        v.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(105, 
#nullable restore
#line 84 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                               v.Marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 85 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n            ");
                __builder2.OpenElement(107, "tr");
                __builder2.AddMarkupContent(108, "<td>Vacuna #2</td>\r\n                ");
                __builder2.OpenElement(109, "td");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputDate_3(__builder2, 110, 111, "form-control", 112, 
#nullable restore
#line 91 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                                                                                    !vacunado.Vacuna1Id.HasValue

#line default
#line hidden
#nullable disable
                , 113, 
#nullable restore
#line 91 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                            vacunado.Vacuna2Fecha

#line default
#line hidden
#nullable disable
                , 114, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna2Fecha = __value, vacunado.Vacuna2Fecha)), 115, () => vacunado.Vacuna2Fecha);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.OpenElement(117, "td");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputSelect_4(__builder2, 118, 119, "form-control", 120, 
#nullable restore
#line 94 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                !vacunado.Vacuna1Id.HasValue

#line default
#line hidden
#nullable disable
                , 121, 
#nullable restore
#line 93 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                              vacunado.Vacuna2Id

#line default
#line hidden
#nullable disable
                , 122, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna2Id = __value, vacunado.Vacuna2Id)), 123, () => vacunado.Vacuna2Id, 124, (__builder3) => {
                    __builder3.AddMarkupContent(125, "<option value>N/A</option>");
#nullable restore
#line 96 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                     foreach (var v in vc.Vacunas)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(126, "option");
                    __builder3.AddAttribute(127, "value", 
#nullable restore
#line 98 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                        v.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(128, 
#nullable restore
#line 98 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                               v.Marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 99 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n            ");
                __builder2.AddMarkupContent(130, "<tr><td>Latitud</td>\r\n                <td><input type=\"text\" class=\"form-control\"></td>\r\n                <td></td></tr>\r\n            ");
                __builder2.AddMarkupContent(131, "<tr><td>Longitud</td>\r\n                <td><input type=\"text\" class=\"form-control\"></td>\r\n                <td></td></tr>\r\n            ");
                __builder2.OpenElement(132, "tr");
                __builder2.OpenElement(133, "td");
                __builder2.AddMarkupContent(134, "<button type=\"submit\" class=\"btn btn-success\">Guardar</button>");
#nullable restore
#line 116 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                     if (existente)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                                      borrarVacunado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "class", "btn btn-warning mx-1");
                __builder2.AddContent(138, "Borrar");
                __builder2.CloseElement();
#nullable restore
#line 119 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                <td></td>\r\n                <td></td>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 126 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
       
    private string cedulaInput = "";
    private string cedula = "";
    private Vacunado vacunado = null;
    private bool existente = false;

    private string error = "";

    private void parseaCedula()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
                         

        cedula = cedulaInput.Replace("-", "").Replace(" ", "");

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
            vacunado = vc.Vacunados.Where(x => x.Cedula == cedula).First();
            existente = true;
            error = "";
        }
        catch (InvalidOperationException)
        {
            buscaEnApi();
        }
    }

    private async void buscaEnApi()
    {
        string url = $"https://api.adamix.net/apec/cedula/{cedula}";
        try
        {
            CedulaInfo datos = await http.GetJsonAsync<CedulaInfo>(url);
            reemplazarDatos(datos);
        }
        catch
        {
            vacunado = new Vacunado();
        }

        error = "";
        StateHasChanged();
    }

    private void reemplazarDatos(CedulaInfo datos)
    {
        string nombre = datos.Nombres;
        string apellido = datos.Apellido1 + " " + datos.Apellido2;
        DateTime fechaNacimiento = Convert.ToDateTime(datos.FechaNacimiento);

        vacunado = new Vacunado
        {
            Cedula = cedula,
            Nombre = nombre,
            Apellido = apellido,
        };
    }

    private void vacunadoValido()
    {
        if (!existente)
        {
            vc.Add(vacunado);
            existente = true;
        }
        vc.SaveChanges();
    }

    private void borrarVacunado()
    {
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
namespace __Blazor.Tarea7.Pages.RegistrarVacunado
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
