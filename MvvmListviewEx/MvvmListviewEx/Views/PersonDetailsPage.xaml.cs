﻿using MvvmListviewEx.Model;
using MvvmListviewEx.ViewModel;
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
    public partial class PersonDetailsPage : ContentPage
    {
        public PersonDetailsPage(Person personItem)
        {
            InitializeComponent();

            BindingContext = new PersonDetailsPageViewModel(personItem);
        }
    }
}