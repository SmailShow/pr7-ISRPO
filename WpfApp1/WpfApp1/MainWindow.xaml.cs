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
using Construction;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Builder construction = new Builder();
            InitializeComponent();
            textblockWallpaper.Text = $"Необходимо {Math.Round(construction.PasteWallpaper(3, 4, 5, 0.5, 1, 1, 2, 2.5))} шт. рулонов";
            textblockLinoleum.Text = $"Необходимо {Math.Round(construction.LayLinoleum(4, 5, 2))} метров линолеума";
            textblockPainting.Text = $"Необходимо {Math.Round(construction.CeilingPainting(4, 5, 0.5, 1.5))} шт. банок краски";
        }
    }
}
