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
using WpMVVM.Clase;

namespace WpMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Persona persona = new Persona
            {
                Nombres = "Juan Marco",
                Apellidos = "Proaño Chele",
                Telefono = "0969628066",
                Correo = "e1315645752@live.uleam.edu.ec"
            };
            this.DataContext = persona;
        }
    }
}
