﻿using ProgramasMetodos.Clases;
using ProgramasMetodos.UI;
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

namespace ProgramasMetodos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MetodosNumericos.Factorial(5);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rBiseccion biseccion = new rBiseccion();
            biseccion.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            rTaylor rTaylor = new rTaylor();
            rTaylor.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            rPosicion rPosicion = new rPosicion();
            rPosicion.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            rBrent rBrent = new rBrent();
            rBrent.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            rNewtonR rNewtonR = new rNewtonR();
            rNewtonR.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            rSecante rSecante = new rSecante();
            rSecante.Show();
        }
    }
}
