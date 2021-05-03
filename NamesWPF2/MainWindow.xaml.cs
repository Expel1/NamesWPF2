using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace namesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.InitNames();
            Person n = new Person();
            DataContext = n;
        }

        private void Names_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person ni = (Person)((sender as ListView).SelectedItem);
            DataContext = ni;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Names.SelectedIndex = 0;
        }

        private void Names_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person ni = (Person)((sender as ListView).SelectedItem);
            NamesEdit ne = new NamesEdit(ni);
            ne.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NamesEdit ue = new NamesEdit();
            ue.ShowDialog();
        }
    }
}
