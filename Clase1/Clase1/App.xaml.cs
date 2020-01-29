using System;
using Clase1.EjemplosNavegacion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase1
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuPrincipal = new MasterDetailPage();

        public App()
        {
            InitializeComponent();

            MenuPrincipal.Master = new MenuLateral();
            MenuPrincipal.Detail = new NavigationPage(new ListadoPersonajes());

            MenuPrincipal.IconImageSource = "icon.png";

            MainPage = MenuPrincipal;

            /*
            TabbedPage numerosTabbedPage = new TabbedPage();
            numerosTabbedPage.Children.Add(new NumeroPage(1)
            {
                Title = "Uno"
            });
            numerosTabbedPage.Children.Add(new NumeroPage(2)
            {
                Title = "Dos"
            });
            numerosTabbedPage.Children.Add(new NumeroPage(3)
            {
                Title = "Tres"
            });
            numerosTabbedPage.Children.Add(new NumeroPage(4)
            {
                Title = "Cuatro"
            });
            numerosTabbedPage.Children.Add(new NumeroPage(5)
            {
                Title = "Cinco"
            });

            MainPage = numerosTabbedPage;
            */


            //MainPage = new ColoresTabbedPage();
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
