#pragma checksum "F:\MyPrograms\BlazorTest\BlazorTest\Pages\Session12\OneWayBinding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddba27f71fb4ec80b0bde778282593778c693b65"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages.Session12
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\MyPrograms\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Session12/OneWayBinding")]
    public partial class OneWayBinding : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>OneWayBinding</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<label for=\"FullName\">FullName</label>\r\n    ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "FullName");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 5 "F:\MyPrograms\BlazorTest\BlazorTest\Pages\Session12\OneWayBinding.razor"
                                             FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<label for=\"Age\">FullName</label>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "id", "Age");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 10 "F:\MyPrograms\BlazorTest\BlazorTest\Pages\Session12\OneWayBinding.razor"
                                        Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "lead");
            __builder.AddContent(23, 
#nullable restore
#line 13 "F:\MyPrograms\BlazorTest\BlazorTest\Pages\Session12\OneWayBinding.razor"
                 FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, " <br> ");
            __builder.AddContent(25, 
#nullable restore
#line 13 "F:\MyPrograms\BlazorTest\BlazorTest\Pages\Session12\OneWayBinding.razor"
                                  Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "F:\MyPrograms\BlazorTest\BlazorTest\Pages\Session12\OneWayBinding.razor"
       
    private string FullName { get; set; } = "Bill Gates";
    private int Age { get; set; } = 60;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
