﻿using MvvmListviewEx.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmListviewEx.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonsList : ContentPage
    {
        public PersonsList()
        {
            InitializeComponent();

            BindingContext = new PersonsListViewModel(Navigation);
        }
    }
}