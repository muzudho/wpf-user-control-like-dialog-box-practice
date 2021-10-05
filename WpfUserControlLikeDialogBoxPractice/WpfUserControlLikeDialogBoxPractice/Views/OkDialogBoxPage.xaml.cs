namespace WpfUserControlLikeDialogBoxPractice.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using WpfUserControlLikeDialogBoxPractice.ViewModels;

    /// <summary>
    /// OkDialogBoxPage.xaml の相互作用ロジック
    /// </summary>
    public partial class OkDialogBoxPage : Page
    {
        public OkDialogBoxPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OKボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = (DialogBoxPageViewModel)this.DataContext;
            if (viewModel.OkCommand.CanExecute)
            {
                viewModel.OkCommand.Execute();
            }
        }
    }
}
