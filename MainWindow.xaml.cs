using System.Windows;
using System.Windows.Input;

namespace DPGI2
{
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand SaveCommand = new RoutedCommand();
        public static readonly RoutedCommand OpenCommand = new RoutedCommand();
        public static readonly RoutedCommand ClearCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();

            // Прив'язка команди Save
            CommandBinding saveBinding = new CommandBinding(SaveCommand, SaveExecute, SaveCanExecute);
            this.CommandBindings.Add(saveBinding);

            // Прив'язка команди Open
            CommandBinding openBinding = new CommandBinding(OpenCommand, OpenExecute, OpenCanExecute);
            this.CommandBindings.Add(openBinding);

            // Прив'язка команди Clear
            CommandBinding clearBinding = new CommandBinding(ClearCommand, ClearExecute, ClearCanExecute);
            this.CommandBindings.Add(clearBinding);
        }

        // Обробник події Loaded для встановлення фокусу на TextBox
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Focus();
        }

        // Обробники для Save
        private void SaveCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; // Умову можна змінити за потреби
        }

        private void SaveExecute(object sender, ExecutedRoutedEventArgs e)
        {
            // Логіка збереження тексту (наприклад, у файл)
            MessageBox.Show("Text saved!", "Save");
        }

        // Обробники для Open
        private void OpenCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; // Умову можна змінити за потреби
        }

        private void OpenExecute(object sender, ExecutedRoutedEventArgs e)
        {
            // Логіка відкриття файлу
            MessageBox.Show("Open file!", "Open");
        }

        // Обробники для Clear
        private void ClearCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; // Умову можна змінити за потреби
        }

        private void ClearExecute(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Text = string.Empty; // Очищення текстового поля
        }
    }
}