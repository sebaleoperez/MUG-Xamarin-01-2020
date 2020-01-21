using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListaDeNumeros();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
