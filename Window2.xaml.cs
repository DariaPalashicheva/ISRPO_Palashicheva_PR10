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

namespace ISRPO_Palashicheva_PR10
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Merc_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/меркурий.jpg", UriKind.Relative));
            textblock1.Text = "Меркурий";
        }

        private void Venera_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/венера.jpg", UriKind.Relative));
            textblock1.Text = "Венера";
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mcLB.Items.Add(textbox1.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mcLB.Items.Remove(mcLB.SelectedItem);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mcLB.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }


        private void Earth_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/земля.jpg", UriKind.Relative));
            textblock1.Text = "Земля";
        }

        private void mars_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/марс.jpg", UriKind.Relative));
            textblock1.Text = "Марс";
        }

        private void jupiter_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/юпитер.jpg", UriKind.Relative));
            textblock1.Text = "Юпитер";
        }

        private void saturn_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/сатурн.png", UriKind.Relative));
            textblock1.Text = "Сатурн";
        }

        private void Uran_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/уран.jpg", UriKind.Relative));
            textblock1.Text = "Уран";
        }

        private void Neptun_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/нептун.jpg", UriKind.Relative));
            textblock1.Text = "Нептун";
        }

        private void Pluton_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("Image/плутон.png", UriKind.Relative));
            textblock1.Text = "Плутон";
        }
    }
}
