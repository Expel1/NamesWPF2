using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namesWPF
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }
        private string _surname;
        public string Surname
        {
            get => _surname;
            set { _surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }
        private int _age;
        public int Age
        {
            get => _age;
            set { _age = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age")); }
        }

        public static ObservableCollection<Person> AllNames { get; set; } = new ObservableCollection<Person>();

        public static void InitNames()
        {
            AllNames.Add(new Person
            {
                Name = "Jan",
                Surname = "Novák",
                Age = 18
            });
            AllNames.Add(new Person
            {
                Name = "Petr",
                Surname = "Někdo",
                Age = 99
            });
            AllNames.Add(new Person
            {
                Name = "Petr",
                Surname = "Člověk",
                Age = 21
            });
            AllNames.Add(new Person
            {
                Name = "Jan",
                Surname = "Novák druhý",
                Age = 54
            });


        }
    }
}
