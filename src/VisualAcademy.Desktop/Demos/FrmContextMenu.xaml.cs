using System.Windows;

namespace VisualAcademy.Desktop.Demos
{
    /// <summary>
    /// Interaction logic for FrmContextMenu.xaml
    /// </summary>
    public partial class FrmContextMenu : Window
    {
        public FrmContextMenu()
        {
            InitializeComponent();

            miSecond.Click += new RoutedEventHandler(miSecond_Click);
            miThird.Click += (s, e) => { MessageBox.Show("세번째"); };
        }

        void miSecond_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("두번째");
        }

        private void miFirst_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("첫번째 메뉴 클릭됨");
        }
    }
}
