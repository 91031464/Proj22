﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Proj22
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewMerchandiserPage());
        }
    }
}
