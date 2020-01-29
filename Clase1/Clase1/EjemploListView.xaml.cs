using System;
using System.Collections.Generic;
using Clase1.EjemplosNavegacion;
using Xamarin.Forms;

namespace Clase1
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Imagen { get; set; }
    }

    public partial class EjemploListView : ContentPage
    {
        public EjemploListView()
        {
            InitializeComponent();

            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(new Alumno()
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Imagen = "https://d2k7k7fv4ro731.cloudfront.net/media/catalog/product/seo-cache/x800/401/62/401-62-NTB-Frontside/Football-Icon--Lionel-Messi-David-Diehl-Notebook.jpg"
            });

            alumnos.Add(new Alumno()
            {
                Nombre = "Roberto",
                Apellido = "Gonzalez",
                Imagen = "https://d2k7k7fv4ro731.cloudfront.net/media/catalog/product/seo-cache/x800/401/62/401-62-NTB-Frontside/Football-Icon--Lionel-Messi-David-Diehl-Notebook.jpg"
            });
           
            listViewPrincipal.ItemsSource = alumnos;

        }

        void listViewPrincipal_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            DisplayAlert("Alumno", ((Alumno)e.Item).Nombre, "OK");
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            int numero = int.Parse(entryNumero.Text);

            List<int> listado = new List<int>();

            for (int iterador = 1; iterador <= numero; iterador++)
            {
                listado.Add(iterador);
            }

            listViewPrincipal.ItemsSource = listado;
        }
    }
}
