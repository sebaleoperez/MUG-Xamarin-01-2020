using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1
{
    public partial class Chat : ContentPage
    {
        public Chat()
        {
            InitializeComponent();

            List<Mensaje> mensajes = new List<Mensaje>();

            mensajes.Add(new Mensaje()
            {
                Texto = "Hola !",
                EsMio = true,
                Fecha = DateTime.Now.ToShortDateString()
            });

            mensajes.Add(new Mensaje()
            {
                Texto = "Hola ! Como estas ?",
                EsMio = false,
                Fecha = DateTime.Now.AddMinutes(1).ToShortDateString()
            });

            mensajes.Add(new Mensaje()
            {
                Texto = "Todo bien y vos ?",
                EsMio = true,
                Fecha = DateTime.Now.AddMinutes(1).ToShortDateString()
            });

            lvMensajes.ItemsSource = mensajes;

        }
    }

    public class Mensaje
    {
        public string Texto { get; set; }
        public bool EsMio { get; set; }
        public string Fecha { get; set; }
    }
}
