using System.Threading.Tasks;

namespace ElasBlazorMVVM.Abstractions.ViewModels
{
    public interface IElasComponentViewModelBase
    {
        Task OnAfterRenderAsync(bool firstRender);

        Task OnInitializedAsync();

        Task OnParametersSetAsync();
    }
}
