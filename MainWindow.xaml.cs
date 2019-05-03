using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        double valor1;

        double valor2;

        String operador;

        double resultado;

        


        public MainWindow()
        {
            InitializeComponent();

           
            

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";

        }


        private void Btn2_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void Btn1_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void Btn4_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPorcent_click(object sender, RoutedEventArgs e)
        {


            try
            {
                valor1 = double.Parse(textBox.Text);
                resultado = valor1 + valor2;
                textBox.Text = Convert.ToString(valor1 * valor2 / 100);
            }
            catch (Exception)
            {

                throw new System.InvalidCastException("ERROR");
                   
            }

        }

        private void BtnDivisor_Click(object sender, RoutedEventArgs e)
        {

            operador = "/";
            textBox.Text = operador.ToString();
            this.textBox.Clear();            
            
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMenos_click(object sender, RoutedEventArgs e)
        {
            operador = "-";
            textBox.Text = operador.ToString();
        
            this.textBox.Clear();

        }

        private void BtnVezes_click(object sender, RoutedEventArgs e)
        {
            operador = "*";
            textBox.Text = operador.ToString();
            this.textBox.Clear();
        }

        private void BtnMais_click(object sender, RoutedEventArgs e)
        {
            operador = "+";

            textBox.Text = operador.ToString();

            this.textBox.Clear();
        }

        private void BtnIgual_click(object sender, RoutedEventArgs e)
        {


                valor2 = double.Parse(textBox.Text);


            switch (operador)

            {

                case  "+":
                resultado = valor1 + valor2;
                textBox.Text = resultado.ToString();
                break;
                case "_":
                resultado = valor1 - valor2;
                textBox.Text = resultado.ToString();
                break;
                case "*":
                resultado = valor1 * valor2;
                textBox.Text = resultado.ToString();
                break;
                case "/":
                resultado = valor1 / valor2;
                textBox.Text = resultado.ToString();
                break;

            }

        }

        private void Btn5_click(object sender, RoutedEventArgs e)
        {

            textBox.Text = textBox.Text +"5";

        }

        private void BtnC_click(object sender, RoutedEventArgs e)
        {
            this.textBox.Focus();

        }

        private void BtnCE_click(object sender, RoutedEventArgs e)
        {
            this.textBox.Clear();
            
        }

        private void BtnVirgula(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ",";


        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button9_AccessKeyPressed(object sender, AccessKeyPressedEventArgs e)
        {

        }

        private void BtnVir_clicl(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text = ",";
        }

        private void BtnMm_click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnZero_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text  + "0";
                            
        }

        private void Btn6_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void Btn8_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";

        }

        private void Btn7_click_(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void Btn9_click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox + "9";
        }

        private void BtnR_click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text.Remove(1);

        }

        private void Buttondividoporx_Click(object sender, RoutedEventArgs e)
        {



           
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
