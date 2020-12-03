using ProgramasMetodos.Clases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgramasMetodos.UI
{
    /// <summary>
    /// Interaction logic for rNewtonR.xaml
    /// </summary>
    public partial class rNewtonR : Window
    {
        public rNewtonR()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text = "Resultado: ";
            ResultadoTextBlock.Text += NewtonRaphson.NewtonR(double.Parse(ValorInicialTextBox.Text), double.Parse(DecimalesTextBox.Text));
        }
    }
}
