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
    /// Interaction logic for rBiseccion.xaml
    /// </summary>
    public partial class rBiseccion : Window
    {
        public BiseccionObj Biseccion = new BiseccionObj();
        public rBiseccion()
        {
            InitializeComponent();
            this.DataContext = Biseccion;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
           
            ResultadosDataGrid.ItemsSource = MetodosNumericos.Biseccion(Biseccion);
            //Cargar();
        }

        public void Cargar()
        {
            this.DataContext = null;
            this.DataContext = Biseccion;
        }
    }
}
