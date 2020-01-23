using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1.EjemplosNavegacion
{
    public partial class Blanco : ContentPage
    {
        public Blanco()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Gris());
        }
    }
}
