#pragma checksum "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e50a03e4b200d2eb3dbfa5b6563f01c3bbb97ee"
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
            __builder.AddMarkupContent(0, "<h3>Registrar Vacunado</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group");
            __builder.AddMarkupContent(3, "<label for=\"cedula\" class=\"input-group-text\">Cedula</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "cedula");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
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
#line 12 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
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
#line 16 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
 if (error != "") {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "h4");
            __builder.AddAttribute(19, "class", "text-danger");
            __builder.AddContent(20, 
#nullable restore
#line 17 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                             error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
} else if (vacunado != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                     vacunado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                              vacunadoValido

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "input-group mb-1");
                __builder2.AddMarkupContent(31, "<label class=\"input-group-text\">Cedula:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        vacunado.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Cedula = __value, vacunado.Cedula))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Cedula));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "input-group mb-1");
                __builder2.AddMarkupContent(40, "<label class=\"input-group-text\">Nombres:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        vacunado.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Nombre = __value, vacunado.Nombre))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "input-group mb-1");
                __builder2.AddMarkupContent(49, "<label class=\"input-group-text\">Apellidos:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        vacunado.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Apellido = __value, vacunado.Apellido))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Apellido));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "input-group mb-1");
                __builder2.AddMarkupContent(58, "<label class=\"input-group-text\">Telefono:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        vacunado.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Telefono = __value, vacunado.Telefono))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacunado.Telefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "input-group mb-1");
                __builder2.AddMarkupContent(67, "<label class=\"input-group-text\">Provincia:</label>\r\n                ");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputSelect_0(__builder2, 68, 69, "form-control", 70, 
#nullable restore
#line 40 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                          vacunado.ProvinciaId

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.ProvinciaId = __value, vacunado.ProvinciaId)), 72, () => vacunado.ProvinciaId, 73, (__builder3) => {
#nullable restore
#line 42 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                     foreach (var p in vc.Provincias)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 44 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        p.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, 
#nullable restore
#line 44 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                               p.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 45 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "input-group mb-1");
                __builder2.AddMarkupContent(80, "<label class=\"input-group-text\">Vacuna #1:</label>\r\n                ");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputDate_1(__builder2, 81, 82, "form-control", 83, 
#nullable restore
#line 50 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        vacunado.Vacuna1Fecha

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna1Fecha = __value, vacunado.Vacuna1Fecha)), 85, () => vacunado.Vacuna1Fecha);
                __builder2.AddMarkupContent(86, "\r\n                ");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputSelect_2(__builder2, 87, 88, "form-control", 89, 
#nullable restore
#line 51 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                          vacunado.Vacuna1Id

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna1Id = __value, vacunado.Vacuna1Id)), 91, () => vacunado.Vacuna1Id, 92, (__builder3) => {
                    __builder3.AddMarkupContent(93, "<option value>N/A</option>");
#nullable restore
#line 53 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                     foreach (var v in vc.Vacunas)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(94, "option");
                    __builder3.AddAttribute(95, "value", 
#nullable restore
#line 55 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        v.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(96, 
#nullable restore
#line 55 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                               v.Marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 56 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "input-group mb-1");
                __builder2.AddMarkupContent(100, "<label class=\"input-group-text\">Vacuna #2:</label>\r\n                ");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputDate_3(__builder2, 101, 102, "form-control", 103, 
#nullable restore
#line 61 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                                                                                !vacunado.Vacuna1Id.HasValue

#line default
#line hidden
#nullable disable
                , 104, 
#nullable restore
#line 61 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        vacunado.Vacuna2Fecha

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna2Fecha = __value, vacunado.Vacuna2Fecha)), 106, () => vacunado.Vacuna2Fecha);
                __builder2.AddMarkupContent(107, "\r\n                ");
                __Blazor.Tarea7.Pages.RegistrarVacunado.TypeInference.CreateInputSelect_4(__builder2, 108, 109, "form-control", 110, 
#nullable restore
#line 62 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                                                                                !vacunado.Vacuna1Id.HasValue

#line default
#line hidden
#nullable disable
                , 111, 
#nullable restore
#line 62 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                          vacunado.Vacuna2Id

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacunado.Vacuna2Id = __value, vacunado.Vacuna2Id)), 113, () => vacunado.Vacuna2Id, 114, (__builder3) => {
                    __builder3.AddMarkupContent(115, "<option value>N/A</option>");
#nullable restore
#line 64 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                     foreach (var v in vc.Vacunas)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(116, "option");
                    __builder3.AddAttribute(117, "value", 
#nullable restore
#line 66 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                        v.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(118, 
#nullable restore
#line 66 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                               v.Marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 67 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "input-group mb-1");
                __builder2.AddMarkupContent(122, "<button type=\"submit\" class=\"btn btn-success mx-1\">Guardar</button>");
#nullable restore
#line 74 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                 if (existente) {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(123, "button");
                __builder2.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                                      borrarVacunado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "class", "btn btn-warning mx-1");
                __builder2.AddContent(126, "Borrar");
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 80 "C:\Users\admin\Desktop\ITLA\Programacion 3\Tarea 7\Tarea7\Pages\RegistrarVacunado.razor"
}

#line default
#line hidden
#nullable disable
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
        DateTime fechaNacimiento = Convert.ToDateTime(datos.FechaNacimiento);

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
