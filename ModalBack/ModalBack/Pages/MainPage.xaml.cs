using MauiModalAndroidBackReproduction.Models;
using MauiModalAndroidBackReproduction.PageModels;

namespace MauiModalAndroidBackReproduction.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}