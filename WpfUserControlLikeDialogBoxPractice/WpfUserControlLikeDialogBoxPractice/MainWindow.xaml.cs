namespace WpfUserControlLikeDialogBoxPractice
{
    using Livet.Commands;
    using System.Windows;
    using WpfUserControlLikeDialogBoxPractice.ViewModels;
    using WpfUserControlLikeDialogBoxPractice.Views;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenOkDialogBoxButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new DialogBoxWindowView();

            var page = new OkDialogBoxPage();
            var pageViewModel = (DialogBoxPageViewModel)page.DataContext;
            pageViewModel.Message = "OKダイアログボックスの練習です";
            pageViewModel.OkCommand = new ViewModelCommand(() =>
            {
                var _result = MessageBox.Show(
                    "OKダイアログボックス風のユーザーコントロールのOKボタンを押しました",
                    "これはWindowsデフォルトのメッセージボックスです",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
                // ダイアログボックスとして表示しているウィンドウを肯定的に閉じます。
                window.DialogResult = true;
            });

            window.frame.Navigate(page);

            var dialogResult = window.ShowDialog() == true;
            if (dialogResult)
            {
                var _result = MessageBox.Show(
                    "肯定的にダイアログボックス風のユーザーコントロールを閉じました",
                    "これはWindowsデフォルトのメッセージボックスです",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
            }
            else
            {
                var _result = MessageBox.Show(
                    "否定的ににダイアログボックス風のユーザーコントロールを閉じました",
                    "これはWindowsデフォルトのメッセージボックスです",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
            }
        }
    }
}
