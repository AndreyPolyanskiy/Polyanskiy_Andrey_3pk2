using System;
using System.Collections.Generic;
using System.IO;
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

namespace pz_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Status> status = new List<Status>();
        int cnt = 0;
        int cntsF = 10;
        public MainWindow()
        {
            InitializeComponent();
            SaveText();
        }

        private void buttonBold_Click(object sender, RoutedEventArgs e)
        {
            Bold bold = new Bold(tb1.Selection.Start, tb1.Selection.End);
        }

        private void buttonSize_Click(object sender, RoutedEventArgs e)
        {
            int sz = Convert.ToInt32(txtSize.Text);
            tb1.FontSize = sz;
        }

        private void buttonStyle_Click(object sender, RoutedEventArgs e)
        {
            Underline underline = new Underline(tb1.Selection.Start, tb1.Selection.End);
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            TextRange txt = new TextRange(tb1.Document.ContentStart, tb1.Document.ContentEnd);
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                using (var writer = new StreamWriter(dialog.FileName))
                {
                    writer.Write(txt.Text);
                }
            }
        }

        private void buttonItalic_Click(object sender, RoutedEventArgs e)
        {
            Italic italic = new Italic(tb1.Selection.Start, tb1.Selection.End);
        }

        private void buttonUndo_Click(object sender, RoutedEventArgs e)
        {
            Status status1 = new Status();

            if (cnt < status.Count) status1 = status[status.Count - cnt - 1];
            tb1.FontSize = status1.FontSize;
            tb1.FontStyle = status1.FontStyle;
            tb1.FontWeight = status1.FontWeight;

            FlowDocument doc = new FlowDocument();

            Paragraph p = new Paragraph();

            p.Inlines.Add(new Run(status1.Txt));
            doc.Blocks.Add(p);
            tb1.Document = doc;
            cnt++;
        }

        async Task SaveText()
        {
            TextRange text = new TextRange(tb1.Document.ContentStart, tb1.Document.ContentEnd);
            Status save = new Status(tb1.FontSize, text.Text, tb1.FontWeight, tb1.FontStyle);
            if (cntsF > 0)
            {
                status.Add(save);
                cntsF--;
                MessageBox.Show($"Сохранение");
            }
            else
            {
                status = new List<Status>();
                cntsF = 4;
                status.Add(save);
                MessageBox.Show($"Сохранение");
            }
            await Task.Delay(TimeSpan.FromSeconds(15));
            await SaveText();
        }

        private void buttonAuthor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Андрей Полянский");
        }
    }
}