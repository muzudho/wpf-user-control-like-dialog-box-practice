namespace WpfUserControlLikeDialogBoxPractice
{
    using System.Windows;
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
