using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label nuevoLabel = new Label();
            nuevoLabel.Text = "Nuevo";

            MiStackLayout.Children.Add(nuevoLabel);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (EntryUsuario.Text == "usuario" && EntryClave.Text == "12345")
                DisplayAlert("Funciono", "Usuario Correcto", "OK");
            else
                DisplayAlert("No Funciono", "Usuario Incorrecto", "OK");
        }


    }
}
