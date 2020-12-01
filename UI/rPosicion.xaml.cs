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
    /// Interaction logic for rPosicion.xaml
    /// </summary>
    public partial class rPosicion : Window
    {
        private PosicionFalsaObj Posicion = new PosicionFalsaObj();
        public rPosicion()
        {
            InitializeComponent();
            this.DataContext = Posicion;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadosDataGrid.ItemsSource = MetodosNumericos.PosicionFalsa(Posicion);
        }
    }
}
