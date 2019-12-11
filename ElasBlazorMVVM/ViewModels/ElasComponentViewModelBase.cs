using ElasBlazorMVVM.Abstractions.ViewModels;
using System.Threading.Tasks;

namespace ElasBlazorMVVM.ViewModels
{
    public abstract class ElasComponentViewModelBase : IElasComponentViewModelBase
    {
        public virtual Task OnAfterRenderAsync(bool firstRender)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnInitializedAsync()
        {
            return Task.CompletedTask;
        }

        public virtual Task OnParametersSetAsync()
        {
            return Task.CompletedTask;
        }
    }
}
