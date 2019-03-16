using System;
using Xamarin.Forms;

namespace DayTwo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            btnSave.IsEnabled = false;
            entContent.Text = string.Empty;
            entTitle.Text = string.Empty;
        }

        private void CheckIfShouldBeEnableButtonSave()
        {
            btnSave.IsEnabled = false;
            if (!string.IsNullOrWhiteSpace(entTitle.Text) && !string.IsNullOrWhiteSpace(entContent.Text))
            {
                btnSave.IsEnabled = true;
            }
            else
            {
                DisplayAlert("Error", "Title and Content entries can not be empty", "OK");
            }
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            btnSave.IsEnabled = false;
            entContent.Text = string.Empty;
            entTitle.Text = string.Empty;
        }

        private void EntTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfShouldBeEnableButtonSave();
        }

        private void EntContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfShouldBeEnableButtonSave();
        }
    }
}