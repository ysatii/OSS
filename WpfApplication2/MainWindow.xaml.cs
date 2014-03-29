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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            listBox2.Items.Add(listBox1.Items.CurrentItem);

        }

        private void Button_Click_(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(listBox2.Items.CurrentItem);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

            
          int l = listBox1.SelectedItems.Count;
         
              for (int i = 0; i < l; i++)
              {
                  listBox2.Items.Add(listBox1.SelectedItems[i]);


              }
          


        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
        
            listBox1.Items.Add(listBox2.Items.CurrentItem);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            int l = listBox2.SelectedItems.Count;

            for (int i = 0; i < l; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);


            }


        }


        
    

       

 

        

    }
}
