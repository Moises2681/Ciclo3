#pragma checksum "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455115ec645df31e3f8870b01bf37496cddb1e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AlquilerAutos.App.Presentacion.Pages.Usuarios.Pages_Usuarios_Details), @"mvc.1.0.razor-page", @"/Pages/Usuarios/Details.cshtml")]
namespace AlquilerAutos.App.Presentacion.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\_ViewImports.cshtml"
using AlquilerAutos.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455115ec645df31e3f8870b01bf37496cddb1e0a", @"/Pages/Usuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c9fb73b7847ac71c5444416de6ebfea3696c56", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Usuarios_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Datos Detallados de Usuario ");
#nullable restore
#line 6 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
                           Write(Model.usuario.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
                                                 Write(Model.usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
                                                                       Write(Model.usuario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
                                                                                               Write(Model.usuario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
                                                                                                                        Write(Model.usuario.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
                                                                                                                                                Write(Model.usuario.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<div>\n    ID: ");
#nullable restore
#line 8 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
   Write(Model.usuario.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    CEDULA: ");
#nullable restore
#line 11 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
       Write(Model.usuario.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    NOMBRES: ");
#nullable restore
#line 14 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
        Write(Model.usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    APELLIDOS: ");
#nullable restore
#line 17 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
          Write(Model.usuario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    DIRECCIÓN: ");
#nullable restore
#line 20 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
          Write(Model.usuario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    TELEFONO: ");
#nullable restore
#line 23 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
         Write(Model.usuario.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    CORREO: ");
#nullable restore
#line 26 "D:\Ciclo3\ProyectoAlquilerAutos\AlquilerAutos.App\AlquilerAutos.App.Presentacion\Pages\Usuarios\Details.cshtml"
       Write(Model.usuario.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455115ec645df31e3f8870b01bf37496cddb1e0a7800", async() => {
                WriteLiteral("Volver a la Lista de usuarios.. ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlquilerAutos.App.Presentacion.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AlquilerAutos.App.Presentacion.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AlquilerAutos.App.Presentacion.Pages.DetailsModel>)PageContext?.ViewData;
        public AlquilerAutos.App.Presentacion.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
