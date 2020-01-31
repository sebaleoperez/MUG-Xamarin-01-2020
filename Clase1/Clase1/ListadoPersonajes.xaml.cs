using System;
using System.Collections.Generic;
using Clase1.Services;
using Xamarin.Forms;

namespace Clase1
{
    public partial class ListadoPersonajes : ContentPage
    {
        public ListadoPersonajes()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            StarWarsService service = new StarWarsService();
            DatabaseService dbService = new DatabaseService();

            List<People> personajes = await dbService.GetPeoplesAsync();

            if (personajes.Count == 0)
            {
                personajes = await service.GetPeoplesAsync();
                dbService.SaveAllPeople(personajes);
            }

            listviewPersonajes.ItemsSource = personajes;


        }

        void listviewPersonajes_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetallePersonaje((People)e.Item));
        }
    }
}
