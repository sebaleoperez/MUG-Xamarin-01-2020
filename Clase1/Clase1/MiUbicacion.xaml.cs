using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace Clase1
{
    public partial class MiUbicacion : ContentPage
    {
        public MiUbicacion()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Location location = await Geolocation.GetLocationAsync();

            await Map.OpenAsync(location);
        }
    }
}
