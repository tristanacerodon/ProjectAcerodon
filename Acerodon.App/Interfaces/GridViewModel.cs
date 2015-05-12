using Acerodon.App.AcerodonService;
using Acerodon.App.Areas.Helper;
using Acerodon.App.Helper;
using Acerodon.GenericDataContract.Types;
using Acerodon.Model;
using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Linq;

namespace Acerodon.App.Interfaces {
    public class GridViewModel<T> : IGridViewModel
        where T : IEntity , new() {

        private DataServiceClient _service = new DataServiceClient();
        private ListForm _listForm;
        private List<T> _items = new List<T>();
        private int _page = 1;
        private int _rows = 10;
        private int _pages = 0;
        private Func<T , object> predicate;

        public GridViewModel(Func<T , object> predicate) {
            this.predicate = predicate;
        }


        public DataServiceClient Service {
            get {
                return _service;
            }
        }
        public ListForm ListForm {
            get {
                return _listForm;
            }
            set {
                _listForm = value;
                Refresh();
            }

        }
        public List<T> Items {
            get {
                return _items;
            }
        }
        public int Page {
            get {
                return _page;
            }
            set {

                _page = value < 1 ? 1 : value;
                Refresh();

            }
        }
        public int Rows {
            get {
                return _rows;
            }
            set {
                _rows = value;
                Refresh();

            }
        }
        public int Pages {
            get {
                return _pages;
            }
        }

        public ICommand NextCommand { get { return new Command(Next); } }
        public ICommand BackCommand { get { return new Command(Back); } }
        public ICommand FirstCommand { get { return new Command(First); } }
        public ICommand LastCommand { get { return new Command(Last); } }
        public ICommand AddCommand { get { return new Command(Add); } }
        public ICommand EditCommand { get { return new Command(Edit); } }
        public ICommand DeleteCommand { get { return new Command(Delete); } }
        public ICommand RefreshCommand { get { return new Command(Refresh); } }

        private void Back() {
            Page--;
        }
        private void Next() {
            Page++;
        }
        private void First() {
            Page = 1;
        }
        private void Last() {
            Page = Pages;
        }
        private void Add() {

            var entry = new T();
            if (GenericEntryForm.Create(entry, predicate).ShowDialog() == true) {
                Items.Add(entry);
                ResetBindings();
            }

        }
        private void Edit() {
            if (_listForm.lstItems.SelectedItem != null)
                if (GenericEntryForm.Create((T)_listForm.lstItems.SelectedItem, predicate).ShowDialog() == true) {

                }

        }
        private void Delete() {
            if (_listForm.lstItems.SelectedItem != null)
                if (MessageBox.Show("Delete Selected Item?" , "Delete" , MessageBoxButton.YesNo) == MessageBoxResult.Yes) {
                    Items.Remove((T)_listForm.lstItems.SelectedItem);
                    ResetBindings();
                }
        }
        private void Refresh() {
            Query query = new Query();
            query.Page = Page;
            query.Rows = Rows;
            _items.Clear();

            
            T[] items = Get(query);

            var selproperties = predicate(new T()).GetType().GetProperties();
            var virtualproperties = typeof(T).GetProperties().Where(p => p.GetMethod.IsVirtual);

            var displayproperties = virtualproperties.Where(o => selproperties.Where(p => p.Name.StartsWith(o.Name)).Any());


            foreach(T item in items)
            {
                foreach(var prop in displayproperties)
                {
                    Guid id = (Guid)typeof(T).GetProperty(prop.Name + "Id").GetValue(item);
                    
                    var value = _service.GetItem(ItemDataContract.Create(prop.PropertyType),id).Get();                     

                    typeof(T).GetProperty(prop.Name).SetValue(item,value);

                }
            }

            _items.AddRange(items);            

            ResetBindings();

        }

        private void ResetBindings() {
            _listForm.DataContext = null;
            _listForm.DataContext = this;

            _listForm.lstItems.SelectedItem = null;

        }

        private T[] Get(Query query) {

            ListDataContract datacontract = ListDataContract.Create<T>();
            datacontract = Service.GetList(datacontract , query);
            return datacontract.GetList<T>();

        }
    }
}
