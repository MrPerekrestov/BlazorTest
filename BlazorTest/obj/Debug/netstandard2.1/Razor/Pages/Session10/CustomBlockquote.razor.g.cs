#pragma checksum "D:\MyProgramms\BlazorTest\BlazorTest\Pages\Session10\CustomBlockquote.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5740a2bda1d462fcff53e44b6940be6d7898efe9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages.Session10
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyProgramms\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
    public partial class CustomBlockquote : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "blockquote");
            __builder.AddAttribute(7, "class", "blockquote");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "mb-0");
            __builder.AddContent(11, 
#nullable restore
#line 4 "D:\MyProgramms\BlazorTest\BlazorTest\Pages\Session10\CustomBlockquote.razor"
                             QuoteText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "footer");
            __builder.AddAttribute(14, "class", "blockquote-footer");
            __builder.AddContent(15, 
#nullable restore
#line 5 "D:\MyProgramms\BlazorTest\BlazorTest\Pages\Session10\CustomBlockquote.razor"
                                               AuthorName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "cite");
            __builder.AddAttribute(18, "title", 
#nullable restore
#line 5 "D:\MyProgramms\BlazorTest\BlazorTest\Pages\Session10\CustomBlockquote.razor"
                                                                        Category

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, 
#nullable restore
#line 5 "D:\MyProgramms\BlazorTest\BlazorTest\Pages\Session10\CustomBlockquote.razor"
                                                                                   Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\MyProgramms\BlazorTest\BlazorTest\Pages\Session10\CustomBlockquote.razor"
      
    [Parameter]
    public string QuoteText { get; set; }
    [Parameter]
    public string AuthorName { get; set; }
    [Parameter]
    public string Category { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
