using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Stroke> strokes = new List<Stroke>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var task = ProgressBar(500, progressBar);
            await task;

        }
        public async Task ProgressBar(int a, ProgressBar progressBar)
        {
            int с = 1;
            for (int i = 0; i < a; i++)
            {
                с *= a;
                progressBar.Value += a / 100;
                await Task.Delay(TimeSpan.FromSeconds(0.5));

            }
        }
        //В синхроном режиме, прогресс бар не заполняется вообще, либо делает это настолько быстро, что ничего не понятно.
         //А в асинхронном режиме, прогресс бар заполняется медленно, постепенно так, да и порисовать во время заполнения можно.
    }
}
