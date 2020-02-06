using System;
using System.Collections.Generic;
using System.Windows.Input;
using Clase1.Interfaces;
using Clase1.ViewModels;
using Xamarin.Forms;

namespace Clase1
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            DependencyService.Get<ITextToSpeech>().Speak("Aguante Xamarin");

            command = new Command(async() =>
            {
                await Navigation.PushAsync(new PiedraPapelTijera());
            });

            ((LoginViewModel)this.BindingContext).ComandoNavegar = command;
        }

        ICommand command;
    }
}
