using System;
using System.Windows;

namespace VisualAcademy.Desktop.Demos
{
    /// <summary>
    /// Interaction logic for FrmHelloWorld.xaml
    /// </summary>
    public partial class FrmHelloWorld : Window
    {
        public FrmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = $"Hello, WPF! {DateTime.Now.Second}";
        }
    }
}
