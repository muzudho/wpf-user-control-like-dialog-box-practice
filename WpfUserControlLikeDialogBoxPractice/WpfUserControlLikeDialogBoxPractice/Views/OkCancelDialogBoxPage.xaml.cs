namespace WpfUserControlLikeDialogBoxPractice.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using WpfUserControlLikeDialogBoxPractice.ViewModels;

    /// <summary>
    /// OkCancelDialogBoxPage.xaml の相互作用ロジック
    /// </summary>
    public partial class OkCancelDialogBoxPage : Page
    {
        public OkCancelDialogBoxPage()
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
            // Tips. ビューの中にロジックを埋め込まず、コマンドに丸投げすることで、ビューのコードを再利用しやすくしています
            var viewModel = (DialogBoxPageViewModel)this.DataContext;
            if (viewModel.OkCommand.CanExecute)
            {
                viewModel.OkCommand.Execute();
            }
        }

        /// <summary>
        /// キャンセルボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Tips. ビューの中にロジックを埋め込まず、コマンドに丸投げすることで、ビューのコードを再利用しやすくしています
            var viewModel = (DialogBoxPageViewModel)this.DataContext;
            if (viewModel.CancelCommand.CanExecute)
            {
                viewModel.CancelCommand.Execute();
            }
        }
    }
}
