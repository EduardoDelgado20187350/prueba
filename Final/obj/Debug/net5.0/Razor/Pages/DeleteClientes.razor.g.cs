#pragma checksum "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f01f83e34a3d5ec2a8731d0748fc71542f09cae"
// <auto-generated/>
#pragma warning disable 1591
namespace Final.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Glacira\Source\Repos\Final\Final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteClientes/{CurrentID}")]
    public partial class DeleteClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Eliminar Cliente</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Estas seguro que quieres borrar esto?</h3>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-4");
            __builder.AddMarkupContent(6, "<label>Cliente ID:</label>\r\n        ");
            __builder.OpenElement(7, "label");
            __builder.AddContent(8, 
#nullable restore
#line 12 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Cliente_Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group col-md-4");
            __builder.AddMarkupContent(12, "<label>RNC:</label>\r\n        ");
            __builder.OpenElement(13, "label");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.RNC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group col-md-4");
            __builder.AddMarkupContent(18, "<label>Nombre:</label>\r\n        ");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, 
#nullable restore
#line 20 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group col-md-4");
            __builder.AddMarkupContent(24, "<label>Direccion:</label>\r\n        ");
            __builder.OpenElement(25, "label");
            __builder.AddContent(26, 
#nullable restore
#line 24 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group col-md-4");
            __builder.AddMarkupContent(30, "<label>Latitud:</label>\r\n        ");
            __builder.OpenElement(31, "label");
            __builder.AddContent(32, 
#nullable restore
#line 28 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Latitud

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group col-md-4");
            __builder.AddMarkupContent(36, "<label>Longitud:</label>\r\n        ");
            __builder.OpenElement(37, "label");
            __builder.AddContent(38, 
#nullable restore
#line 32 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Longitud

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group col-md-4");
            __builder.AddMarkupContent(42, "<label>Correo:</label>\r\n        ");
            __builder.OpenElement(43, "label");
            __builder.AddContent(44, 
#nullable restore
#line 36 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group col-md-4");
            __builder.AddMarkupContent(48, "<label>Fecha:</label>\r\n        ");
            __builder.OpenElement(49, "label");
            __builder.AddContent(50, 
#nullable restore
#line 40 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                cliente.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "row");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-md-4");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                                                                    BorrarCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-danger");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
                                                                   Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Glacira\Source\Repos\Final\Final\Pages\DeleteClientes.razor"
        [Parameter]
    public string CurrentID { get; set; }
    ClienteFinal cliente = new ClienteFinal();


    protected override async Task OnInitializedAsync()
    {
        cliente = await Task.Run(() => Service.GetClienteById(Convert.ToInt32(CurrentID)));

    }

    protected void BorrarCliente()
    {
        Service.DeleteCliente(cliente);
        NavigationManager.NavigateTo("ClienteInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("ClienteInfo");

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService Service { get; set; }
    }
}
#pragma warning restore 1591
