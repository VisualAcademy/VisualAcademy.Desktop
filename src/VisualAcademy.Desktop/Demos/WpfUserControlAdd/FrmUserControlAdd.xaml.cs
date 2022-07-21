using System.Windows;
using WpfUserControlAdd;

namespace VisualAcademy.Desktop.Demos.WpfUserControlAdd
{
    /// <summary>
    /// Interaction logic for FrmUserControlAdd.xaml
    /// </summary>
    public partial class FrmUserControlAdd : Window
    {
        public FrmUserControlAdd()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            // 동적으로 FileMenu.xaml 사용자 정의 컨트롤을 thePanel 영역에 추가
            FileMenu fm = new FileMenu();
            thePanel.Children.Clear(); //
            thePanel.Children.Add(fm);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var em = new EditMenu();
            thePanel.Children.Clear(); //
            thePanel.Children.Add(em);
        }
    }
}
