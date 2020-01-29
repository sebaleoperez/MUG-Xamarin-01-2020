using System;
using System.Collections.Generic;
using Clase1.Services;
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

            StarWarsService service = new StarWarsService();

            listviewPersonajes.ItemsSource = await service.GetPeoplesAsync();
        }
    }
}
