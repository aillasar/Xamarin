using Java.Util.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeraAppGuiada.Vistas
{
    public class MiPrimeraPagina : ContentPage
    {

        string hola = "Hola";

        public MiPrimeraPagina()
        {
            var etiqueta = new Label
            {
                Text = "Mira que etiquetaza"
            };
            var input = new Entry
            {
                Placeholder = "Esto es una caja para escribir"
            };
            var boton = new Button
            {
                Text = "Entrar"


            };
            var urii = new Uri("https://skronker.files.wordpress.com/2013/09/unipiper.jpg");
            var imagen = new Image { Aspect = Aspect.AspectFit };
            imagen.Source = ImageSource.FromUri(urii);



            //Function clic{ DisplayAlert("sdfsd", "sdfsd", "ok"); };

            //boton.Clicked += clic;




            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { imagen, etiqueta, input, boton }
            };

        }
    }
}
