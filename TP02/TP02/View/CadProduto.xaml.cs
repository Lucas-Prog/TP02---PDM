using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadProduto : ContentPage
    {
        private List<Produto> listaProdutos;
        public CadProduto()
        {
            InitializeComponent();
        }

        void saveProd()
        {
            var produto = new Produto
            {
                Id = listaProdutos.Count,
                Descrição = entDescricao.ToString(),
                Categoria = entCategoria.ToString(),
                Quantidade = int.Parse(entQuantidade.ToString()),
                Preco = decimal.Parse(entPreco.ToString())
            };

            listaProdutos.Add(produto);

        }

        async void listProdPage(object sender, EventArgs e)
        {
            var detalhe = new ViewListProd();
            detalhe.BindingContext = listaProdutos;
            await Navigation.PushAsync(detalhe);

        }
    }
}