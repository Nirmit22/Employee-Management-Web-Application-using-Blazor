#pragma checksum "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3396e2e6db3990cae7f3cde62f8b7214b40fe4b4"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\_Imports.razor"
using NirmitLibrary1;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h3");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "checkbox");
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                               CheckBoxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 10 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
     if (ShowFooter) 
    { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-footer text-center");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 15 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"employeedetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-primary m-1");
            __builder.AddContent(30, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 16 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-primary m-1");
            __builder.AddContent(35, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "#");
            __builder.AddAttribute(39, "class", "btn btn-danger m-1");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                             Delete_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 20 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenComponent<NirmitLibrary1.Confirm>(45);
            __builder.AddAttribute(46, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 23 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                              Confirm_DeleteClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(47, (__value) => {
#nullable restore
#line 23 "C:\Users\nirmi\source\repos\BlazorProject1\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                         DeleteConfirmation = (NirmitLibrary1.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
