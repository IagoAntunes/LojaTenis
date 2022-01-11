using SneakersShop.Modelo;
using SneakersShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SneakersShop
{
    public partial class MainPage : ContentPage
    {
        List<Tenis> ListaTenis = new List<Tenis>()
            {
                new Tenis { Nome="NMD_R1 candy", Preco="162",Imagem="Sneakers1" },
                new Tenis { Nome="NMD_R1 pink white", Preco="142",Imagem="Sneakers2" },
                new Tenis { Nome="NMD_R1 mint pink", Preco="179",Imagem="Sneakers3" },
                new Tenis { Nome="NMD_R1 white mint", Preco="154",Imagem="Sneakers4" }
            };
        public MainPage()
        {
            InitializeComponent();

            inicializaInfos();
        }
        public void inicializaInfos()
        {
            lblNome1.Text = ListaTenis[0].Nome;
            lblNome2.Text = ListaTenis[1].Nome;
            lblNome3.Text = ListaTenis[2].Nome;
            lblNome4.Text = ListaTenis[3].Nome;

            lblpreco1.Text = ListaTenis[0].Preco;
            lblpreco2.Text = ListaTenis[1].Preco;
            lblpreco3.Text = ListaTenis[2].Preco;
            lblpreco4.Text = ListaTenis[3].Preco;

        }

        private void GoDetalhesP1(object sender,EventArgs args)
        {
            App.Current.MainPage = new Detalhes(ListaTenis[0]);
        }
    }
}
