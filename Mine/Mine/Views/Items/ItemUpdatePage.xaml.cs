using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Mine.ViewModels;
using Xamarin.Forms.Xaml;

using Mine.Models;

namespace Mine.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemUpdatePage : ContentPage
    {
        public ItemModel Item { get; set; }

        public ItemUpdatePage()
        {
            InitializeComponent();

            Item = new ItemModel
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        /// <summary>
        /// Constructor that takes a viewModel
        /// </summary>
        /// <param name="viewModel"></param>
        public ItemUpdatePage(ItemReadViewModel viewModel)
        {
            InitializeComponent();

            Item = viewModel.Item;
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "UpdateItem", Item);
            await Navigation.PopModalAsync();
        }


        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// Update the display value when the stepper changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void value_OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            ValueValue.Text = string.Format("{0}", e.NewValue);
        }

    }
}