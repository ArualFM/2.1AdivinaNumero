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

namespace _2._1AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
  
    public partial class MainWindow : Window
    {
        

        int numeroAlea = NumeroAleatorio();
        public MainWindow()
        {
            InitializeComponent();
           
        }
        public static int NumeroAleatorio()
        {
            Random r = new Random();
            int aleatorio = r.Next(0, 100);
            return aleatorio;
        }

        private void BotonComprobar_Click(object sender, RoutedEventArgs e)
        {
           
            int respuesta = int.Parse(ResultadoTextBox.Text);
            if (numeroAlea==respuesta)
            {
                MensajeTextBlock.Text = "Has acertado";
            }
            else if (numeroAlea < respuesta)
            {
                MensajeTextBlock.Text = "Te has pasado";
            }
            else
            {
                MensajeTextBlock.Text = "Te has quedado corto";
            }

        }

        private void BotonReiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroAlea = NumeroAleatorio();
            ResultadoTextBox.Text = "";
            ResultadoTextBox.Text = String.Empty;
            


        }

        private void ResultadoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
