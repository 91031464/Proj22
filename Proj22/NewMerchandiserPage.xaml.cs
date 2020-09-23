using System;
using System.Collections.Generic;
using Proj22.Model;
using SQLite;
using Xamarin.Forms;

namespace Proj22
{
    public partial class NewMerchandiserPage : ContentPage
    {
        public NewMerchandiserPage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            int rows = conn.Insert(post);
            conn.Close();

            if (rows > 0)
                DisplayAlert("Sucess", "Experience sucessully insert", "OK");
            else
                DisplayAlert("Failure", "Experience failed", "OK");
        }
    }
}
