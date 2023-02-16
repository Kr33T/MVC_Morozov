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

namespace MVC_Morozov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.resultTB = resultTB;
            Model.operSignTB = operSignTB;

            operCB.ItemsSource = Model.operCB_Text;
        }

        private void operCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.operSignTB_set = operCB.SelectedIndex;
        }

        private void solveBTN_Click(object sender, RoutedEventArgs e)
        {
            Model.firstTB = firstTB.Text;
            Model.secondTB = secondTB.Text;
            Model.operResult_set = operCB.SelectedIndex;
        }
    }
}
