using System;
using System.Collections.Generic;
using Clase1.Services;
using Xamarin.Forms;

namespace Clase1
{
    public partial class DetallePersonaje : ContentPage
    {
        public DetallePersonaje(People people)
        {
            InitializeComponent();

            stackLayoutPrincipal.BindingContext = people;
        }
    }
}
