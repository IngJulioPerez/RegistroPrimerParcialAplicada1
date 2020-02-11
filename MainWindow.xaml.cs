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
using RegistroPrimerParcial.Entidades;
using RegistroPrimerParcial.DAL;

namespace RegistroPrimerParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Articulo LlenaCLase()
        {
            Articulo articulo = new Articulo();
            articulo.ProductoId = Convert.ToInt32(IdTxt.Text);
            articulo.Descripcion = DescripcionTxt.Text;
            articulo.Existencia = Convert.ToInt32(ExistenciaTxt.Text);
            articulo.Costo = Convert.ToInt32(CostoTxt.Text);
            articulo.ValorInventario = Convert.ToInt32(ValorInventarioTxt.Text);
            return articulo;            
        }
        private void LlenaCampo(Articulo articulo)
        {
            
        }
        

        private void NuevoBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void GuardarBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
