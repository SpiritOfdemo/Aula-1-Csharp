﻿using System;
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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class inicial : Page
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void BotaoIniciar_Click(object sender, RoutedEventArgs e)
        {
            var nomesdouser = new Page1();

            this.Content = nomesdouser;
        }
    }
}
