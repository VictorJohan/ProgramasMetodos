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
    /// Interaction logic for rTaylor.xaml
    /// </summary>
    public partial class rTaylor : Window
    {
        private TaylorObj Taylor = new TaylorObj();
        private List<TaylorObj> lista = new List<TaylorObj>();
        public rTaylor()
        {
            InitializeComponent();
            this.DataContext = Taylor;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            lista = MetodosNumericos.SerieTaylor(Taylor);
            ResultadosDataGrid.ItemsSource = lista;
            SumatoriaTextBox.Text = Sumatoria(lista).ToString();
        }

        private double Sumatoria(List<TaylorObj> lista)
        {
            double sumatoria = 0;

            foreach (var item in lista)
            {
                sumatoria += item.ValorT;
            }

            return sumatoria;
        }
    }
}
