using System.Windows;

namespace VisualAcademy.Desktop.TodoApp
{
    /// <summary>
    /// TodoManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TodoManager : Window
    {
        public TodoManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WPF");
        }

        private void btnAddTodo_Click(object sender, RoutedEventArgs e)
        {
            btnAddTodo.Content = "Add";
        }
    }
}
