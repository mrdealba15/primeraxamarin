using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicacion1
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            //InitializeComponent();
            var layout = new StackLayout
            {
                Orientation= StackOrientation.Vertical
               
            };
               
            var label = new Label
            {
                Text = "Hola!, presiona el botón",
                FontSize= 30, 

            };

            var Boton = new Button
            {
                 Text = "Click Aquí"
            };

            Boton.Clicked += Aceptar; 
            layout.Children.Add(label);
            layout.Children.Add(Boton); 
        
            this.Content = layout; 
		}
        
        void Aceptar(object sender, System.EventArgs e)
        {
            DisplayAlert("Hola","Ha dado aceptar", "OK"); 
        }

       


    }
}
