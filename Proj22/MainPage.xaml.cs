using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proj22
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
     
        }

        void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //_ = string.IsNullOrEmpty(emailEntry.Text);
            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);

            //_ = string.IsNullOrEmpty(passwordEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty || isPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }


        }
    }
}
