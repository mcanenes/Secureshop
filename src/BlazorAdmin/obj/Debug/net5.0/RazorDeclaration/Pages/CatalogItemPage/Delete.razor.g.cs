// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAdmin.Pages.CatalogItemPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Models;

#line default
#line hidden
#nullable disable
    public partial class Delete : BlazorAdmin.Helpers.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\mcanenes\Source\Repos\eShopOnWeb1\src\BlazorAdmin\Pages\CatalogItemPage\Delete.razor"
       
    [Parameter]
    public IEnumerable<CatalogBrand> Brands { get; set; }
    [Parameter]
    public IEnumerable<CatalogType> Types { get; set; }

    [Parameter]
    public EventCallback<string> OnSaveClick { get; set; }

    private bool HasPicture => !string.IsNullOrEmpty(_item.PictureUri);
    private string _modalDisplay = "none;";
    private string _modalClass = "";
    private bool _showDeleteModal = false;
    private CatalogItem _item = new CatalogItem();

    private async Task DeleteClick(int id)
    {
        // TODO: Add some kind of "are you sure" check before this

        await CatalogItemService.Delete(id);

        await OnSaveClick.InvokeAsync(null);
        await Close();
    }

    public async Task Open(int id)
    {
        Logger.LogInformation("Now loading... /Catalog/Delete/{Id}", id);

        await new Css(JSRuntime).HideBodyOverflow();

        _item = await CatalogItemService.GetById(id);

        _modalDisplay = "block;";
        _modalClass = "Show";
        _showDeleteModal = true;

        StateHasChanged();
    }

    private async Task Close()
    {
        await new Css(JSRuntime).ShowBodyOverflow();
        _modalDisplay = "none";
        _modalClass = "";
        _showDeleteModal = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICatalogItemService CatalogItemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Delete> Logger { get; set; }
    }
}
#pragma warning restore 1591
