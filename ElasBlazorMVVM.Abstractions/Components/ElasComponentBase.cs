using ElasBlazorMVVM.Abstractions.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ElasBlazorMVVM.Abstractions.Components
{
    public abstract class ElasComponentBase<TModel> : ComponentBase where TModel : IElasComponentViewModelBase
    {
        [Inject]
        public TModel Model { get; protected set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Model != null)
            {
                await Model.OnAfterRenderAsync(firstRender);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            if (Model != null)
            {
                await Model.OnInitializedAsync();
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            if (Model != null)
            {
                await Model.OnParametersSetAsync();
            }
        }

    }
}
