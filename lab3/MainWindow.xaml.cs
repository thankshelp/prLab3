using System;
using System.Collections.Generic;
using System.IO;
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

namespace lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;
        Dictionary<string, DateTime> list = new Dictionary<string, DateTime>();
        int sec = 0;
        String nm;
        DateTime df, dt;
        AddTimer adt;
        bool v = false;

        public MainWindow()
        {
            InitializeComponent();

            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 0, 1);


        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            sec++;

            DateTime dn = DateTime.Now;

            TimeSpan rz = df - dn;
            if (v == true)
            {
                tb.Text = "";

                if(cbd.IsChecked == true)
                tb.Text += rz.Days.ToString() + " ";
                if (cbh.IsChecked == true)
                    tb.Text += rz.Hours.ToString();
                if (cbm.IsChecked == true)
                    tb.Text += ":" + rz.Minutes.ToString();
                if (cbs.IsChecked == true)
                    tb.Text += ":" + rz.Seconds.ToString();
            }
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            // list.Add(tb2.Text, new DateTime(2018, 5, 25, 8, 0, 0));

            adt = new AddTimer();

            if (adt.ShowDialog() == true)
            {

                int year = adt.cal.SelectedDate.Value.Year;
                int mon = adt.cal.SelectedDate.Value.Month;
                int day = adt.cal.SelectedDate.Value.Day;

                string name = adt.name.Text;
                int hrs = int.Parse(adt.hours.Text);
                int min = int.Parse(adt.min.Text);
                int sec = int.Parse(adt.sec.Text);

                dt = new DateTime(year, mon, day, hrs, min, sec);

                stack.Items.Add(name);

                list.Add(name, dt);

            }
            else
            {
                MessageBox.Show("Вы не ввели данные!");
            }
        }

        private void stack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (stack.SelectedIndex > -1)
            {
                nm = stack.Items[stack.SelectedIndex].ToString();

                df = list[nm];

                Timer.Start();

                v = true;
            }
            
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

            list.Remove(nm);
            stack.Items.Remove(nm);
            Timer.Stop();
            v = false; 
            tb.Text = "";
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = "Text document (.txt)|*.txt";
            dlg.ShowDialog();

            string[] line = stack.Items.OfType<string>().ToArray();

            using (StreamWriter file = new StreamWriter(dlg.FileName))
            {
                foreach (string nm in line)
                {
                    file.WriteLine(nm);
                    file.WriteLine(list[nm]);
                }
            }
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {

        }

        private void chan_Click(object sender, RoutedEventArgs e)
        {
            if (stack.SelectedIndex > -1)
            {
                adt = new AddTimer(stack.SelectedValue.ToString(), list[stack.SelectedValue.ToString()]);

                if (adt.ShowDialog() == true)
                {
                    int year = adt.cal.SelectedDate.Value.Year;
                    int mon = adt.cal.SelectedDate.Value.Month;
                    int day = adt.cal.SelectedDate.Value.Day;
                    
                    string name = adt.name.Text;
                    int hrs = int.Parse(adt.hours.Text);
                    int min = int.Parse(adt.min.Text);
                    int sec = int.Parse(adt.sec.Text);
                    
                    list.Remove(stack.SelectedValue.ToString());

                    stack.Items[stack.SelectedIndex] = name;
                    
                    dt = new DateTime(year, mon, day, hrs, min, sec);

                    list.Add(name, dt);
                    //list[stack.SelectedValue.ToString()] =  dt;
                }
            }
        }
    }
}
