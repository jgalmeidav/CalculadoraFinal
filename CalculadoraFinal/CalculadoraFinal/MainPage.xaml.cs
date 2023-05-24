using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraFinal
{
    public partial class MainPage : ContentPage
    {
        double Num1=0, Num2=0, Resultado=0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text); 
            Num2=double.Parse(txtNum2.Text);
            Resultado = Num1 + Num2;
            lblResultado.Text = ""+Resultado;
        }

        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            Resultado = Num1 - Num2;
            lblResultado.Text = "" + Resultado;
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            Resultado = Num1 * Num2;
            lblResultado.Text = "" + Resultado;
        }

        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            Num1 = double.Parse(txtNum1.Text);
            Num2 = double.Parse(txtNum2.Text);
            Resultado = Num1 / Num2;
            lblResultado.Text = "" + Resultado;
        }
    }
}
