using System;
using System.Collections.Generic;
using Clase1.Services;
using Clase1.ViewModels;
using Xamarin.Forms;

namespace Clase1
{
    public partial class ListadoPersonajes : ContentPage
    {
        public ListadoPersonajes()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await ((ListadoPersonajesViewModel)this.BindingContext).CargarPersonajes();
        }

        void listviewPersonajes_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetallePersonaje((People)e.Item));
        }
    }
}
