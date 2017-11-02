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

namespace Mega_Card_Game_2000
{
    /// <summary>
    /// Interaction logic for Battle.xaml
    /// </summary>
    public partial class Battle : Page
    {
        public Battle(string pClassName)
        {

            InitializeComponent();
            Controller controller = new Controller(this, pClassName);
            player.Content = pClassName;
        }

        private void exitBt(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void normalBt(object sender, RoutedEventArgs e)
        {

        }

        private void specialBt(object sender, RoutedEventArgs e)
        {

        }
    }
}
