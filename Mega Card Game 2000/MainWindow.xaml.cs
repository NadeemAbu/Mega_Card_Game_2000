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
using System.Drawing;

namespace Mega_Card_Game_2000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        private string vClassName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startBt(object sender, RoutedEventArgs e)
        {
            Battle battle = new Battle(vClassName);
            NavigationService.Navigate(battle);
        }

        private void thiefBt(object sender, RoutedEventArgs e)
        {

            vClassName = "Thief";

            thiefBtn.Background = System.Windows.Media.Brushes.Blue;
            mageBtn.Background = System.Windows.Media.Brushes.White;
            warriorBtn.Background = System.Windows.Media.Brushes.White;

            thiefBtn.Foreground = System.Windows.Media.Brushes.White;
            mageBtn.Foreground = System.Windows.Media.Brushes.Black;
            warriorBtn.Foreground = System.Windows.Media.Brushes.Black;


            specialAttack.Content = "Backstab";
            info.Content = "Has a 1 in 3 success rate. \n If successful, the backstab does 2X normal damage. \n If unsuccessful the thief only does 0.5 the normal damage.";
            className.Content = "Thief";
            classHealth.Content = "50 HP";
            classDamage.Content = "10 base damage";
        }

        private void warriorBt(object sender, RoutedEventArgs e)
        {
            vClassName = "Warrior";
            thiefBtn.Background = System.Windows.Media.Brushes.White;
            mageBtn.Background = System.Windows.Media.Brushes.White;
            warriorBtn.Background = System.Windows.Media.Brushes.Blue;

            thiefBtn.Foreground = System.Windows.Media.Brushes.Black;
            mageBtn.Foreground = System.Windows.Media.Brushes.Black;
            warriorBtn.Foreground = System.Windows.Media.Brushes.White;

            specialAttack.Content = "Berserk";
            info.Content = "Has a 1 in 3 success rate. \n A failed attempt causes the warrior to take no action / attack in that turn. \n A successful Berserk causes the warriors to do 3X the normal damage that turn.";
            className.Content = "Warrior";
            classHealth.Content = "50 HP";
            classDamage.Content = "10 base damage";
        }

        private void mageBt(object sender, RoutedEventArgs e)
        {
            vClassName = "Mage";
            thiefBtn.Background = System.Windows.Media.Brushes.White;
            mageBtn.Background = System.Windows.Media.Brushes.Blue;
            warriorBtn.Background = System.Windows.Media.Brushes.White;

            thiefBtn.Foreground = System.Windows.Media.Brushes.Black;
            mageBtn.Foreground = System.Windows.Media.Brushes.White;
            warriorBtn.Foreground = System.Windows.Media.Brushes.Black;

            specialAttack.Content = "Fireball";
            info.Content = "Has a 1 in 2 success rate. \n If successful, the fireball does 4 X normal damage. \n If unsuccessful the fireball backfires and does 1X normal damage to the mage.";
            className.Content = "Mage";
            classHealth.Content = "50 HP";
            classDamage.Content = "10 base damage";
        }
    }
}
