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
using пр8_Данилова.Classes;

namespace пр8_Данилова
{
    public partial class MainWindow : Window
    {
        private LVoin lightVoin = new LVoin();
        private TVoin heavyVoin = new TVoin();
        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void BClick(object sender, RoutedEventArgs e)
        {
            int baseDamage = 40;
            lightVoin.TakeDamage(baseDamage);
            heavyVoin.TakeDamage(baseDamage);
            UpdateUI();
        }

        private void UpdateUI()
        {
            LHText.Text = $"HP: {lightVoin.Health}";
            THText.Text = $"HP: {heavyVoin.Health}";

            if (lightVoin.Health == 0)
            {
                LHText.Foreground = Brushes.Red;
                LHText.Text = "Погиб";
            }
            else
            {
                LVoinImage.Opacity = 0.6 + (0.4 * (lightVoin.Health) / 100);
            }

            if (heavyVoin.Health == 0)
            {
                THText.Foreground = Brushes.Red;
                THText.Text = "Погиб";
            }
            else
            {
                TVoinImage.Opacity = 0.6 + (0.4 * (heavyVoin.Health) / 100);
            }
        }

    }
}
