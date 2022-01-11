using SneakersShop.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SneakersShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        public Detalhes(Tenis tenis)
        {
            InitializeComponent();
            inicializaInfos(tenis);
        }
        public void inicializaInfos(Tenis tenis)
        {
            lblNome.Text = tenis.Nome;

            lblPreco.Text = tenis.Preco;
        }
    }
}