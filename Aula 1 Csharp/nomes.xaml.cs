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

namespace Aula_1_Csharp
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void NomeCompleto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NomeCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) 
            {
                var Nomedouser = NomeCompleto.Text;

                NomeCompleto.Text = "muito loco"; 
           }            
        }

        private void Backpag_Click(object sender, RoutedEventArgs e)
        {
            var paginainicial = new MainWindow();

            Application.Current.MainWindow.Content = paginainicial.Content;
        
        }
    }
}
