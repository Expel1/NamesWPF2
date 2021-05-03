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


namespace namesWPF { 
    public partial class NamesEdit : Window
{
    bool IsUpdating { get; set; }
    public NamesEdit()
    {
        InitializeComponent();
        DataContext = new Person();
        IsUpdating = false;
    }
    public NamesEdit(Person n)
    {
        InitializeComponent();
        DataContext = n;
        IsUpdating = true;
    }
    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        if (IsUpdating == false)
        {
            Person.AllNames.Add((Person)DataContext);
        }
        this.Close();
    }
}
}
