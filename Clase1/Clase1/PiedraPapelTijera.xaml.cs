using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1
{
    public partial class PiedraPapelTijera : ContentPage
    {
        Random rndComputadora = new Random();

        public PiedraPapelTijera()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            // 0 es piedra, 1 es papel, 2 es tijera
            int eleccionComputadora = rndComputadora.Next(0, 3);
            bool gane = false;
            bool perdi = false;

            if (button.Text == "Piedra")
            {
                if (eleccionComputadora == 1) perdi = true;
                else if (eleccionComputadora == 2) gane = true;
            }
            else if (button.Text == "Papel")
            {
                if (eleccionComputadora == 2) perdi = true;
                else if (eleccionComputadora == 0) gane = true;
            }
            else
            {
                if (eleccionComputadora == 0) perdi = true;
                else if (eleccionComputadora == 1) gane = true;
            }

            if (perdi) LabelPuntajeComputadora.Text = (int.Parse(LabelPuntajeComputadora.Text) + 1).ToString();
            else if (gane) LabelPuntajeJugador.Text = (int.Parse(LabelPuntajeJugador.Text) + 1).ToString();

        }
    }
}
