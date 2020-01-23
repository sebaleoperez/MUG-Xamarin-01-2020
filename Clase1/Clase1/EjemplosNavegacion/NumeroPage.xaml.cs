using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1.EjemplosNavegacion
{
    public partial class NumeroPage : ContentPage
    {
        public NumeroPage(int numero)
        {
            InitializeComponent();

            LabelNumero.Text = numero.ToString();
        }
    }
}
