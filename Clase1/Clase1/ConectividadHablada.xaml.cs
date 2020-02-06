using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Clase1
{
    public partial class ConectividadHablada : ContentPage
    {
        public ConectividadHablada()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                await TextToSpeech.SpeakAsync("Estas conectado.");
            }
            else
            {
                await TextToSpeech.SpeakAsync("No estas conectado.");
            }
        }
    }
}
