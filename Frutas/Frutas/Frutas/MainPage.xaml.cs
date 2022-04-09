using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Frutas
{
    public partial class MainPage : ContentPage
    {
        public class Fruta 
        {
            public string Nombre { get; set; }
            public string Url { get; set; }
        }
        ObservableCollection<Fruta> datos = new ObservableCollection<Fruta>();
        public MainPage()
        {
            InitializeComponent();
            milista.ItemsSource = datos;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            datos.Add(new Fruta { Nombre = nombre.Text, Url = url.Text });
            nombre.Text = "";
            url.Text = "";
        }
        async private void Milista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem;
            int index = datos.IndexOf(myItem);
            string action = await DisplayActionSheet("Acciones:", "Cancelar",
           null, "Eliminar", "Editar");
            if (action == "Eliminar")
            {
                datos.RemoveAt(index);
                await DisplayAlert("Eliminar elemento", "Se elimino el lemento no:"
               + index, "OK");
                milista.ItemsSource = null;
                milista.ItemsSource = datos;
            }
            if (action == "Editar")
            {
                await DisplayAlert("Mensaje", "Seleccio editar", "ok");
            }
        }

        private void MenuItem_Mostrar(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Selecciono Mostrar", "ok");

        }
        private void MenuItem_Borrar(object sender, EventArgs e)
        {
            var mifruta = ((MenuItem)sender);
            DisplayAlert("Fruta seleccioada", "Fruta:" + mifruta.CommandParameter.ToString(), "ok");


        }
       
    }
}
