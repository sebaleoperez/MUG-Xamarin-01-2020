using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Clase1.Services;

namespace Clase1.ViewModels
{
    public class ListadoPersonajesViewModel : BaseViewModel
    {
        private string titulo;
        public string Titulo {
            get
            {
                return titulo;
            }
            set
            {
                this.titulo = value;
                OnPropertyChanged("Titulo");
            }
        }

        public ObservableCollection<People> Personajes { get; set; }

        public ListadoPersonajesViewModel()
        {
            this.Titulo = "PERSONAJES";
        }

        public async Task CargarPersonajes()
        {
            StarWarsService service = new StarWarsService();
            DatabaseService dbService = new DatabaseService();

            ObservableCollection<People> personajes = new ObservableCollection<People>(await dbService.GetPeoplesAsync());

            if (personajes.Count == 0)
            {
                List<People> listaPersonajes = await service.GetPeoplesAsync();
                personajes = new ObservableCollection<People>(listaPersonajes);
                dbService.SaveAllPeople(listaPersonajes);
            }

            this.Personajes = personajes;
            OnPropertyChanged("Personajes");
        }
    }
}
