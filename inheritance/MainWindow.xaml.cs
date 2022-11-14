using System;
using System.Windows;

namespace inheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            two.IsEnabled = false;
            Clon.IsEnabled = false;
            Compare.IsEnabled = false;
        }
        Father fh = new Father();
        Spinogr_zcs Sh = new Spinogr_zcs();
        Father fh2 = new Father();
        bool flag;
        private void ClearAll()
        {
            Father.Clear();
            Father.Focus();
            Son.Clear();
            two.IsEnabled = false;
            NewHuman.Clear();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string value = Convert.ToString(Father.Text);
                if (value.StartsWith(' '))
                {
                    MessageBox.Show("А так нельзя!!!!!!!!!!");
                    value = " ";
                    Father.Text = null;
                    return;
                }
                bool tmp = fh.PrintName(value, out string name);
                if (tmp)
                {
                    MessageBox.Show("А так нельзя!!!!!!!!!!");
                    value = " ";
                    Father.Text = null;
                    return;

                }
                Sh.SecondName = fh.Name;
                Sh.SureName = fh.SureName;
                MessageBox.Show(name);
                two.IsEnabled = true;
            }
            catch(Exception) { MessageBox.Show("А так нельзя!!!!!!!!!!"); ; ClearAll(); }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string value = Convert.ToString(Son.Text);
                if (value.StartsWith(' '))
                {
                    MessageBox.Show("А так нельзя!!!!!!!!!!");
                    value = " ";
                    Son.Text = null;
                    return;
                }

                bool tmp = Sh.PrintName(value, out string name);
                if (tmp)
                {
                    MessageBox.Show("А так нельзя!!!!!!!!!!");
                    value = " ";
                    Father.Text = null;
                    return;

                }

                MessageBox.Show(name);
            }
            catch(Exception) { MessageBox.Show("А так нельзя!!!!!!!!!!"); ClearAll(); }
            Clon.IsEnabled=true;
            Compare.IsEnabled=true;
        }

        private void MenuCompareClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int tmp = Sh.CompareTo(fh);
                if (tmp == 0)
                {
                    MessageBox.Show("Фамилии идентичны. Это родственники");
                }
                if (tmp > 0)
                {
                    MessageBox.Show("Фамилии не идентичны. Это не родтсвенники");
                }
                if (tmp < 0)
                {
                    MessageBox.Show("Я хз чё сказать");
                }
            }
            catch(Exception) { MessageBox.Show("А так нельзя!!!!!!!!!!"); ClearAll(); }
        }

        private void CloneHuman(object sender, RoutedEventArgs e)
        {
            try
            {
                
                    fh2 = (Father)Sh.Clone();
                    NewHuman.Text = $"{fh2.SureName} \n{fh2.Name} \n{fh2.SecondName}";
                
            }
            catch(Exception) { MessageBox.Show("А так нельзя!!!!!!!!!!"); ClearAll(); }
        }

        private void ClearingTextbox_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }
    }
}
