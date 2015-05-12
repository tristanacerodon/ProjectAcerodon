using Acerodon.App.AcerodonService;
using Acerodon.App.Interfaces;
using Acerodon.GenericDataContract.Types;
using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Acerodon.App.Helper {

    class GenericListForm<T> : ListForm
        where T : IEntity , new() {

        public GridViewModel<T> ViewModel { get; set; }

        public List<GridViewColumn> Columns { get; set; }


        public GenericListForm(Func<T , object> predicate) {
            InitializeComponent();
            Columns = new List<GridViewColumn>();
            ViewModel = new GridViewModel<T>(predicate);

            var properties = predicate(new T()).GetType().GetProperties();
            var virtualproperties = typeof(T).GetProperties().Where(p => p.GetMethod.IsVirtual);
            //clear combobox filter
            cboFilterName.Items.Clear();
            foreach (var property in properties) {

                TypeCode typeCode = Type.GetTypeCode(property.PropertyType);
                if (typeCode == TypeCode.Object && property.Name != "Id") {
                    if (property.PropertyType == typeof(Guid)) {
                        var vproperties = virtualproperties.Where(o => property.Name.StartsWith(o.PropertyType.Name));
                        if (vproperties.Count() == 0)
                            continue;

                        var vproperty = vproperties.First();

                        DataServiceClient service = new DataServiceClient();

                        ItemDataContract datacontract = ItemDataContract.Create(vproperty.PropertyType);
                        //datacontract = service.GetItem(datacontract, query);
                        //dynamic[] items = datacontract.Get();
                    }
                } else {

                }
                GridViewColumn column = new GridViewColumn() {
                    Header = property.Name ,
                    DisplayMemberBinding = new Binding(property.Name)
                };

               
                cboFilterName.Items.Add(property.Name);

                Columns.Add(column);
                grdItems.Columns.Add(column);

            }
            //assign selected value
            cboFilterName.SelectedIndex = 0;
            BindControls();

            DataContext = ViewModel;
            ViewModel.ListForm = this;
        }

        private void BindControls() {

            lstItems.SetBinding(ListView.ItemsSourceProperty ,
                new Binding {
                    Path = new PropertyPath("Items") ,
                    NotifyOnTargetUpdated = true
                });

            txtPage.SetBinding(TextBox.TextProperty ,
                new Binding {
                    Path = new PropertyPath("Page") ,
                    NotifyOnTargetUpdated = true
                });

            txtPages.SetBinding(Label.ContentProperty ,
                new Binding {
                    Path = new PropertyPath("Pages") ,
                    NotifyOnTargetUpdated = true
                });

            btnFirst.Command = ViewModel.FirstCommand;
            btnLast.Command = ViewModel.LastCommand;

            btnBack.Command = ViewModel.BackCommand;
            btnNext.Command = ViewModel.NextCommand;

            btnAdd.Command = ViewModel.AddCommand;
            btnEdit.Command = ViewModel.EditCommand;

            btnDelete.Command = ViewModel.DeleteCommand;

            btnRefresh.Command = ViewModel.RefreshCommand;
        }


    }
}
