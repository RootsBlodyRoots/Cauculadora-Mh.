using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        double resultado;
        double fat;
        double memoria;
        double X;
        double Y;

        String operador;

        

     

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {


            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Pow(valor1,-1).ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
           valor1 = double.Parse(textBox1.Text);
               
           resultado = valor1 ;

           for (fat = 1; valor1 > 1; valor1 = valor1 - 1)

           fat = fat * valor1;

           textBox1.Text = Convert.ToString(fat);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button32_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button6_click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnVezes_click(object sender, EventArgs e)
        {            
            operador = "*";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDivisao_click(object sender, EventArgs e)
        {

            operador = "/";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnIgual_click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text);
            switch (operador)
            {
                case "+":

                resultado = valor1 + valor2;
                textBox1.Text = resultado.ToString();

                 break;

                case "-":
                    resultado = valor1 - valor2;
                    textBox1.Text = resultado.ToString();
                    break;

                case "*":

                    resultado = valor1 * valor2;
                    textBox1.Text = resultado.ToString();
                    break;

                case "/":

                    resultado = valor1 / valor2;
                    textBox1.Text = resultado.ToString();

                    break;
                
            }



        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btn8_click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnMenos_click(object sender, EventArgs e)
        {
            operador = "-";
            valor1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnRaiz_click(object sender, EventArgs e)
        {

            valor1= int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Sqrt(valor1).ToString();  
            
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {


            valor1 = Double.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Pow(valor2,3).ToString();

     }

        private void button41_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(textBox1.Text);

            resultado = valor2;

            textBox1.Text = Math.Pow(valor2, 2).ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Pow(valor1, 10).ToString();
        }

        private void btnLog_click(object sender, EventArgs e)
        {
            valor2 = int.Parse(textBox1.Text);

            resultado = valor2;

            textBox1.Text = Math.Log(valor2).ToString();
        }

        private void buttontanh_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Tanh(valor2).ToString();
        }

        private void buttoncosh_click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Cosh(valor1).ToString();
        }

        private void Btnsinn_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Sinh(valor1).ToString();
        }

        private void buttonsin_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Sin(valor1).ToString();
        }

        private void btncos_click(object sender, EventArgs e)
        {
            valor1= int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Cos(valor1).ToString();
        }

        private void btntan_click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Tan(valor1).ToString();
        }



        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }



        private void button10elevadoax_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(textBox1.Text);

            resultado = valor2;

            textBox1.Text = Math.Pow(10,valor2).ToString();
        }

        private void btnEXP_click(object sender, EventArgs e)
        {
            valor1 = int.Parse(textBox1.Text);

            resultado = valor1;

            textBox1.Text = Math.Exp(valor1).ToString();

        }

        private void btnPi_click(object sender, EventArgs e)
        {
            
            textBox1.Text = Math.PI.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(textBox1.Text);

            resultado = valor2 + valor1;

            textBox1.Text = Math.Pow(valor2,valor1).ToString();



        }

      
        private void btnMmenos_click(object sender, EventArgs e)
        {
            memoria = memoria - Convert.ToDouble(textBox1.Text);
            this.labelmemoria.Visible = true;

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void buttonporcento_Click(object sender, EventArgs e)
        {

            valor1 = double.Parse(textBox1.Text);

            resultado = valor1 + valor2;

            textBox1.Text = Convert.ToString((valor1*valor2)/100);


            
        }

        private void buttonmemoriamenos_Click(object sender, EventArgs e)
        {

        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(textBox1.Text);
            this.labelmemoria.Visible = true;

        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
            this.labelmemoria.Visible = false;

        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            Form2 outroform = new Form2();
            outroform.ShowDialog();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonMmais_Click(object sender, EventArgs e)
        {

            memoria = memoria + Convert.ToDouble(textBox1.Text);
            this.labelmemoria.Visible = true;



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 initial = new Form1();
            initial.ShowDialog();
        }

        private void tevv(object sender, KeyPressEventArgs e)
        {
        
        }

        private void BtnXelevY_Click(object sender, EventArgs e)
        {

            X = double.Parse(textBox1.Text);

            resultado = X + Y;

            textBox1.Text = Math.Pow(X, Y).ToString();


        }
    }
}
