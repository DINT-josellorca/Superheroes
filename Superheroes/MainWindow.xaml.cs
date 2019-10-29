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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Superheroe heroe;
        public MainWindow()
        {
            InitializeComponent();
            heroe = Superheroe.GetSample();
            FotoImage.DataContext = heroe;
            HeroeGrid.DataContext = heroe;
        }

        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            EditarStackPanel.DataContext = heroe;
            NombreTextBox.Text = heroe.Nombre;
            VillanoTextBox.Text = heroe.Enemigo;
            FotoTextBox.Text = heroe.Foto;
        }

        private void NombreTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            heroe.Nombre = NombreTextBox.Text;
        }

        private void VillanoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            heroe.Enemigo = VillanoTextBox.Text;
        }

        private void FotoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            heroe.Foto = FotoTextBox.Text;
        }

        private void VengadorCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            heroe.Vengador = true;
        }

        private void VengadorCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            heroe.Vengador = false;
        }
    }
}
