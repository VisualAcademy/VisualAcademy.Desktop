using System;
using System.Windows;

namespace VisualAcademy.Desktop.CandidateApp
{
    /// <summary>
    /// Interaction logic for CandidateManager.xaml
    /// </summary>
    public partial class CandidateManager : Window
    {
        public CandidateManager()
        {
            InitializeComponent();
        }

        private void btnAddCandidate_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("직원 후보자 추가");
            btnAddCandidate.Content = $"후보자 추가 완료 {DateTime.Now.Second}";
        }
    }
}
