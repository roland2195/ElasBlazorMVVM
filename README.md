# ElasBlazorMVVM

# ElasComponentBase Usage
- Add @using ElasBlazorMVVM.Abstractions.Components to _Imports.razor
- Add @inherits ElasComponentBase<ElasComponentViewModel> to your custom razor components
- Access "Model" property directly in your custom razor components
  
# ElasComponentViewModelBase Usage
- Create your custom ViewModel then inherit from IElasComponentViewModelBase
- FYI - You can inherit from ElasComponentViewModelBase class.
  
