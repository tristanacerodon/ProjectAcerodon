namespace Acerodon.App.ViewModel.Interface
{
    public interface IGridViewModel
    {
        int Page { get; set; }
        int Rows { get; set; }
        int Pages { get; }
        
        void Back();
        void Next();
        
        void First();
        void Last();
                
        void Add();
        void Edit();
        void Delete();

        void Refresh();
    }
}
