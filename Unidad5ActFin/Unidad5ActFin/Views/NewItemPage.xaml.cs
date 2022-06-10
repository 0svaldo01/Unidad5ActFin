using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unidad5ActFin.Models;
using Unidad5ActFin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unidad5ActFin.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}