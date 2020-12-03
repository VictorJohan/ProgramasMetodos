using ProgramasMetodos.Clases.Secante;
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
    /// Interaction logic for rSecante.xaml
    /// </summary>
    public partial class rSecante : Window
    {
        private class SecanteModel
        {
            public int n { get; set; }
            public double Xn { get; set; }
            public double Xn1 { get; set; }
            public double Fxn { get; set; }
            public double Ea { get; set; }
        };
        SecanteModel model = new SecanteModel();
        List<SecanteModel> lista = new List<SecanteModel>();
        Fx fx = new Fx();
        public rSecante()
        {
            InitializeComponent();
            
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {

            double x1 = double.Parse(X1TextBox.Text);
            double x0 = double.Parse(X0TextBox.Text);
            double xn1 = 0;
            double ea = 0;
            int i = 0;
            xn1 = x1 - (((fx.Fx0(FuncionTextBox.Text, x1)) * (x0 - x1)) / (fx.Fx0(FuncionTextBox.Text, x0) - fx.Fx0(FuncionTextBox.Text, x1)));
            xn1 = (double)decimal.Round((decimal)xn1, 5);

            model.n = i;
            model.Xn = x1;
            model.Xn1 = xn1;
            model.Fxn = x0;

            ea = Math.Abs(xn1 - x1);
            model.Ea = ea;
            x1 = xn1;

            lista.Add(model);
            model = new SecanteModel();

            while(ea >= 0.001)
            {
                i++;
                xn1 = x1 - (((fx.Fx0(FuncionTextBox.Text, x1)) * (x0 - x1)) / (fx.Fx0(FuncionTextBox.Text, x0) - fx.Fx0(FuncionTextBox.Text, x1)));

                try
                {
                    xn1 = (double)decimal.Round((decimal)xn1, 4);

                    model.n = i;
                    model.Xn = x1;
                    model.Xn1 = xn1;
                    model.Fxn = x0;

                    ea = Math.Abs(xn1 - x1);
                    model.Ea = ea;
                    x1 = xn1;
                    
                }
                catch { MessageBox.Show("Raices Infinitas"); break; }

            }

            lista.Add(model);
            ResultadosDataGrid.ItemsSource = lista;
            lista = new List<SecanteModel>();
            model = new SecanteModel();
        }

        

    }
}
