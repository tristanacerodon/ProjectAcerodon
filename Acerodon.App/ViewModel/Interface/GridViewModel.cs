using Acerodon.App.AcerodonService;
using System;
using System.Collections.Generic;

namespace Acerodon.App.ViewModel.Interface
{
    public abstract class GridViewModel<T> : IGenericGridViewModel<T>
    {
        private int _rows = 10;
        private int _page = 0;
        private int _pages = 0;

        public int Page
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
                Refresh();

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


        private List<T> _Items = new List<T>();
        public DataServiceClient service = new DataServiceClient();
        
        public GridViewModel()
        {
            Refresh();
        }

        public void Refresh()
        {
            _Items.Clear();
            _Items.AddRange(Get(Page, Rows));
        }

        public List<T> Items
        {
            get { return _Items; }           
        }
         
        public void Back()
        {
            Page--;
            Refresh();
        }

        public void Next()
        {
            Page++;
            Refresh();
        }

        public void First()
        {
            throw new NotImplementedException();
        }

        public void Last()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
        
        public abstract T[] Get(int page, int row);
      
    }
}
