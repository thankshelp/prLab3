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

namespace lab3
{
    /// <summary>
    /// Логика взаимодействия для AddTimer.xaml
    /// </summary>
    public partial class AddTimer : Window
    {
        public AddTimer()
        {
            InitializeComponent();
        }

        public AddTimer(string name, DateTime dt)
        {
            InitializeComponent();

            this.name.Text = name;
            this.hours.Text =  dt.Hour.ToString();
            this.min.Text = dt.Minute.ToString();
            this.sec.Text = dt.Second.ToString();

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }

        private void can_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        
    }
}
