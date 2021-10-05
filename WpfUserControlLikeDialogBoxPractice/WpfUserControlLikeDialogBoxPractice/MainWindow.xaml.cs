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

        private void ShowOkDialogBoxButton_Click(object sender, RoutedEventArgs e)
        {
            var title = "OKダイアログボックスの練習";

            var window = new DialogBoxWindowView();
            window.Title = title;

            var page = new OkDialogBoxPage();
            var pageViewModel = (DialogBoxPageViewModel)page.DataContext;
            pageViewModel.Message = "OKダイアログボックスの練習です";
            pageViewModel.OkCommand = new ViewModelCommand(() =>
            {
                var _result = MessageBox.Show(
                    "OKダイアログボックス風のユーザーコントロールのOKボタンを押しました。\nわたしはWindowsデフォルトのメッセージボックスです",
                    title,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
                // ダイアログボックスとして表示しているウィンドウを肯定的に閉じます。
                window.DialogResult = true;
            });

            // Frameのページを差し替えます
            window.frame.Navigate(page);

            var dialogResult = window.ShowDialog() == true;
            Ending(dialogResult);
        }

        private void ShowOkCancelDialogBoxButton_Click(object sender, RoutedEventArgs e)
        {
            var title = "OK, キャンセル ダイアログボックスの練習";

            var window = new DialogBoxWindowView();
            window.Title = title;

            var page = new OkCancelDialogBoxPage();
            var pageViewModel = (DialogBoxPageViewModel)page.DataContext;
            pageViewModel.Message = "OK, キャンセル ダイアログボックスの練習です";
            pageViewModel.OkCommand = new ViewModelCommand(() =>
            {
                var _result = MessageBox.Show(
                    "OK, キャンセル ダイアログボックス風のユーザーコントロールのOKボタンを押しました。\nわたしはWindowsデフォルトのメッセージボックスです",
                    title,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
                // ダイアログボックスとして表示しているウィンドウを肯定的に閉じます。
                window.DialogResult = true;
            });
            pageViewModel.CancelCommand = new ViewModelCommand(() =>
            {
                var _result = MessageBox.Show(
                    "OK, キャンセル ダイアログボックス風のユーザーコントロールのキャンセルボタンを押しました。\nわたしはWindowsデフォルトのメッセージボックスです",
                    title,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
                // ダイアログボックスとして表示しているウィンドウを肯定的に閉じます。
                window.DialogResult = true;
            });

            // Frameのページを差し替えます
            window.frame.Navigate(page);

            var dialogResult = window.ShowDialog() == true;
            Ending(dialogResult);
        }

        /// <summary>
        /// 定型の終了処理
        /// </summary>
        private static void Ending(bool dialogResult)
        {
            if (dialogResult)
            {
                var _result = MessageBox.Show(
                    "肯定的にダイアログボックス風のユーザーコントロールを閉じました。\nわたしはWindowsデフォルトのメッセージボックスです",
                    "エンディング",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
            }
            else
            {
                var _result = MessageBox.Show(
                    "否定的ににダイアログボックス風のユーザーコントロールを閉じました。\nわたしはWindowsデフォルトのメッセージボックスです",
                    "エンディング",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information,
                    MessageBoxResult.OK);
            }
        }
    }
}
