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
using System.Windows.Shapes;

namespace ryle.Pages
{
    /// <summary>
    /// Логика взаимодействия для listviewmerch.xaml
    /// </summary>
    public partial class listviewmerch : Window
    {
        public listviewmerch()
        {
            InitializeComponent();
            lv.ItemsSource = Models.ryleEntities1.GetContext().merch.ToList();

        }

        private void vihodClick(object sender, RoutedEventArgs e)
        {
            Autor autor = new Autor();
            this.Visibility = Visibility.Hidden;
            autor.Show();
        }

        private void obnovClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
