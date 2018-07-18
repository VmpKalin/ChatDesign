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

namespace MyFirstControlApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            List<MessageTemplate> items = new List<MessageTemplate>();
            items.Add(new MessageTemplate() { Name = "John Doe",  Message = "John message y" });
            items.Add(new MessageTemplate() { Name = "Jane Doe", Message = "Fjkda jfk adjskjfjad k" });
            items.Add(new MessageTemplate() { Name = "Sammy Doe", Message = "Jfadsjkadsfiodio faid jof odof " });
            items.Add(new MessageTemplate() { Name = "Jane Doe", Message = "Fjkda jfk adjskjfjad k" });
            items.Add(new MessageTemplate() { Name = "Sammy Doe", Message = "Jfadsjkadsfiodio faid jof odof " });
            items.Add(new MessageTemplate() { Name = "Jane Doe", Message = "Fjkda jfk adjskjfjad k" });
            items.Add(new MessageTemplate() { Name = "Sammy Doe", Message = "Jfadsjkadsfiodio faid jof odof " });
            items.Add(new MessageTemplate() { Name = "Jane Doe", Message = "Fjkda jfk adjskjfjad k" });
            items.Add(new MessageTemplate() { Name = "Sammy Doe", Message = "Jfadsjkadsfiodio faid jof odof " });
            //List.ItemsSource = items;
        }

        private void ButtonOpenMenu_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPopupExit_OnClick(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show("Are u sure?", "Exit", MessageBoxButton.YesNo);

            //if (result == MessageBoxResult.Yes)
            Application.Current.Shutdown();

            //e.Handled = true;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void ButtonCloseMenu_OnClick(object sender, RoutedEventArgs e)
        //{
        //    ButtonOpenMenu.Visibility = Visibility.Visible;
        //    ButtonCloseMenu.Visibility = Visibility.Collapsed;
        //    GridMenu.Visibility = Visibility.Collapsed;
        //    GridChat.Visibility = Visibility.Visible;
        //}

        //private void ButtonOpenMenu_OnClick(object sender, RoutedEventArgs e)
        //{
        //    GridMenu.Visibility = Visibility.Visible;
        //    GridChat.Visibility = Visibility.Collapsed;
        //    ButtonOpenMenu.Visibility = Visibility.Collapsed;
        //    ButtonCloseMenu.Visibility = Visibility.Visible;
        //}


    }

    public class MessageTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
