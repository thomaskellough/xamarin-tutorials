using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            viewModel.NoteHeading = "XXXXXXX";
            DisplayAlert("Cancel option",
                "Heading value is " + viewModel.Note.Heading,
                "Button 2", "Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option",
                "Save was clicked",
                "Button 2", "Button 1");
        }

    }
}