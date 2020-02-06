using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Clase1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private bool isBussy;
        public bool IsBussy
        {
            get { return isBussy; }
            set { this.isBussy = value; OnPropertyChanged("IsBussy"); }
        }

        public ICommand ComandoNavegar { get; set; }

        private string mensaje;
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
            set
            {
                this.mensaje = value;
                OnPropertyChanged("Mensaje");
            }
        }

        private string username;
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
                OnPropertyChanged("Username");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
                OnPropertyChanged("Password");
            }
        }

        public ICommand ClickValidar { get; set; }

        public LoginViewModel()
        {
            this.ClickValidar = new Command(ValidarUsuario);
        }

        public async void ValidarUsuario()
        {
            IsBussy = true;

            await Task.Delay(5000).ConfigureAwait(false);

            if (this.Username == "admin" && this.Password == "123")
                this.Mensaje = "USUARIO VALIDO";
            else
                this.Mensaje = "USUARIO NO VALIDO";

            IsBussy = false;

            this.ComandoNavegar.Execute(new object());
        }
    }
}
