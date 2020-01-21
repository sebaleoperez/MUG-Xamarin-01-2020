using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Clase1
{
    public partial class ListaDeNumeros : ContentPage
    {
        public ListaDeNumeros()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            StackLista.Children.Clear();
            if (EntryNumero.Text != string.Empty)
            {
                int numero = int.Parse(EntryNumero.Text);

                for (int iterador = 1; iterador <= numero; iterador++)
                {
                    StackLista.Children.Add(new Label()
                    {
                        Text = iterador.ToString()
                    });
                }
            }
        }
    }
}
