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
    /// Interaction logic for rBrent.xaml
    /// </summary>
    public partial class rBrent : Window
    {
        private BrentObj Brent = new BrentObj();
        public rBrent()
        {
            InitializeComponent();
            this.DataContext = Brent;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadosDataGrid.ItemsSource = MetodosNumericos.Brent(Brent);
        }
    }
}
