using System;
using Xamarin.Forms;

namespace Clase1.Selectores
{
    public class MensajesTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TemplateEntrada { get; set; }
        public DataTemplate TemplateSalida { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Mensaje mensaje = (Mensaje)item;

            if (mensaje.EsMio) return TemplateEntrada;
            else return TemplateSalida;
        }
    }
}
