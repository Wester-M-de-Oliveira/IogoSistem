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
using IogoSistem.Models;
using IogoSistem.Views;

namespace IogoSistem
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

               
        }

        private void Abrir_Usuario(object sender, RoutedEventArgs e)
        {
            var window = new UsuarioFormWindow();
            window.ShowDialog();

        }

        private void Abrir_lista(object sender, RoutedEventArgs e)
        {
            var window = new UsuarioListWindow();
            window.ShowDialog();
        }
    }
}
