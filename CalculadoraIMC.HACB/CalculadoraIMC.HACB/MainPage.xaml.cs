using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC.HACB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Declara variable y asinaciones valor
            var peso = float.Parse(Peso.Text);
            var alturar = float.Parse(Altura.Text);
            //realizar el calculo
            var imc = peso / (alturar * alturar);
            //Enviar resultado
            IMC.Text = imc.ToString();

            string resultado = "";
            if (imc < 18.5)
            {
                resultado = "bajo peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                resultado = "peso normal";
            }
            else if (imc >= 24.9 && imc <= 29.9)
            {
                resultado = "Sobre peso";
            }
            else if (imc > 29.9)
            {
                resultado = "Obesidad";
            }
            DisplayAlert("Resultado:", resultado, "Quita");

            
        }
    }
}
