using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();


        }

        async void NovaPagina(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = entNome.Text,
                Idade = int.Parse(entIdade.Text),
                Profissao = entProfissao.Text,
                Pais = entPais.Text
            };

            var detalhe = new NOVAPAGINA();
            detalhe.BindingContext = contato;
            await Navigation.PushAsync(detalhe);

        }

    }
  }
