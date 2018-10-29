using Cinema_ALH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_ALH.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResumenCompraPage : ContentPage
	{
        private Funcion funcionSeleccionada;

        public ResumenCompraPage (ResumenCompra resumen)
		{
			InitializeComponent ();
            BindingContext = resumen;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("EXITOSA", "LA RESERVA SE HA GENERADO CORRECTAMENTE", "OK");
            return;

        }
    }
}