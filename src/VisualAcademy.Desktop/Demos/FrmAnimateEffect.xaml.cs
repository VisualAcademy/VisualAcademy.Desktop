using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace VisualAcademy.Desktop.Demos
{
    /// <summary>
    /// Interaction logic for FrmAnimateEffect.xaml
    /// </summary>
    public partial class FrmAnimateEffect : Window
    {
        public FrmAnimateEffect()
        {
            InitializeComponent();

            ctlGrid.MouseLeftButtonDown += new MouseButtonEventHandler(ctlGrid_MouseLeftButtonDown);
        }

        void ctlGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 리소스의 스토리보드 찾기
            (Resources["animDropShadow"] as Storyboard)?.Begin();
        }
    }
}
