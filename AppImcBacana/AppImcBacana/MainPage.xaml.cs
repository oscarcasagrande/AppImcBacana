using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppImcBacana
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double peso = Convert.ToInt32(Peso.Text);
            double altura = Convert.ToInt32(Altura.Text);
            double imc = (peso / (altura / 100 * altura / 100));

            string resultado = string.Format("Seu IMC é {0:N} %", imc);

            Resultado.Text = resultado;
        }

        private void Button_Clicked_Go_To_WebSite(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://oscarcasagrande.com.br/?soruce=igti-teste-pratico"));
        }
    }
}
