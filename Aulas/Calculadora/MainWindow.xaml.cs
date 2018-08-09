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

namespace Calculadora
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        String operador;
        Double acumula = 0;

        private void num1(object sender, RoutedEventArgs e)
        {
            tela.Text += "1";
        }

        private void num2(object sender, RoutedEventArgs e)
        {
            tela.Text += "2";
        }

        private void num3(object sender, RoutedEventArgs e)
        {
            tela.Text += "3";
        }

        private void num0(object sender, RoutedEventArgs e)
        {
            tela.Text += "0";
        }

        private void num4(object sender, RoutedEventArgs e)
        {
            tela.Text += "4";
        }

        private void num5(object sender, RoutedEventArgs e)
        {
            tela.Text += "5";
        }

        private void num6(object sender, RoutedEventArgs e)
        {
            tela.Text += "6";
        }

        private void Apagar(object sender, RoutedEventArgs e)
        {
            tela.Text += "";
        }

        private void num7(object sender, RoutedEventArgs e)
        {
            tela.Text += "7";
        }

        private void num8(object sender, RoutedEventArgs e)
        {
            tela.Text += "8";
        }

        private void num9(object sender, RoutedEventArgs e)
        {
            tela.Text += "9";
        }

        private void Porcen(object sender, RoutedEventArgs e)
        {
            if( )
        }

        private void Raiz(object sender, RoutedEventArgs e)
        {

        }

        private void Ponto(object sender, RoutedEventArgs e)
        {
            tela.Text += ".";
        }

        private void Memo(object sender, RoutedEventArgs e)
        {

        }

        private void Adicao(object sender, RoutedEventArgs e)
        {
            if( operador =="-" || operador == "*" || operador == "/")
            {
                operador == "+";
            }
            else
            {
                acumula += double.Parse(tela.Text);
                tela.Text = "";
                operador = "+";

            }
        }

        private void subtra(object sender, RoutedEventArgs e)
        {

        }

        private void multi(object sender, RoutedEventArgs e)
        {

        }

        private void divi(object sender, RoutedEventArgs e)
        {

        }

        private void Igual(object sender, RoutedEventArgs e)
        {

        }
    }
}
