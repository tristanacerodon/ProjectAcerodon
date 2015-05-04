﻿using Acerodon.App.AcerodonService;
using Acerodon.App.Helper;
using Acerodon.GenericDataContract.Types;
using Acerodon.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Acerodon.App.ViewModel.Interface
{
    public abstract class GridViewModel<T> : IGridViewModel
    {
               
        private DataServiceClient _service = new DataServiceClient();
        private Window _window;
        private List<T> _items = new List<T>();
        private int _page = 1;
        private int _rows = 10;
        private int _pages = 0;


        public DataServiceClient Service
        {
            get
            {
                return _service;
            }
        }
        public Window Window
        {
            get
            {
                return _window;
            }
            set
            {
                _window = value;
                _window.Refresh();
            }

        }
        public List<T> Items
        {
            get
            {
                return _items;
            }
        }
        public int Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
                Window.Refresh();

            }
        }
        public int Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                _rows = value;
                Refresh();

            }
        }
        public int Pages
        {
            get
            {
                return _pages;
            }
        }

        public Window EntryForm { get; set; }

        public ICommand NextCommand { get { return new Command(Next); } }
        public ICommand BackCommand { get { return new Command(Back); } }
        public ICommand FirstCommand { get { return new Command(First); } }
        public ICommand LastCommand { get { return new Command(Last); } }
        public ICommand AddCommand { get { return new Command(Add); } }
        public ICommand EditCommand { get { return new Command(Edit); } }
        public ICommand DeleteCommand { get { return new Command(Delete); } }
        public ICommand RefreshCommand { get { return new Command(Refresh); } }

        private void Back()
        {
            Page--;
        }
        private void Next()
        {
            Page++;
        }
        private void First()
        {
            Page = 1;
        }
        private void Last()
        {
            Page = Pages;
        }
        private void Add()
        {
            throw new NotImplementedException();
        }
        private void Edit()
        {
            throw new NotImplementedException();
        }
        private void Delete()
        {
            throw new NotImplementedException();
        }
        private void Refresh()
        {
            Query query = new Query();
            query.Page = Page;
            query.Rows = Rows;
            _items.Clear();
            _items.AddRange( Get(query) );
        }

        private T[] Get(Query query)
        {
            
            AcerodonDataContract datacontract = AcerodonDataContract.Create<T>();
            datacontract = Service.Get(datacontract, query);
            return datacontract.GetList<T>();

        }
    }
}
