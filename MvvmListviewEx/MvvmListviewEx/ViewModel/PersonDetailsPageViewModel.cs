using MvvmListviewEx.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmListviewEx.ViewModel
{
  public  class PersonDetailsPageViewModel
    {
        public PersonDetailsPageViewModel(Person personItem)
        {
            _PageTitle = personItem.PName;
            _PersonName = personItem.PName + " - " + personItem.PId;
            _PersonAddress = personItem.PAddres;
        }

        private string _PageTitle;

        public string PageTitle
        {
            set
            {
                _PageTitle = value;
            }
            get
            {
                return _PageTitle;
            }
        }

        private string _PersonName;

        public string PersonName
        {
            set
            {
                _PersonName = value;
            }
            get
            {
                return _PersonName;
            }
        }

        private string _PersonAddress;

        public string PersonAddress
        {
            set
            {
                _PersonAddress = value;
            }
            get
            {
                return _PersonAddress;
            }
        }


    }
}
