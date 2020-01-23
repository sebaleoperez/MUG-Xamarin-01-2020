using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1.EjemplosNavegacion
{
    public partial class MenuLateral : ContentPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "Blanco")
            {
                App.MenuPrincipal.Detail = new Blanco();
            }
            else if (button.Text == "Gris")
            {
                App.MenuPrincipal.Detail = new Gris();
            }
            else
            {
                App.MenuPrincipal.Detail = new Negro();
            }

            App.MenuPrincipal.IsPresented = false;
        }
    }
}
