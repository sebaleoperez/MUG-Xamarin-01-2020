using System;
using System.Collections.Generic;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace Clase1
{
    public partial class InformacionDispositivo : ContentPage
    {
        public InformacionDispositivo()
        {
            InitializeComponent();

            var level = Battery.ChargeLevel; // returns 0.0 to 1.0 or 1.0 when on AC or no battery.

            var state = Battery.State;

            var source = Battery.PowerSource;

            lblCarga.Text = level.ToString();
            lblEstado.Text = state.ToString();
            lblFuente.Text = source.ToString();
        }
    }
}
