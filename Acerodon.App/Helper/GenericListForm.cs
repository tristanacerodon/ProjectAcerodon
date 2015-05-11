using Acerodon.App.Interfaces;
using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Acerodon.App.Helper
{
    
    class GenericListForm<T> : ListForm
        where T : IEntity, new()
    {

        public GridViewModel<T> ViewModel { get; set; }

        public List<GridViewColumn> Columns { get; set; }
        public GenericListForm()
        {

            InitializeComponent();

            Columns = new List<GridViewColumn>();
            ViewModel = new GridViewModel<T>();

            lstItems.SetBinding(ListView.ItemsSourceProperty,
                new Binding
                      {
                          Path = new PropertyPath("Items"),
                          NotifyOnTargetUpdated = true
                      });

            txtPage.SetBinding(TextBox.TextProperty,
                new Binding
                      {
                          Path = new PropertyPath("Page"),
                          NotifyOnTargetUpdated = true
                      });

            txtPages.SetBinding(Label.ContentProperty,
                new Binding
                {
                    Path = new PropertyPath("Pages"),
                    NotifyOnTargetUpdated = true
                });


            var properties = typeof(T).GetProperties().Where(p => !p.GetMethod.IsVirtual);
            foreach (var property in properties)
            {
                GridViewColumn column = new GridViewColumn()
                     {
                         Header = property.Name,
                         DisplayMemberBinding = new Binding(property.Name)
                     };

                Columns.Add(column);
                grdItems.Columns.Add(column);

            }

            btnFirst.Command = ViewModel.FirstCommand;
            btnLast.Command = ViewModel.LastCommand;

            btnBack.Command = ViewModel.BackCommand;
            btnNext.Command = ViewModel.NextCommand;
            
            btnAdd.Command = ViewModel.AddCommand;
            btnEdit.Command = ViewModel.EditCommand;

            btnDelete.Command = ViewModel.DeleteCommand;

            btnRefresh.Command = ViewModel.RefreshCommand;

            DataContext = ViewModel;
            ViewModel.ListForm = this;
        }


    }
}
