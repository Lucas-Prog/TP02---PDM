using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstiloDinamico : ContentPage
	{
        public EstiloDinamico()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);

            InitializeComponent();
        }

        private void btn_changeClicked(object sender, EventArgs e)
        {
            labelClock.TextColor = randomColor();
        }
        private Color randomColor()
        {
            Random rnd = new Random();
            return Color.FromRgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        public async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        bool OnTimerTick()
        {
            labelClock.Text = DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss");
            return true;
        }
    }
}
