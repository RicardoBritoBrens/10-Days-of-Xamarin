using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DayOne
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnShowMessage_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entUserInput.Text))
            {
                btnShowMessage.Text = $"Hello {entUserInput.Text}, welcome to 10 Days of Xamarin";
            }
            else
            {
                DisplayAlert("Error", "Your name can't be empty", "Oh right");
            }
        }
    }
}
