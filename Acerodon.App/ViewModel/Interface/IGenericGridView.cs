using System.Collections.Generic;

namespace Acerodon.App.ViewModel.Interface
{
    public interface IGenericGridViewModel<T> : IGridViewModel
    {
        List<T> Items { get; }                   

    }
}
