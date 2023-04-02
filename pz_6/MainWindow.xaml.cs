using System;
using System.Collections.Generic;
using System.Linq;
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

        private async void startButton_Click(object sender, RoutedEventArgs e)
        {
            // Длительные вычисления с задержкой в 0,5 секунды
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(500); // Ожидание 0,5 секунды

                // Обновление ProgressBar
                progressBar.Value = i * 10;
            }
        }

        private void inkCanvas_StrokeCollected(object sender, InkCanvasStrokeCollectedEventArgs e)
        {
            // Получение новой линии
            Stroke newStroke = e.Stroke;

            // Проверка, не содержится ли линия уже в коллекции strokes
            if (!strokes.Contains(newStroke))
            {
                // Добавление новой линии в коллекцию strokes
                
                strokes.Add(newStroke);
            }
        }
    }
}
