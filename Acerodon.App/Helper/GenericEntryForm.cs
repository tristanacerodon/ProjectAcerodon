using Acerodon.App.AcerodonService;
using Acerodon.Model;
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
using Acerodon.GenericDataContract.Types;

namespace Acerodon.App.Helper
{

    public static class GenericEntryForm
    {

        public static GenericEntryForm<T> Create<T>(T entry,Func<T , object> predicate)
           where T : IEntity, new()
        {
            return new GenericEntryForm<T>(entry , predicate);
        }

    }

    public class GenericEntryForm<T> : EntryForm
        where T : IEntity, new()
    {

        // public List<Control> controls = new List<Control>();

        public GenericEntryForm(T entry , Func<T , object> predicate)
        {
            DataContext = entry;
             
            var selProps = predicate(new T()).GetType().GetProperties(); 

            var properties = typeof(T).GetProperties().Where(p => selProps.Where(o => o.Name == p.Name).Any());
            var virtualproperties = typeof(T).GetProperties().Where(p => p.GetMethod.IsVirtual);

            int position = 10;

            foreach (var property in properties)
            {
                TypeCode typeCode = Type.GetTypeCode(property.PropertyType);
                if (typeCode == TypeCode.Object && property.Name != "Id")
                {
                    if (property.PropertyType != typeof(Guid))
                    {
                        var vproperties = virtualproperties.Where(o => property.Name.StartsWith(o.PropertyType.Name));
                        if (vproperties.Count() == 0) continue;

                        var vproperty = vproperties.First();

                        DataServiceClient service = new DataServiceClient();

                        ListDataContract datacontract = ListDataContract.Create(vproperty.PropertyType);

                        Query query = new Query();
                        query.Page = 1;
                        query.Rows = 10;

                        datacontract = service.GetList(datacontract, query);
                        dynamic[] items = datacontract.GetList();

                        Label label = new Label()
                        {
                            Content = vproperty.Name
                        };

                        ComboBox ctrl = new ComboBox();
                        ctrl.SetBinding(ComboBox.SelectedValueProperty,
                                            new Binding
                                            {
                                                Path = new PropertyPath(property.Name + "Id"),
                                                NotifyOnTargetUpdated = true
                                            });

                        ctrl.DisplayMemberPath = "Name";
                        ctrl.SelectedValuePath = "Id";
                        ctrl.IsEditable = true;
   
                        foreach (var item in items)
                        {
                            ctrl.Items.Add(item);
                        }

                        label.Margin = new Thickness(10, position, 0, 0);
                        label.VerticalAlignment = VerticalAlignment.Top;
                        label.HorizontalAlignment = HorizontalAlignment.Left;

                        ctrl.Margin = new Thickness(125, position + 5, 10, 0);
                        ctrl.VerticalAlignment = VerticalAlignment.Top;
                        ctrl.HorizontalAlignment = HorizontalAlignment.Stretch;

                        position += 25;

                        LayoutGrid.Children.Add(label);
                        LayoutGrid.Children.Add(ctrl);



                    }

                }
                else if (property.Name != "Id")
                {
                    Label label = new Label()
                    {
                        Content = property.Name
                    };

                    TextBox ctrl = new TextBox();
                    ctrl.SetBinding(TextBox.TextProperty,
                                        new Binding
                                        {
                                            Path = new PropertyPath(property.Name),
                                            NotifyOnTargetUpdated = true
                                        });

                    label.Margin = new Thickness(10, position, 0, 0);
                    label.VerticalAlignment = VerticalAlignment.Top;
                    label.HorizontalAlignment = HorizontalAlignment.Left;

                    ctrl.Margin = new Thickness(125, position + 5, 10, 0);
                    ctrl.VerticalAlignment = VerticalAlignment.Top;
                    ctrl.HorizontalAlignment = HorizontalAlignment.Stretch;

                    position += 25;

                    LayoutGrid.Children.Add(label);
                    LayoutGrid.Children.Add(ctrl);
                }
            }

            this.Height = position + 75;

        }

    }
}
