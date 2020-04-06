using MvvmListviewEx.Model;
using MvvmListviewEx.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvvmListviewEx.ViewModel
{
  public  class PersonsListViewModel
    {
       private INavigation navi;
        public PersonsListViewModel(INavigation navi)
        {
            this.navi = navi;
            bindPersonsListData();

            
        }


        private List<Person> _PersonsList;
        public List<Person> PersonsList
        {
            set
            {
                _PersonsList = value;
            }
            get
            {
                return _PersonsList;
            }
        }

        private Person _personItem;
        public Person personItem
        {
            set
            {
                _personItem = value;

                navi.PushAsync(new PersonDetailsPage(_personItem));




            }
            get
            {
                return _personItem;
            }
        }

        private void bindPersonsListData()
        {
            _PersonsList = new List<Person>();
            _PersonsList.Add(new Person {PId=100, PName = "Akshay", PAddres = "Sangareddy" });
            _PersonsList.Add(new Person { PId = 101, PName = "Santhosh", PAddres = "Vizag" });
            _PersonsList.Add(new Person { PId = 102, PName = "Saroop", PAddres = "Kolluru" });
            _PersonsList.Add(new Person { PId = 103, PName = "Vijay ", PAddres = "Vijayvada" });



            _PersonsList.Add(new Person { PId = 100, PName = "Akshay", PAddres = "Sangareddy" });
            _PersonsList.Add(new Person { PId = 101, PName = "Santhosh", PAddres = "Vizag" });
            _PersonsList.Add(new Person { PId = 102, PName = "Saroop", PAddres = "Kolluru" });
            _PersonsList.Add(new Person { PId = 103, PName = "Vijay ", PAddres = "Vijayvada" });

            _PersonsList.Add(new Person { PId = 100, PName = "Akshay", PAddres = "Sangareddy" });
            _PersonsList.Add(new Person { PId = 101, PName = "Santhosh", PAddres = "Vizag" });
            _PersonsList.Add(new Person { PId = 102, PName = "Saroop", PAddres = "Kolluru" });
            _PersonsList.Add(new Person { PId = 103, PName = "Vijay ", PAddres = "Vijayvada" });

        }
    }
}
