// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    #pragma warning disable 8019
    using System;
    #pragma warning restore 8019
    #pragma warning disable 8019
    using System.Collections.Generic;
    #pragma warning restore 8019
    #pragma warning disable 8019
    using System.Linq;
    #pragma warning restore 8019
    #pragma warning disable 8019
    using System.Threading.Tasks;
    #pragma warning restore 8019
    #pragma warning disable 8019
    using Microsoft.AspNetCore.Components;
    #pragma warning restore 8019
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using static Test2.SomeComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
using Foo = Test3;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Test.MyComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "SomeComponent");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
