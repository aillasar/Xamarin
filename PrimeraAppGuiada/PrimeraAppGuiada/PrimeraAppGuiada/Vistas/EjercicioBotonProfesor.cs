using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeraAppGuiada.Vistas
{
    public class EjercicioBotonProfesor:ContentPage
    {

        public EjercicioBotonProfesor()
        {
            var etiqueta = new Label{ Text = "Acceso a la plataforma",
                                      FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                      FontAttributes = FontAttributes.Italic,
                                      TextColor = Color.Aqua};

            var inputUsuario = new Entry{ Placeholder = "introduzca su usuario"};

            var inputPassword = new Entry{ Placeholder = "introduce password" };

            var etiquetaBorde = new Frame{ OutlineColor = Color.Purple,
                                          Content = etiqueta };



            var btnLogin = new Button { Text = "enviar" };

            btnLogin.Clicked += (sender, args) => {
                DisplayAlert("Boom", "Boom", "Exploto");
            };



            var cajaBordeInput = new Frame
            {
                Content = new StackLayout
                {
                   
                    Children = {inputUsuario, inputPassword}
                }
            };

            var imagen = new Image
            {
                Aspect = Aspect.AspectFill
            };

            imagen.Source = "https://skronker.files.wordpress.com/2013/09/unipiper.jpg";
            Content = new StackLayout {
                Padding = 20,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {imagen,etiquetaBorde,cajaBordeInput,btnLogin}
            };


            
        }

    }
}
