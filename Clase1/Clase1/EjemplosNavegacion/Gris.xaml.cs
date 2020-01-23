using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1.EjemplosNavegacion
{
    public partial class Gris : ContentPage
    {
        public Gris()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Negro());
        }

    }
}
